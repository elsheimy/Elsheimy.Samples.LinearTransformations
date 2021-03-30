using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace Samples.LinearTransformations
{
  public static class ImageTransformer
  {
    /// <summary>  
    /// Applies image transformations to an image file  
    /// </summary>  
    public static Bitmap Apply(string file, IEnumerable<IImageTransformation> transformations)
    {
      using (Bitmap bmp = (Bitmap)Bitmap.FromFile(file))
      {
        return Apply(bmp, transformations);
      }
    }
    
    /// <summary>
    /// Applies image transformations to image stream.
    /// </summary>
    public static Bitmap Apply(Stream stream, IEnumerable<IImageTransformation> transformations)
    {
      using (Bitmap bmp = (Bitmap)Bitmap.FromStream(stream))
      {
        return Apply(bmp, transformations);
      }
    }

    /// <summary>  
    /// Applies image transformations bitmap object  
    /// </summary>  
    public static Bitmap Apply(Bitmap bmp, IEnumerable<IImageTransformation> transformations)
    {
      // defining an array to store new image data  
      PointColor[] points = new PointColor[bmp.Width * bmp.Height];

      // filtering transformations  
      var pointTransformations =
        transformations.Where(s => s.IsColorTransformation == false).ToArray();
      var colorTransformations =
        transformations.Where(s => s.IsColorTransformation == true).ToArray();

      double[,] pointTransMatrix =
        CreateTransformationMatrix(pointTransformations, 2); // x, y  
      double[,] colorTransMatrix =
        CreateTransformationMatrix(colorTransformations, 4); // a, r, g, b  

      // saving some stats to adjust the image later  
      int minX = 0, minY = 0;
      int maxX = 0, maxY = 0;

      // scanning points and applying transformations  
      int idx = 0;
      for (int x = 0; x < bmp.Width; x++)
      { // row by row  
        for (int y = 0; y < bmp.Height; y++)
        { // column by column  

          // applying the point transformations  
          var product =
            Matrices.Multiply(pointTransMatrix, new double[,] { { x }, { y } });

          var newX = (int)product[0, 0];
          var newY = (int)product[1, 0];

          // saving stats  
          minX = Math.Min(minX, newX);
          minY = Math.Min(minY, newY);
          maxX = Math.Max(maxX, newX);
          maxY = Math.Max(maxY, newY);

          // applying color transformations  
          Color clr = bmp.GetPixel(x, y); // current color  
          var colorProduct = Matrices.Multiply(
            colorTransMatrix,
            new double[,] { { clr.A }, { clr.R }, { clr.G }, { clr.B } });
          clr = Color.FromArgb(
            GetValidColorComponent(colorProduct[0, 0]),
            GetValidColorComponent(colorProduct[1, 0]),
            GetValidColorComponent(colorProduct[2, 0]),
            GetValidColorComponent(colorProduct[3, 0])
            ); // new color  

          // storing new data  
          points[idx] = new PointColor()
          {
            X = newX,
            Y = newY,
            Color = clr
          };

          idx++;
        }
      }

      // new bitmap width and height  
      var width = maxX - minX + 1;
      var height = maxY - minY + 1;

      // new image  
      var img = new Bitmap(width, height);
      foreach (var pnt in points)
        img.SetPixel(
          pnt.X - minX,
          pnt.Y - minY,
          pnt.Color);

      return img;
    }

    /// <summary>  
    /// Returns color component between 0 and 255  
    /// </summary>  
    private static byte GetValidColorComponent(double c)
    {
      c = Math.Max(byte.MinValue, c);
      c = Math.Min(byte.MaxValue, c);
      return (byte)c;
    }

    /// <summary>  
    /// Combines transformations to create single transformation matrix  
    /// </summary>  
    private static double[,] CreateTransformationMatrix
      (IImageTransformation[] vectorTransformations, int dimensions)
    {
      double[,] vectorTransMatrix =
        Matrices.CreateIdentityMatrix(dimensions);

      // combining transformations works by multiplying them  
      foreach (var trans in vectorTransformations)
        vectorTransMatrix =
          Matrices.Multiply(vectorTransMatrix, trans.CreateTransformationMatrix());

      return vectorTransMatrix;
    }
  }
}
