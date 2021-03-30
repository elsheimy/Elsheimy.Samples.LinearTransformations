namespace Samples.LinearTransformations
{
  public class FlipImageTransformation : IImageTransformation
  {
    public bool FlipHorizontally { get; set; }
    public bool FlipVertically { get; set; }
    public bool IsColorTransformation { get { return false; } }

    public double[,] CreateTransformationMatrix()
    {
      // identity matrix  
      double[,] matrix = Matrices.CreateIdentityMatrix(2);

      if (FlipHorizontally)
        matrix[0, 0] *= -1;
      if (FlipVertically)
        matrix[1, 1] *= -1;

      return matrix;
    }

    public FlipImageTransformation() { }
    public FlipImageTransformation(bool flipHoriz, bool flipVert)
    {
      this.FlipHorizontally = flipHoriz;
      this.FlipVertically = flipVert;
    }
  }
}
