////////////////////////////////////////////////////////////////////////////////
// WindowButtons.Designer.cs 
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
	partial class WindowButtons
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowButtons));
			this.minBut = new System.Windows.Forms.Button();
			this.maxBut = new System.Windows.Forms.Button();
			this.closeBut = new System.Windows.Forms.Button();
			this.panel = new System.Windows.Forms.FlowLayoutPanel();
			this.butImages = new System.Windows.Forms.ImageList(this.components);
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// minBut
			// 
			this.minBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minBut.BackgroundImage")));
			this.minBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.minBut.FlatAppearance.BorderSize = 0;
			this.minBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.minBut.Location = new System.Drawing.Point(3, 3);
			this.minBut.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
			this.minBut.Name = "minBut";
			this.minBut.Size = new System.Drawing.Size(24, 24);
			this.minBut.TabIndex = 0;
			this.minBut.UseVisualStyleBackColor = true;
			this.minBut.Click += new System.EventHandler(this.MinimizedClicked);
			// 
			// maxBut
			// 
			this.maxBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maxBut.BackgroundImage")));
			this.maxBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.maxBut.FlatAppearance.BorderSize = 0;
			this.maxBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.maxBut.Location = new System.Drawing.Point(36, 6);
			this.maxBut.Margin = new System.Windows.Forms.Padding(6);
			this.maxBut.Name = "maxBut";
			this.maxBut.Size = new System.Drawing.Size(18, 18);
			this.maxBut.TabIndex = 1;
			this.maxBut.UseVisualStyleBackColor = true;
			this.maxBut.Click += new System.EventHandler(this.MaximizedClicked);
			// 
			// closeBut
			// 
			this.closeBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeBut.BackgroundImage")));
			this.closeBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.closeBut.FlatAppearance.BorderSize = 0;
			this.closeBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeBut.Location = new System.Drawing.Point(63, 3);
			this.closeBut.Name = "closeBut";
			this.closeBut.Size = new System.Drawing.Size(24, 24);
			this.closeBut.TabIndex = 2;
			this.closeBut.UseVisualStyleBackColor = true;
			this.closeBut.Click += new System.EventHandler(this.CloseClicked);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.closeBut);
			this.panel.Controls.Add(this.maxBut);
			this.panel.Controls.Add(this.minBut);
			this.panel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.panel.Location = new System.Drawing.Point(0, 0);
			this.panel.Margin = new System.Windows.Forms.Padding(0);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(90, 30);
			this.panel.TabIndex = 60;
			// 
			// butImages
			// 
			this.butImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("butImages.ImageStream")));
			this.butImages.TransparentColor = System.Drawing.Color.Transparent;
			this.butImages.Images.SetKeyName(0, "DarkMinimize.png");
			this.butImages.Images.SetKeyName(1, "DarkSqaure.png");
			this.butImages.Images.SetKeyName(2, "DarkClose.png");
			this.butImages.Images.SetKeyName(3, "LightMinimize.png");
			this.butImages.Images.SetKeyName(4, "LightSqaure.png");
			this.butImages.Images.SetKeyName(5, "LightClose.png");
			// 
			// WindowButtons
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.Controls.Add(this.panel);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.Margin = new System.Windows.Forms.Padding(0);
			this.MaximumSize = new System.Drawing.Size(90, 30);
			this.MinimumSize = new System.Drawing.Size(30, 30);
			this.Name = "WindowButtons";
			this.Size = new System.Drawing.Size(90, 30);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button minBut;
		private System.Windows.Forms.Button maxBut;
		private System.Windows.Forms.Button closeBut;
		private System.Windows.Forms.FlowLayoutPanel panel;
		private System.Windows.Forms.ImageList butImages;
	}
}
