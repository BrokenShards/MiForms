////////////////////////////////////////////////////////////////////////////////
// DropDownBox.Designer.cs 
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
	partial class DropDownBox
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DropDownBox));
			this.box = new System.Windows.Forms.ComboBox();
			this.boxPanel = new System.Windows.Forms.Panel();
			this.but = new System.Windows.Forms.Button();
			this.butPanel = new System.Windows.Forms.Panel();
			this.butImages = new System.Windows.Forms.ImageList(this.components);
			this.boxPanel.SuspendLayout();
			this.butPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// box
			// 
			this.box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.box.FormattingEnabled = true;
			this.box.Location = new System.Drawing.Point(-1, -1);
			this.box.Margin = new System.Windows.Forms.Padding(0);
			this.box.MaxDropDownItems = 9;
			this.box.Name = "box";
			this.box.Size = new System.Drawing.Size(205, 23);
			this.box.TabIndex = 0;
			// 
			// boxPanel
			// 
			this.boxPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.boxPanel.Controls.Add(this.box);
			this.boxPanel.Location = new System.Drawing.Point(1, 1);
			this.boxPanel.Margin = new System.Windows.Forms.Padding(0);
			this.boxPanel.Name = "boxPanel";
			this.boxPanel.Size = new System.Drawing.Size(180, 21);
			this.boxPanel.TabIndex = 2;
			// 
			// but
			// 
			this.but.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.but.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but.BackgroundImage")));
			this.but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.but.FlatAppearance.BorderSize = 0;
			this.but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.but.Location = new System.Drawing.Point(3, 3);
			this.but.Margin = new System.Windows.Forms.Padding(0);
			this.but.Name = "but";
			this.but.Size = new System.Drawing.Size(15, 15);
			this.but.TabIndex = 0;
			this.but.TabStop = false;
			this.but.UseVisualStyleBackColor = true;
			this.but.Click += new System.EventHandler(this.ButtonClicked);
			// 
			// butPanel
			// 
			this.butPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.butPanel.Controls.Add(this.but);
			this.butPanel.Location = new System.Drawing.Point(178, 1);
			this.butPanel.Margin = new System.Windows.Forms.Padding(0);
			this.butPanel.Name = "butPanel";
			this.butPanel.Size = new System.Drawing.Size(21, 21);
			this.butPanel.TabIndex = 38;
			// 
			// butImages
			// 
			this.butImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("butImages.ImageStream")));
			this.butImages.TransparentColor = System.Drawing.Color.Transparent;
			this.butImages.Images.SetKeyName(0, "DarkDown.png");
			this.butImages.Images.SetKeyName(1, "DarkUp.png");
			this.butImages.Images.SetKeyName(2, "LightDown.png");
			this.butImages.Images.SetKeyName(3, "LightUp.png");
			// 
			// DropDownBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.Controls.Add(this.butPanel);
			this.Controls.Add(this.boxPanel);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.Margin = new System.Windows.Forms.Padding(0);
			this.MaximumSize = new System.Drawing.Size(1000000, 23);
			this.MinimumSize = new System.Drawing.Size(50, 23);
			this.Name = "DropDownBox";
			this.Size = new System.Drawing.Size(200, 23);
			this.boxPanel.ResumeLayout(false);
			this.butPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox box;
		private System.Windows.Forms.Panel boxPanel;
		private System.Windows.Forms.Button but;
		private System.Windows.Forms.Panel butPanel;
		private System.Windows.Forms.ImageList butImages;
	}
}
