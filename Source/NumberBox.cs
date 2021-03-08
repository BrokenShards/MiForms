////////////////////////////////////////////////////////////////////////////////
// NumberBox.cs 
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
	///   A box that displays a number value with buttons to increment and decrement.
	/// </summary>
	[ToolboxItem( true )] [DesignTimeVisible( true )]
	public partial class NumberBox : MiControl, IComponent
	{
		/// <summary>
		///   Constructor.
		/// </summary>
		public NumberBox()
		:	base()
		{
			InitializeComponent();
			OnThemeChanged( null, EventArgs.Empty );
		}

		/// <summary>
		///   Occurs when the value is changed.
		/// </summary>
		public event EventHandler ValueChanged
		{
			add
			{
				numBox.ValueChanged += value;
			}
			remove
			{
				numBox.ValueChanged -= value;
			}
		}

		/// <summary>
		///   The internal numeric up-down control.
		/// </summary>
		public NumericUpDown Box
		{
			get { return numBox; }
		}
		/// <summary>
		///   Text alignment.
		/// </summary>
		public HorizontalAlignment TextAlign
		{
			get { return numBox.TextAlign; }
			set { numBox.TextAlign = value; }
		}
		/// <summary>
		///   The number value.
		/// </summary>
		public decimal Value
		{
			get { return numBox.Value; }
			set { numBox.Value = value; }
		}
		/// <summary>
		///   The number of decimal places to display
		/// </summary>
		public uint DecimalPlaces
		{
			get { return (uint)numBox.DecimalPlaces; }
			set { numBox.DecimalPlaces = (int)value; }
		}
		/// <summary>
		///   How much the buttons increase or decrease the value.
		/// </summary>
		public decimal Increment
		{
			get { return numBox.Increment; }
			set { numBox.Increment = value; }
		}
		/// <summary>
		///   The minimum value.
		/// </summary>
		public decimal Minimum
		{
			get { return numBox.Minimum; }
			set { numBox.Minimum = value; }
		}
		/// <summary>
		///   The maximum value.
		/// </summary>
		public decimal Maximum
		{
			get { return numBox.Maximum; }
			set { numBox.Maximum = value; }
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

			numBox.BackColor  = Theme.FieldColor;
			numBox.ForeColor  = ForeColor;
			upBut.BackColor   = BackColor;
			upBut.ForeColor   = ForeColor;
			downBut.BackColor = BackColor;
			downBut.ForeColor = ForeColor;

			boxPanel.BackColor = Theme.FieldColor;
			boxPanel.ForeColor = ForeColor;
			butPanel.BackColor = BackColor;
			butPanel.ForeColor = ForeColor;

			upBut.BackgroundImage   = Theme.UseDarkTheme ? butImages.Images[ 0 ] : butImages.Images[ 2 ];
			downBut.BackgroundImage = Theme.UseDarkTheme ? butImages.Images[ 1 ] : butImages.Images[ 3 ];
		}

		private void UpClicked( object sender, EventArgs e )
		{
			numBox.UpButton();
		}
		private void DownClicked( object sender, EventArgs e )
		{
			numBox.DownButton();
		}
	}
}
