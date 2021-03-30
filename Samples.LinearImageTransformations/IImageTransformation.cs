namespace Samples.LinearTransformations
{
  public interface IImageTransformation
  {
    double[,] CreateTransformationMatrix();

    bool IsColorTransformation { get; }
  }
}
