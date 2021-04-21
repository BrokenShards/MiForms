////////////////////////////////////////////////////////////////////////////////
// EnumBox.Designer.cs 
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
	partial class EnumBox
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
			this.box = new MiForms.DropDownBox();
			this.SuspendLayout();
			// 
			// label
			// 
			this.label.Location = new System.Drawing.Point(0, 0);
			this.label.Margin = new System.Windows.Forms.Padding(0);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(117, 23);
			this.label.TabIndex = 0;
			this.label.Text = "Enum";
			this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// box
			// 
			this.box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.box.DropDownHeight = ((uint)(106u));
			this.box.DropDownWidth = ((uint)(300u));
			this.box.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.box.IntegralHeight = true;
			this.box.ItemHeight = ((uint)(15u));
			this.box.Location = new System.Drawing.Point(117, 0);
			this.box.Margin = new System.Windows.Forms.Padding(0);
			this.box.MaxDropDownItems = ((uint)(9u));
			this.box.MaximumSize = new System.Drawing.Size(1000000, 23);
			this.box.MaxLength = ((uint)(0u));
			this.box.MinimumSize = new System.Drawing.Size(50, 23);
			this.box.Name = "box";
			this.box.SelectedIndex = -1;
			this.box.SelectedItem = null;
			this.box.SelectedText = "";
			this.box.Size = new System.Drawing.Size(323, 23);
			this.box.Sorted = false;
			this.box.TabIndex = 0;
			// 
			// EnumBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.Controls.Add(this.box);
			this.Controls.Add(this.label);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.Name = "EnumBox";
			this.Size = new System.Drawing.Size(440, 23);
			this.Load += new System.EventHandler(this.OnLoadControl);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label;
		private DropDownBox box;
	}
}
