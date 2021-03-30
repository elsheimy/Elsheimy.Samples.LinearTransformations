using System;

namespace Samples.LinearTransformations
{
  public class RotationImageTransformation : IImageTransformation
  {
    public double AngleDegrees { get; set; }
    public double AngleRadians
    {
      get { return DegreesToRadians(AngleDegrees); }
      set { AngleDegrees = RadiansToDegrees(value); }
    }
    public bool IsColorTransformation { get { return false; } }

    public static double DegreesToRadians(double degree)
    { return degree * Math.PI / 180; }
    public static double RadiansToDegrees(double radians)
    { return radians / Math.PI * 180; }

    public double[,] CreateTransformationMatrix()
    {
      double[,] matrix = new double[2, 2];

      matrix[0, 0] = Math.Cos(AngleRadians);
      matrix[1, 0] = Math.Sin(AngleRadians);
      matrix[0, 1] = -1 * Math.Sin(AngleRadians);
      matrix[1, 1] = Math.Cos(AngleRadians);

      return matrix;
    }

    public RotationImageTransformation() { }
    public RotationImageTransformation(double angleDegree)
    {
      this.AngleDegrees = angleDegree;
    }
  }
}
