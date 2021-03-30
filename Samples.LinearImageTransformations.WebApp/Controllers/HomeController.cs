using Microsoft.AspNetCore.Mvc;
using Samples.LinearImageTransformations.WebApp.ViewModels;
using Samples.LinearTransformations;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace Samples.LinearImageTransformations.WebApp.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      TransformationsViewModel viewModel = new TransformationsViewModel();
      viewModel.DensityAlpha = viewModel.DensityRed = viewModel.DensityGreen = viewModel.DensityBlue = 100;
      return View(viewModel);
    }

    [HttpPost]
    public IActionResult Index(TransformationsViewModel viewModel)
    {
      if (this.ModelState.IsValid)
      {
        viewModel.ImageBytes = TransformImage(viewModel);
      }
      return View(nameof(Index), viewModel);
    }

    private byte[] TransformImage(TransformationsViewModel viewModel)
    {
      var transformations = LoadImageTransformations(viewModel);

      Bitmap bmp = null;

      using (MemoryStream stm = new MemoryStream())
      {
        viewModel.File.CopyTo(stm);

        bmp = ImageTransformer.Apply(stm, transformations);

        // clear memory stream
        stm.Position = 0;
        stm.SetLength(0);

        bmp.Save(stm, System.Drawing.Imaging.ImageFormat.Png);
        return stm.ToArray();
      }


    }

    private static IEnumerable<IImageTransformation> LoadImageTransformations(TransformationsViewModel viewModel)
    {
      List<IImageTransformation> transformations = new List<IImageTransformation>(4);

      if (viewModel.Angle != 0)
      {
        transformations.Add(
          new RotationImageTransformation((double)viewModel.Angle));
      }

      if (viewModel.StretchHorizontal != 0 || viewModel.StretchVertical != 0)
      {
        transformations.Add(
          new StretchImageTransformation(
            (double)viewModel.StretchHorizontal / 100,
            (double)viewModel.StretchVertical / 100));
      }

      if (viewModel.FlipHorizontally || viewModel.FlipVertically)
      {
        transformations.Add(
          new FlipImageTransformation(viewModel.FlipHorizontally, viewModel.FlipVertically));
      }

      if (new decimal[]
      {
        viewModel.DensityAlpha,
        viewModel.DensityRed,
        viewModel.DensityGreen,
        viewModel.DensityBlue
      }.Any(a => a != 100))
      {
        transformations.Add(
          new DensityImageTransformation(
            (double)viewModel.DensityAlpha / 100,
            (double)viewModel.DensityRed / 100,
            (double)viewModel.DensityGreen / 100,
            (double)viewModel.DensityBlue / 100
          ));
      }

      return transformations;
    }
  }
}
