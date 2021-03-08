////////////////////////////////////////////////////////////////////////////////
// ColorEditor.Designer.cs 
////////////////////////////////////////////////////////////////////////////////
//
// MiForms - A basic set of Windows Forms controls for use with SFML.
// Copyright (C) 2021 Michael Furlong <michaeljfurlong@outlook.com>
//
// This program is free software: you can redistribute it and/or modify it 
// under the terms of the GNU General Public License as published by the Free 
// Software Foundation, either version 3 of the License, or (at your option) 
// any later version.
//
// This program is distributed in the hope that it will be useful, but WITHOUT
// ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or 
// FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for 
// more details.
// 
// You should have received a copy of the GNU General Public License along with
// this program. If not, see <https://www.gnu.org/licenses/>.
//
////////////////////////////////////////////////////////////////////////////////

namespace MiForms
{
	partial class ColorEditor
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorEditor));
			this.label = new System.Windows.Forms.Label();
			this.rLab = new System.Windows.Forms.Label();
			this.gLab = new System.Windows.Forms.Label();
			this.bLab = new System.Windows.Forms.Label();
			this.aLab = new System.Windows.Forms.Label();
			this.colBut = new System.Windows.Forms.Button();
			this.colImages = new System.Windows.Forms.ImageList(this.components);
			this.colDialog = new System.Windows.Forms.ColorDialog();
			this.aBox = new MiForms.NumberBox();
			this.bBox = new MiForms.NumberBox();
			this.gBox = new MiForms.NumberBox();
			this.rBox = new MiForms.NumberBox();
			this.SuspendLayout();
			// 
			// label
			// 
			this.label.Location = new System.Drawing.Point(0, 0);
			this.label.Margin = new System.Windows.Forms.Padding(0);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(117, 23);
			this.label.TabIndex = 2;
			this.label.Text = "Color";
			this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rLab
			// 
			this.rLab.Location = new System.Drawing.Point(117, 0);
			this.rLab.Margin = new System.Windows.Forms.Padding(0);
			this.rLab.Name = "rLab";
			this.rLab.Size = new System.Drawing.Size(25, 23);
			this.rLab.TabIndex = 1;
			this.rLab.Text = "R";
			this.rLab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// gLab
			// 
			this.gLab.Location = new System.Drawing.Point(189, 0);
			this.gLab.Margin = new System.Windows.Forms.Padding(0);
			this.gLab.Name = "gLab";
			this.gLab.Size = new System.Drawing.Size(25, 23);
			this.gLab.TabIndex = 4;
			this.gLab.Text = "G";
			this.gLab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// bLab
			// 
			this.bLab.Location = new System.Drawing.Point(261, 0);
			this.bLab.Margin = new System.Windows.Forms.Padding(0);
			this.bLab.Name = "bLab";
			this.bLab.Size = new System.Drawing.Size(25, 23);
			this.bLab.TabIndex = 6;
			this.bLab.Text = "B";
			this.bLab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// aLab
			// 
			this.aLab.Location = new System.Drawing.Point(333, 0);
			this.aLab.Margin = new System.Windows.Forms.Padding(0);
			this.aLab.Name = "aLab";
			this.aLab.Size = new System.Drawing.Size(25, 23);
			this.aLab.TabIndex = 8;
			this.aLab.Text = "A";
			this.aLab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// colBut
			// 
			this.colBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("colBut.BackgroundImage")));
			this.colBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.colBut.FlatAppearance.BorderSize = 0;
			this.colBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.colBut.Location = new System.Drawing.Point(416, 2);
			this.colBut.Margin = new System.Windows.Forms.Padding(9, 0, 0, 0);
			this.colBut.Name = "colBut";
			this.colBut.Size = new System.Drawing.Size(19, 19);
			this.colBut.TabIndex = 4;
			this.colBut.UseVisualStyleBackColor = true;
			this.colBut.Click += new System.EventHandler(this.ColorPickerClicked);
			// 
			// colImages
			// 
			this.colImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("colImages.ImageStream")));
			this.colImages.TransparentColor = System.Drawing.Color.Transparent;
			this.colImages.Images.SetKeyName(0, "DarkEyeDropper.png");
			this.colImages.Images.SetKeyName(1, "LightEyeDropper.png");
			// 
			// colDialog
			// 
			this.colDialog.AnyColor = true;
			this.colDialog.FullOpen = true;
			// 
			// aBox
			// 
			this.aBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.aBox.DecimalPlaces = ((uint)(0u));
			this.aBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.aBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.aBox.Location = new System.Drawing.Point(358, 0);
			this.aBox.Margin = new System.Windows.Forms.Padding(0);
			this.aBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.aBox.MaximumSize = new System.Drawing.Size(116667, 23);
			this.aBox.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.aBox.MinimumSize = new System.Drawing.Size(23, 23);
			this.aBox.Name = "aBox";
			this.aBox.Size = new System.Drawing.Size(47, 23);
			this.aBox.TabIndex = 3;
			this.aBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.aBox.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// bBox
			// 
			this.bBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.bBox.DecimalPlaces = ((uint)(0u));
			this.bBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.bBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.bBox.Location = new System.Drawing.Point(286, 0);
			this.bBox.Margin = new System.Windows.Forms.Padding(0);
			this.bBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.bBox.MaximumSize = new System.Drawing.Size(116667, 23);
			this.bBox.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.bBox.MinimumSize = new System.Drawing.Size(23, 23);
			this.bBox.Name = "bBox";
			this.bBox.Size = new System.Drawing.Size(47, 23);
			this.bBox.TabIndex = 2;
			this.bBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.bBox.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// gBox
			// 
			this.gBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.gBox.DecimalPlaces = ((uint)(0u));
			this.gBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.gBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.gBox.Location = new System.Drawing.Point(214, 0);
			this.gBox.Margin = new System.Windows.Forms.Padding(0);
			this.gBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.gBox.MaximumSize = new System.Drawing.Size(116667, 23);
			this.gBox.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.gBox.MinimumSize = new System.Drawing.Size(23, 23);
			this.gBox.Name = "gBox";
			this.gBox.Size = new System.Drawing.Size(47, 23);
			this.gBox.TabIndex = 1;
			this.gBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.gBox.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// rBox
			// 
			this.rBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.rBox.DecimalPlaces = ((uint)(0u));
			this.rBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.rBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.rBox.Location = new System.Drawing.Point(146, 0);
			this.rBox.Margin = new System.Windows.Forms.Padding(0);
			this.rBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.rBox.MaximumSize = new System.Drawing.Size(116667, 23);
			this.rBox.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.rBox.MinimumSize = new System.Drawing.Size(23, 23);
			this.rBox.Name = "rBox";
			this.rBox.Size = new System.Drawing.Size(47, 23);
			this.rBox.TabIndex = 0;
			this.rBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.rBox.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// ColorEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.Controls.Add(this.aBox);
			this.Controls.Add(this.bBox);
			this.Controls.Add(this.gBox);
			this.Controls.Add(this.rBox);
			this.Controls.Add(this.label);
			this.Controls.Add(this.rLab);
			this.Controls.Add(this.colBut);
			this.Controls.Add(this.gLab);
			this.Controls.Add(this.aLab);
			this.Controls.Add(this.bLab);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.Margin = new System.Windows.Forms.Padding(0);
			this.MaximumSize = new System.Drawing.Size(10000, 23);
			this.MinimumSize = new System.Drawing.Size(240, 23);
			this.Name = "ColorEditor";
			this.Size = new System.Drawing.Size(440, 23);
			this.Load += new System.EventHandler(this.OnLoadControl);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Label rLab;
		private System.Windows.Forms.Label gLab;
		private System.Windows.Forms.Label bLab;
		private System.Windows.Forms.Label aLab;
		private System.Windows.Forms.Button colBut;
		private System.Windows.Forms.ColorDialog colDialog;
		private NumberBox rBox;
		private NumberBox gBox;
		private NumberBox bBox;
		private NumberBox aBox;
		private System.Windows.Forms.ImageList colImages;
	}
}
