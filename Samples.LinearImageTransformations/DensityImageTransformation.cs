namespace Samples.LinearTransformations
{
  public class DensityImageTransformation : IImageTransformation
  {
    public double AlphaDensity { get; set; }
    public double RedDensity { get; set; }
    public double GreenDensity { get; set; }
    public double BlueDensity { get; set; }
    public bool IsColorTransformation { get { return true; } }

    public double[,] CreateTransformationMatrix()
    {
      // identity matrix  
      double[,] matrix = new double[,]{
      { AlphaDensity, 0, 0, 0},
      { 0, RedDensity, 0, 0},
      { 0, 0, GreenDensity, 0},
      { 0, 0, 0, BlueDensity},
    };

      return matrix;
    }

    public DensityImageTransformation() { }
    public DensityImageTransformation(double alphaDensity,
      double redDensity,
      double greenDensity,
      double blueDensity)
    {
      this.AlphaDensity = alphaDensity;
      this.RedDensity = redDensity;
      this.GreenDensity = greenDensity;
      this.BlueDensity = blueDensity;
    }
  }
}
