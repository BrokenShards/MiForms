////////////////////////////////////////////////////////////////////////////////
// MiControl.cs 
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
using System.Windows.Forms;

namespace MiForms
{
	/// <summary>
	///   Base class for MiForms controls.
	/// </summary>
    public class MiControl : UserControl, IComponent
    {
		/// <summary>
		///   Constructor.
		/// </summary>
        public MiControl()
        {
			Theme.ThemeChanged += OnThemeChanged;
		}

		/// <summary>
		///   Called when the global theme has changed. Update the control to use the current color
		///   scheme.
		/// </summary>
		/// <param name="sender">
		///   Event sender (always null).
		/// </param>
		/// <param name="e">
		///   Event args (always empty)
		/// </param>
		protected virtual void OnThemeChanged( object sender, EventArgs e )
		{ }

		/// <summary>
		///   Called when the control is disposed of.
		/// </summary>
		/// <param name="disposing">
		///   True to release both managed and unmanaged resources; false to release only unmanaged
		///   resources.
		/// </param>
		protected override void Dispose( bool disposing )
		{
			Theme.ThemeChanged -= OnThemeChanged;

			base.Dispose( disposing );
		}
	}
}
