////////////////////////////////////////////////////////////////////////////////
// IntRectEditor.Designer.cs 
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
	partial class IntRectEditor
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
			this.label = new System.Windows.Forms.Label();
			this.sizeVec = new MiForms.Vec2iEditor();
			this.posVec = new MiForms.Vec2iEditor();
			this.SuspendLayout();
			// 
			// label
			// 
			this.label.Location = new System.Drawing.Point(0, 0);
			this.label.Margin = new System.Windows.Forms.Padding(0);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(120, 48);
			this.label.TabIndex = 2;
			this.label.Text = "IntRect";
			this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// sizeVec
			// 
			this.sizeVec.BoxLabelWidth = ((uint)(72u));
			this.sizeVec.BoxWidth = ((uint)(86u));
			this.sizeVec.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.sizeVec.HasLabel = false;
			this.sizeVec.Increment = 1;
			this.sizeVec.Label = "Vector2i";
			this.sizeVec.LabelAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.sizeVec.LabelWidth = ((uint)(120u));
			this.sizeVec.Location = new System.Drawing.Point(120, 25);
			this.sizeVec.Margin = new System.Windows.Forms.Padding(0);
			this.sizeVec.MaximumSize = new System.Drawing.Size(10000, 23);
			this.sizeVec.MaxXValue = 2147483647;
			this.sizeVec.MaxYValue = 2147483647;
			this.sizeVec.MinimumSize = new System.Drawing.Size(316, 23);
			this.sizeVec.MinXValue = -2147483648;
			this.sizeVec.MinYValue = -2147483648;
			this.sizeVec.Name = "sizeVec";
			this.sizeVec.Size = new System.Drawing.Size(316, 23);
			this.sizeVec.TabIndex = 1;
			this.sizeVec.XLabel = "W";
			this.sizeVec.XValue = 0;
			this.sizeVec.YLabel = "H";
			this.sizeVec.YValue = 0;
			// 
			// posVec
			// 
			this.posVec.BoxLabelWidth = ((uint)(72u));
			this.posVec.BoxWidth = ((uint)(86u));
			this.posVec.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.posVec.HasLabel = false;
			this.posVec.Increment = 1;
			this.posVec.Label = "Vector2i";
			this.posVec.LabelAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.posVec.LabelWidth = ((uint)(120u));
			this.posVec.Location = new System.Drawing.Point(120, 0);
			this.posVec.Margin = new System.Windows.Forms.Padding(0);
			this.posVec.MaximumSize = new System.Drawing.Size(10000, 23);
			this.posVec.MaxXValue = 2147483647;
			this.posVec.MaxYValue = 2147483647;
			this.posVec.MinimumSize = new System.Drawing.Size(316, 23);
			this.posVec.MinXValue = -2147483648;
			this.posVec.MinYValue = -2147483648;
			this.posVec.Name = "posVec";
			this.posVec.Size = new System.Drawing.Size(316, 23);
			this.posVec.TabIndex = 0;
			this.posVec.XLabel = "X";
			this.posVec.XValue = 0;
			this.posVec.YLabel = "Y";
			this.posVec.YValue = 0;
			// 
			// IntRectEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.Controls.Add(this.sizeVec);
			this.Controls.Add(this.label);
			this.Controls.Add(this.posVec);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.Margin = new System.Windows.Forms.Padding(0);
			this.MaximumSize = new System.Drawing.Size(10000, 48);
			this.MinimumSize = new System.Drawing.Size(50, 48);
			this.Name = "IntRectEditor";
			this.Size = new System.Drawing.Size(440, 48);
			this.Load += new System.EventHandler(this.OnControlLoad);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label;
		private Vec2iEditor sizeVec;
		private Vec2iEditor posVec;
	}
}
