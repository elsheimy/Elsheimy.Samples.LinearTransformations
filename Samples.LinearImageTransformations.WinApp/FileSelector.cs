using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samples.LinearImageTransformations.WinApp
{
  static class FileSelector
  {
    public static string OpenFile()
    {
      OpenFileDialog dlg = new OpenFileDialog();
      dlg.CheckFileExists = true;

      if (dlg.ShowDialog() == DialogResult.OK)
        return dlg.FileName;

      return null;
    }
  }
}
