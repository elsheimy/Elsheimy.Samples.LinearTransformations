using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Samples.LinearImageTransformations.WebApp.ViewModels
{
  public class TransformationsViewModel
  {
    [Required(ErrorMessage ="Please select file.")]
    public IFormFile File{ get; set; }

    public byte[]  ImageBytes { get; set; }
    public string ImageData
    {
      get
      {
        if (null == ImageBytes)
          return null;

        return string.Format("data:image/png;base64,{0}", Convert.ToBase64String(ImageBytes));
      }
    }


    [Required(ErrorMessage ="Required")]
    [Range(-360, 360, ErrorMessage ="Invalid number")]
    public int Angle { get; set; }


    [Required(ErrorMessage = "Required")]
    [Range(-100, 100, ErrorMessage = "Invalid number")]
    public int StretchHorizontal { get; set; }

    [Required(ErrorMessage = "Required")]
    [Range(-100, 100, ErrorMessage = "Invalid number")]
    public int StretchVertical { get; set; }


    [Required(ErrorMessage = "Required")]
    [Range(0, 200, ErrorMessage = "Invalid number")]
    public int DensityAlpha { get; set; }

    [Required(ErrorMessage = "Required")]
    [Range(0, 200, ErrorMessage = "Invalid number")]
    public int DensityRed { get; set; }

    [Required(ErrorMessage = "Required")]
    [Range(0, 200, ErrorMessage = "Invalid number")]
    public int DensityGreen { get; set; }

    [Required(ErrorMessage = "Required")]
    [Range(0, 200, ErrorMessage = "Invalid number")]
    public int DensityBlue { get; set; }


    [Required(ErrorMessage = "Required")]
    public bool FlipHorizontally { get; set; }

    [Required(ErrorMessage = "Required")]
    public bool FlipVertically { get; set; }
  }
}
