
namespace Samples.LinearImageTransformations.WinApp
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.FileTextBox = new System.Windows.Forms.TextBox();
      this.BrowseButton = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.AngleNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.StretchVertNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.StretchHorizNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.label7 = new System.Windows.Forms.Label();
      this.FlipVerticalCheckBox = new System.Windows.Forms.CheckBox();
      this.FlipHorizontalCheckBox = new System.Windows.Forms.CheckBox();
      this.label8 = new System.Windows.Forms.Label();
      this.DensityAlphaNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.label9 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.DensityRedNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.label11 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.DensityGreenNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.label13 = new System.Windows.Forms.Label();
      this.label14 = new System.Windows.Forms.Label();
      this.DensityBlueNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.label15 = new System.Windows.Forms.Label();
      this.ApplyButton = new System.Windows.Forms.Button();
      this.ExecutionTimeLabel = new System.Windows.Forms.Label();
      this.ImagePictureBox = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.AngleNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.StretchVertNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.StretchHorizNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DensityAlphaNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DensityRedNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DensityGreenNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DensityBlueNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(27, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "File:";
      // 
      // FileTextBox
      // 
      this.FileTextBox.Location = new System.Drawing.Point(45, 12);
      this.FileTextBox.Name = "FileTextBox";
      this.FileTextBox.ReadOnly = true;
      this.FileTextBox.Size = new System.Drawing.Size(431, 20);
      this.FileTextBox.TabIndex = 1;
      // 
      // BrowseButton
      // 
      this.BrowseButton.Location = new System.Drawing.Point(482, 10);
      this.BrowseButton.Name = "BrowseButton";
      this.BrowseButton.Size = new System.Drawing.Size(162, 23);
      this.BrowseButton.TabIndex = 2;
      this.BrowseButton.Text = "Browse...";
      this.BrowseButton.UseVisualStyleBackColor = true;
      this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 40);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(133, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Rotation Angel (Degrees):";
      // 
      // AngleNumericUpDown
      // 
      this.AngleNumericUpDown.Location = new System.Drawing.Point(151, 38);
      this.AngleNumericUpDown.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
      this.AngleNumericUpDown.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
      this.AngleNumericUpDown.Name = "AngleNumericUpDown";
      this.AngleNumericUpDown.Size = new System.Drawing.Size(53, 20);
      this.AngleNumericUpDown.TabIndex = 4;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(210, 40);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(65, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "(-360 - 360)";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(210, 66);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(65, 13);
      this.label4.TabIndex = 8;
      this.label4.Text = "(-100 - 100)";
      // 
      // StretchVertNumericUpDown
      // 
      this.StretchVertNumericUpDown.Location = new System.Drawing.Point(151, 64);
      this.StretchVertNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.StretchVertNumericUpDown.Name = "StretchVertNumericUpDown";
      this.StretchVertNumericUpDown.Size = new System.Drawing.Size(53, 20);
      this.StretchVertNumericUpDown.TabIndex = 7;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(61, 66);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(84, 13);
      this.label5.TabIndex = 6;
      this.label5.Text = "Vertical Stretch:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(210, 92);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(65, 13);
      this.label6.TabIndex = 11;
      this.label6.Text = "(-100 - 100)";
      // 
      // StretchHorizNumericUpDown
      // 
      this.StretchHorizNumericUpDown.Location = new System.Drawing.Point(151, 90);
      this.StretchHorizNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.StretchHorizNumericUpDown.Name = "StretchHorizNumericUpDown";
      this.StretchHorizNumericUpDown.Size = new System.Drawing.Size(53, 20);
      this.StretchHorizNumericUpDown.TabIndex = 10;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(48, 92);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(97, 13);
      this.label7.TabIndex = 9;
      this.label7.Text = "Horizontal Stretch:";
      // 
      // FlipVerticalCheckBox
      // 
      this.FlipVerticalCheckBox.AutoSize = true;
      this.FlipVerticalCheckBox.Location = new System.Drawing.Point(190, 116);
      this.FlipVerticalCheckBox.Name = "FlipVerticalCheckBox";
      this.FlipVerticalCheckBox.Size = new System.Drawing.Size(88, 17);
      this.FlipVerticalCheckBox.TabIndex = 13;
      this.FlipVerticalCheckBox.Text = "Flip Vertically";
      this.FlipVerticalCheckBox.UseVisualStyleBackColor = true;
      // 
      // FlipHorizontalCheckBox
      // 
      this.FlipHorizontalCheckBox.AutoSize = true;
      this.FlipHorizontalCheckBox.Location = new System.Drawing.Point(83, 116);
      this.FlipHorizontalCheckBox.Name = "FlipHorizontalCheckBox";
      this.FlipHorizontalCheckBox.Size = new System.Drawing.Size(101, 17);
      this.FlipHorizontalCheckBox.TabIndex = 12;
      this.FlipHorizontalCheckBox.Text = "Flip Horizontally";
      this.FlipHorizontalCheckBox.UseVisualStyleBackColor = true;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(427, 42);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(49, 13);
      this.label8.TabIndex = 16;
      this.label8.Text = "(0 - 200)";
      // 
      // DensityAlphaNumericUpDown
      // 
      this.DensityAlphaNumericUpDown.Location = new System.Drawing.Point(368, 38);
      this.DensityAlphaNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
      this.DensityAlphaNumericUpDown.Name = "DensityAlphaNumericUpDown";
      this.DensityAlphaNumericUpDown.Size = new System.Drawing.Size(53, 20);
      this.DensityAlphaNumericUpDown.TabIndex = 15;
      this.DensityAlphaNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(324, 42);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(38, 13);
      this.label9.TabIndex = 14;
      this.label9.Text = "Alpha:";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(427, 68);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(49, 13);
      this.label10.TabIndex = 19;
      this.label10.Text = "(0 - 200)";
      // 
      // DensityRedNumericUpDown
      // 
      this.DensityRedNumericUpDown.Location = new System.Drawing.Point(368, 64);
      this.DensityRedNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
      this.DensityRedNumericUpDown.Name = "DensityRedNumericUpDown";
      this.DensityRedNumericUpDown.Size = new System.Drawing.Size(53, 20);
      this.DensityRedNumericUpDown.TabIndex = 18;
      this.DensityRedNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(332, 68);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(30, 13);
      this.label11.TabIndex = 17;
      this.label11.Text = "Red:";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(427, 94);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(49, 13);
      this.label12.TabIndex = 22;
      this.label12.Text = "(0 - 200)";
      // 
      // DensityGreenNumericUpDown
      // 
      this.DensityGreenNumericUpDown.Location = new System.Drawing.Point(368, 90);
      this.DensityGreenNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
      this.DensityGreenNumericUpDown.Name = "DensityGreenNumericUpDown";
      this.DensityGreenNumericUpDown.Size = new System.Drawing.Size(53, 20);
      this.DensityGreenNumericUpDown.TabIndex = 21;
      this.DensityGreenNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(322, 94);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(40, 13);
      this.label13.TabIndex = 20;
      this.label13.Text = "Green:";
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Location = new System.Drawing.Point(427, 120);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(49, 13);
      this.label14.TabIndex = 25;
      this.label14.Text = "(0 - 200)";
      // 
      // DensityBlueNumericUpDown
      // 
      this.DensityBlueNumericUpDown.Location = new System.Drawing.Point(368, 116);
      this.DensityBlueNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
      this.DensityBlueNumericUpDown.Name = "DensityBlueNumericUpDown";
      this.DensityBlueNumericUpDown.Size = new System.Drawing.Size(53, 20);
      this.DensityBlueNumericUpDown.TabIndex = 24;
      this.DensityBlueNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.Location = new System.Drawing.Point(331, 120);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(31, 13);
      this.label15.TabIndex = 23;
      this.label15.Text = "Blue:";
      // 
      // ApplyButton
      // 
      this.ApplyButton.Location = new System.Drawing.Point(482, 115);
      this.ApplyButton.Name = "ApplyButton";
      this.ApplyButton.Size = new System.Drawing.Size(162, 23);
      this.ApplyButton.TabIndex = 26;
      this.ApplyButton.Text = "Apply";
      this.ApplyButton.UseVisualStyleBackColor = true;
      this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
      // 
      // ExecutionTimeLabel
      // 
      this.ExecutionTimeLabel.AutoSize = true;
      this.ExecutionTimeLabel.Location = new System.Drawing.Point(12, 432);
      this.ExecutionTimeLabel.Name = "ExecutionTimeLabel";
      this.ExecutionTimeLabel.Size = new System.Drawing.Size(181, 13);
      this.ExecutionTimeLabel.TabIndex = 28;
      this.ExecutionTimeLabel.Text = "Total execution time is 0 milliseconds";
      // 
      // ImagePictureBox
      // 
      this.ImagePictureBox.Location = new System.Drawing.Point(15, 144);
      this.ImagePictureBox.Name = "ImagePictureBox";
      this.ImagePictureBox.Size = new System.Drawing.Size(629, 285);
      this.ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.ImagePictureBox.TabIndex = 29;
      this.ImagePictureBox.TabStop = false;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(656, 454);
      this.Controls.Add(this.ImagePictureBox);
      this.Controls.Add(this.ExecutionTimeLabel);
      this.Controls.Add(this.ApplyButton);
      this.Controls.Add(this.label14);
      this.Controls.Add(this.DensityBlueNumericUpDown);
      this.Controls.Add(this.label15);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.DensityGreenNumericUpDown);
      this.Controls.Add(this.label13);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.DensityRedNumericUpDown);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.DensityAlphaNumericUpDown);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.FlipHorizontalCheckBox);
      this.Controls.Add(this.FlipVerticalCheckBox);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.StretchHorizNumericUpDown);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.StretchVertNumericUpDown);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.AngleNumericUpDown);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.BrowseButton);
      this.Controls.Add(this.FileTextBox);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "MainForm";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Image Transformations";
      ((System.ComponentModel.ISupportInitialize)(this.AngleNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.StretchVertNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.StretchHorizNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DensityAlphaNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DensityRedNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DensityGreenNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DensityBlueNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox FileTextBox;
    private System.Windows.Forms.Button BrowseButton;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown AngleNumericUpDown;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.NumericUpDown StretchVertNumericUpDown;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.NumericUpDown StretchHorizNumericUpDown;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.CheckBox FlipVerticalCheckBox;
    private System.Windows.Forms.CheckBox FlipHorizontalCheckBox;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.NumericUpDown DensityAlphaNumericUpDown;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.NumericUpDown DensityRedNumericUpDown;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.NumericUpDown DensityGreenNumericUpDown;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.NumericUpDown DensityBlueNumericUpDown;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.Button ApplyButton;
    private System.Windows.Forms.Label ExecutionTimeLabel;
    private System.Windows.Forms.PictureBox ImagePictureBox;
  }
}

