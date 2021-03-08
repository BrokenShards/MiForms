////////////////////////////////////////////////////////////////////////////////
// NumberBox.Designer.cs 
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
	partial class NumberBox
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumberBox));
			this.numBox = new System.Windows.Forms.NumericUpDown();
			this.boxPanel = new System.Windows.Forms.Panel();
			this.upBut = new System.Windows.Forms.Button();
			this.downBut = new System.Windows.Forms.Button();
			this.butPanel = new System.Windows.Forms.Panel();
			this.butImages = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this.numBox)).BeginInit();
			this.boxPanel.SuspendLayout();
			this.butPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// numBox
			// 
			this.numBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.numBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.numBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.numBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.numBox.Location = new System.Drawing.Point(0, 0);
			this.numBox.Margin = new System.Windows.Forms.Padding(0);
			this.numBox.Name = "numBox";
			this.numBox.Size = new System.Drawing.Size(266, 19);
			this.numBox.TabIndex = 0;
			// 
			// boxPanel
			// 
			this.boxPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.boxPanel.Controls.Add(this.numBox);
			this.boxPanel.Location = new System.Drawing.Point(2, 2);
			this.boxPanel.Margin = new System.Windows.Forms.Padding(0);
			this.boxPanel.Name = "boxPanel";
			this.boxPanel.Size = new System.Drawing.Size(245, 18);
			this.boxPanel.TabIndex = 1;
			// 
			// upBut
			// 
			this.upBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("upBut.BackgroundImage")));
			this.upBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.upBut.FlatAppearance.BorderSize = 0;
			this.upBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.upBut.Location = new System.Drawing.Point(0, 0);
			this.upBut.Margin = new System.Windows.Forms.Padding(0);
			this.upBut.Name = "upBut";
			this.upBut.Size = new System.Drawing.Size(14, 12);
			this.upBut.TabIndex = 51;
			this.upBut.TabStop = false;
			this.upBut.UseVisualStyleBackColor = true;
			this.upBut.Click += new System.EventHandler(this.UpClicked);
			// 
			// downBut
			// 
			this.downBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("downBut.BackgroundImage")));
			this.downBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.downBut.FlatAppearance.BorderSize = 0;
			this.downBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.downBut.Location = new System.Drawing.Point(0, 12);
			this.downBut.Margin = new System.Windows.Forms.Padding(0);
			this.downBut.Name = "downBut";
			this.downBut.Size = new System.Drawing.Size(14, 12);
			this.downBut.TabIndex = 52;
			this.downBut.TabStop = false;
			this.downBut.UseVisualStyleBackColor = true;
			this.downBut.Click += new System.EventHandler(this.DownClicked);
			// 
			// butPanel
			// 
			this.butPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.butPanel.Controls.Add(this.upBut);
			this.butPanel.Controls.Add(this.downBut);
			this.butPanel.Location = new System.Drawing.Point(248, 0);
			this.butPanel.Margin = new System.Windows.Forms.Padding(0);
			this.butPanel.Name = "butPanel";
			this.butPanel.Size = new System.Drawing.Size(14, 23);
			this.butPanel.TabIndex = 53;
			// 
			// butImages
			// 
			this.butImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("butImages.ImageStream")));
			this.butImages.TransparentColor = System.Drawing.Color.Transparent;
			this.butImages.Images.SetKeyName(0, "DarkUp.png");
			this.butImages.Images.SetKeyName(1, "DarkDown.png");
			this.butImages.Images.SetKeyName(2, "LightUp.png");
			this.butImages.Images.SetKeyName(3, "LightDown.png");
			// 
			// NumberBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.Controls.Add(this.butPanel);
			this.Controls.Add(this.boxPanel);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.MaximumSize = new System.Drawing.Size(116667, 23);
			this.MinimumSize = new System.Drawing.Size(23, 23);
			this.Name = "NumberBox";
			this.Size = new System.Drawing.Size(262, 23);
			((System.ComponentModel.ISupportInitialize)(this.numBox)).EndInit();
			this.boxPanel.ResumeLayout(false);
			this.butPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.NumericUpDown numBox;
		private System.Windows.Forms.Panel boxPanel;
		private System.Windows.Forms.Button upBut;
		private System.Windows.Forms.Button downBut;
		private System.Windows.Forms.Panel butPanel;
		private System.Windows.Forms.ImageList butImages;
	}
}
