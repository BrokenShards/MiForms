////////////////////////////////////////////////////////////////////////////////
// FileSaver.Designer.cs
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
	partial class FileSaver
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileSaver));
			this.label = new System.Windows.Forms.Label();
			this.boxPanel = new System.Windows.Forms.Panel();
			this.pathBox = new System.Windows.Forms.TextBox();
			this.butPanel = new System.Windows.Forms.Panel();
			this.pathBut = new System.Windows.Forms.Button();
			this.butImages = new System.Windows.Forms.ImageList(this.components);
			this.saveDialog = new System.Windows.Forms.SaveFileDialog();
			this.boxPanel.SuspendLayout();
			this.butPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// label
			// 
			this.label.Location = new System.Drawing.Point(0, 0);
			this.label.Margin = new System.Windows.Forms.Padding(0);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(117, 23);
			this.label.TabIndex = 0;
			this.label.Text = "File";
			this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// boxPanel
			// 
			this.boxPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.boxPanel.Controls.Add(this.pathBox);
			this.boxPanel.Location = new System.Drawing.Point(120, 1);
			this.boxPanel.Margin = new System.Windows.Forms.Padding(0);
			this.boxPanel.Name = "boxPanel";
			this.boxPanel.Size = new System.Drawing.Size(278, 21);
			this.boxPanel.TabIndex = 25;
			// 
			// pathBox
			// 
			this.pathBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pathBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.pathBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pathBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.pathBox.Location = new System.Drawing.Point(-1, -1);
			this.pathBox.Margin = new System.Windows.Forms.Padding(0);
			this.pathBox.Name = "pathBox";
			this.pathBox.Size = new System.Drawing.Size(280, 23);
			this.pathBox.TabIndex = 0;
			// 
			// butPanel
			// 
			this.butPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.butPanel.Controls.Add(this.pathBut);
			this.butPanel.Location = new System.Drawing.Point(396, 0);
			this.butPanel.Name = "butPanel";
			this.butPanel.Size = new System.Drawing.Size(23, 23);
			this.butPanel.TabIndex = 26;
			// 
			// pathBut
			// 
			this.pathBut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pathBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pathBut.BackgroundImage")));
			this.pathBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pathBut.FlatAppearance.BorderSize = 0;
			this.pathBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.pathBut.Location = new System.Drawing.Point(2, 2);
			this.pathBut.Margin = new System.Windows.Forms.Padding(0);
			this.pathBut.Name = "pathBut";
			this.pathBut.Size = new System.Drawing.Size(19, 19);
			this.pathBut.TabIndex = 1;
			this.pathBut.UseVisualStyleBackColor = true;
			this.pathBut.Click += new System.EventHandler(this.PathButtonClicked);
			// 
			// butImages
			// 
			this.butImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("butImages.ImageStream")));
			this.butImages.TransparentColor = System.Drawing.Color.Transparent;
			this.butImages.Images.SetKeyName(0, "DarkOpen.png");
			this.butImages.Images.SetKeyName(1, "LightOpen.png");
			// 
			// saveDialog
			// 
			this.saveDialog.CreatePrompt = true;
			this.saveDialog.DefaultExt = "lnk";
			this.saveDialog.Filter = "Popcon Shortcut|.lnk";
			// 
			// FileSaver
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.Controls.Add(this.butPanel);
			this.Controls.Add(this.boxPanel);
			this.Controls.Add(this.label);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.Name = "FileSaver";
			this.Size = new System.Drawing.Size(420, 23);
			this.Load += new System.EventHandler(this.OnLoadControl);
			this.boxPanel.ResumeLayout(false);
			this.boxPanel.PerformLayout();
			this.butPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Panel boxPanel;
		private System.Windows.Forms.TextBox pathBox;
		private System.Windows.Forms.Panel butPanel;
		private System.Windows.Forms.Button pathBut;
		private System.Windows.Forms.ImageList butImages;
		private System.Windows.Forms.SaveFileDialog saveDialog;
	}
}
