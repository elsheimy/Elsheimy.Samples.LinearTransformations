namespace Samples.LinearTransformations
{
  public class StretchImageTransformation : IImageTransformation
  {
    public double HorizontalStretch { get; set; }
    public double VerticalStretch { get; set; }

    public bool IsColorTransformation { get { return false; } }

    public double[,] CreateTransformationMatrix()
    {
      double[,] matrix = Matrices.CreateIdentityMatrix(2);

      matrix[0, 0] += HorizontalStretch;
      matrix[1, 1] += VerticalStretch;

      return matrix;
    }

    public StretchImageTransformation() { }
    public StretchImageTransformation(double horizStretch, double vertStretch)
    {
      this.HorizontalStretch = horizStretch;
      this.VerticalStretch = vertStretch;
    }
  }
}
