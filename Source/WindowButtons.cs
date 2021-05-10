////////////////////////////////////////////////////////////////////////////////
// WindowButtons.cs 
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

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MiForms
{
	/// <summary>
	///   A control that provides window buttons (minimize, maximize and/or close) that affect the
	///   parent form.
	/// </summary>
	[ToolboxItem( true )] [DesignTimeVisible( true )]
	public partial class WindowButtons : MiControl, IComponent
	{
		/// <summary>
		///   Constructor.
		/// </summary>
		public WindowButtons()
		{
			InitializeComponent();
			OnThemeChanged( null, EventArgs.Empty );
		}

		/// <summary>
		///   Show minimize button.
		/// </summary>
		public bool MinimizeButton
		{
			get { return minBut.Visible; }
			set
			{
				minBut.Enabled = value;
				minBut.Visible = value;
			}
		}
		/// <summary>
		///   Show maximize button.
		/// </summary>
		public bool MaximizeButton
		{
			get { return maxBut.Visible; }
			set
			{
				maxBut.Enabled = value;
				maxBut.Visible = value;

				panel.Controls.SetChildIndex( maxBut, value ? ( CloseButton ? 1 : 0 ) : 2 );
			}
		}
		/// <summary>
		///   Show close button.
		/// </summary>
		public bool CloseButton
		{
			get { return closeBut.Visible; }
			set
			{
				closeBut.Enabled = value;
				closeBut.Visible = value;

				panel.Controls.SetChildIndex( closeBut, value ? 0 : 2 );
			}
		}

		/// <summary>
		///   Update the control to use the current color scheme.
		/// </summary>
		/// <param name="sender">
		///   Event sender (always null).
		/// </param>
		/// <param name="e">
		///   Event args (always empty)
		/// </param>
		protected override void OnThemeChanged( object sender, EventArgs e )
		{
			BackColor = Theme.BackColor;
			ForeColor = Theme.ForeColor;

			panel.BackColor    = BackColor;
			panel.ForeColor    = ForeColor;
			minBut.BackColor   = BackColor;
			minBut.ForeColor   = ForeColor;
			maxBut.BackColor   = BackColor;
			maxBut.ForeColor   = ForeColor;
			closeBut.BackColor = BackColor;
			closeBut.ForeColor = ForeColor;

			minBut.BackgroundImage   = Theme.UseDarkTheme ? butImages.Images[ 0 ] : butImages.Images[ 3 ];
			maxBut.BackgroundImage   = Theme.UseDarkTheme ? butImages.Images[ 1 ] : butImages.Images[ 4 ];
			closeBut.BackgroundImage = Theme.UseDarkTheme ? butImages.Images[ 2 ] : butImages.Images[ 5 ];
		}

		private void MinimizedClicked( object sender, EventArgs e )
		{
			if( ParentForm is null )
				return;

			ParentForm.WindowState = FormWindowState.Minimized;
		}
		private void MaximizedClicked( object sender, EventArgs e )
		{
			if( ParentForm is null )
				return;

			ParentForm.WindowState = ParentForm.WindowState is FormWindowState.Maximized ?
				FormWindowState.Normal : FormWindowState.Maximized;
		}
		private void CloseClicked( object sender, EventArgs e )
		{
			ParentForm?.Close();
		}
	}
}
