////////////////////////////////////////////////////////////////////////////////
// Vec2iEditor.Designer.cs 
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
	partial class Vec2iEditor
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
			this.xLab = new System.Windows.Forms.Label();
			this.yLab = new System.Windows.Forms.Label();
			this.label = new System.Windows.Forms.Label();
			this.xBox = new MiForms.NumberBox();
			this.yBox = new MiForms.NumberBox();
			this.SuspendLayout();
			// 
			// xLab
			// 
			this.xLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.xLab.Location = new System.Drawing.Point(120, 0);
			this.xLab.Margin = new System.Windows.Forms.Padding(0);
			this.xLab.Name = "xLab";
			this.xLab.Size = new System.Drawing.Size(72, 23);
			this.xLab.TabIndex = 1;
			this.xLab.Text = "X";
			this.xLab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// yLab
			// 
			this.yLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.yLab.Location = new System.Drawing.Point(278, 0);
			this.yLab.Margin = new System.Windows.Forms.Padding(0);
			this.yLab.Name = "yLab";
			this.yLab.Size = new System.Drawing.Size(74, 23);
			this.yLab.TabIndex = 4;
			this.yLab.Text = "Y";
			this.yLab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label
			// 
			this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.label.Location = new System.Drawing.Point(0, 0);
			this.label.Margin = new System.Windows.Forms.Padding(0);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(120, 23);
			this.label.TabIndex = 0;
			this.label.Text = "Vector2i";
			this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// xBox
			// 
			this.xBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.xBox.DecimalPlaces = ((uint)(0u));
			this.xBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.xBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.xBox.Location = new System.Drawing.Point(192, 0);
			this.xBox.Margin = new System.Windows.Forms.Padding(0);
			this.xBox.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.xBox.MaximumSize = new System.Drawing.Size(116667, 23);
			this.xBox.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
			this.xBox.MinimumSize = new System.Drawing.Size(23, 23);
			this.xBox.Name = "xBox";
			this.xBox.Size = new System.Drawing.Size(86, 23);
			this.xBox.TabIndex = 0;
			this.xBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.xBox.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// yBox
			// 
			this.yBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.yBox.DecimalPlaces = ((uint)(0u));
			this.yBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.yBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.yBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.yBox.Location = new System.Drawing.Point(354, 0);
			this.yBox.Margin = new System.Windows.Forms.Padding(0);
			this.yBox.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.yBox.MaximumSize = new System.Drawing.Size(116667, 23);
			this.yBox.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
			this.yBox.MinimumSize = new System.Drawing.Size(23, 23);
			this.yBox.Name = "yBox";
			this.yBox.Size = new System.Drawing.Size(86, 23);
			this.yBox.TabIndex = 1;
			this.yBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.yBox.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// Vec2iEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.Controls.Add(this.yBox);
			this.Controls.Add(this.xBox);
			this.Controls.Add(this.yLab);
			this.Controls.Add(this.xLab);
			this.Controls.Add(this.label);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.MaximumSize = new System.Drawing.Size(10000, 23);
			this.MinimumSize = new System.Drawing.Size(50, 23);
			this.Name = "Vec2iEditor";
			this.Size = new System.Drawing.Size(440, 23);
			this.Load += new System.EventHandler(this.OnLoadControl);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Label xLab;
		private System.Windows.Forms.Label yLab;
		private NumberBox xBox;
		private NumberBox yBox;
	}
}
