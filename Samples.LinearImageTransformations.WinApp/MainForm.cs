using Samples.LinearTransformations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samples.LinearImageTransformations.WinApp
{
  public partial class MainForm : Form
  {
    private string _file;


    public MainForm()
    {
      InitializeComponent();
    }

    private void BrowseButton_Click(object sender, EventArgs e)
    {
      string file = FileSelector.OpenFile();
      if (file != null)
      {
        this.FileTextBox.Text = file;

        _file = file;

        LoadImageFile();
      }
    }

    private void LoadImageFile()
    {
      this.ImagePictureBox.Image = Image.FromFile(_file);
    }

    #region Stopwatch
    private Stopwatch _stopwatch;

    private void StartStopwatch()
    {
      if (_stopwatch == null)
        _stopwatch = new Stopwatch();
      else
        _stopwatch.Reset();

      _stopwatch.Start();
    }

    private void StopStopwatch()
    {
      _stopwatch.Stop();
      this.ExecutionTimeLabel.Text = $"Total execution time is {_stopwatch.ElapsedMilliseconds} milliseconds";
    }
    #endregion

    private void DisposePreviousImage()
    {
      if (this.ImagePictureBox.Image != null)
      {
        var tmpImg = this.ImagePictureBox.Image;
        this.ImagePictureBox.Image = null;
        tmpImg.Dispose();
      }

    }

    private void ApplyButton_Click(object sender, EventArgs e)
    {
      if (_file == null)
        return;


      List<IImageTransformation> transformations = new List<IImageTransformation>(4);

      if (this.AngleNumericUpDown.Value != 0)
      {
        transformations.Add(
          new RotationImageTransformation((double)this.AngleNumericUpDown.Value));
      }

      if (this.StretchHorizNumericUpDown.Value != 0 || this.StretchVertNumericUpDown.Value != 0)
      {
        transformations.Add(
          new StretchImageTransformation(
            (double)this.StretchHorizNumericUpDown.Value / 100,
            (double)this.StretchVertNumericUpDown.Value / 100));
      }

      if (this.FlipHorizontalCheckBox.Checked || this.FlipVerticalCheckBox.Checked)
      {
        transformations.Add(
          new FlipImageTransformation(this.FlipHorizontalCheckBox.Checked, this.FlipVerticalCheckBox.Checked));
      }

      if (new decimal[]
      {
        this.DensityAlphaNumericUpDown.Value,
        this.DensityRedNumericUpDown.Value,
        this.DensityGreenNumericUpDown.Value,
        this.DensityBlueNumericUpDown.Value
      }.Any(a => a != 100))
      {
        transformations.Add(
          new DensityImageTransformation(
            (double)this.DensityAlphaNumericUpDown.Value / 100,
            (double)this.DensityRedNumericUpDown.Value / 100,
            (double)this.DensityGreenNumericUpDown.Value / 100,
            (double)this.DensityBlueNumericUpDown.Value / 100
          ));
      }

      DisposePreviousImage();
      StartStopwatch();


      if (transformations.Any())
      {
        var bmp = ImageTransformer.Apply(_file, transformations.ToArray());

        this.ImagePictureBox.Image = bmp;
      }
      else
        LoadImageFile();

      StopStopwatch();
    }
  }
}
