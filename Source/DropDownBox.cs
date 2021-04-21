////////////////////////////////////////////////////////////////////////////////
// DropDownBox.cs 
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
	///   A drop down box containing a list of possible options to select.
	/// </summary>
	[ToolboxItem( true )] [DesignTimeVisible( true )]
	public partial class DropDownBox : MiControl, IComponent
	{
		/// <summary>
		///   Constructor.
		/// </summary>
		public DropDownBox()
		:	base()
		{
			InitializeComponent();
			OnThemeChanged( null, EventArgs.Empty );
		}

		/// <summary>
		///   Occurs when the selected index changes.
		/// </summary>
		public event EventHandler SelectedIndexChanged
		{
			add
			{
				box.SelectedIndexChanged += value;
			}
			remove
			{
				box.SelectedIndexChanged -= value;
			}
		}
		/// <summary>
		///   Occurs when the selected value changes.
		/// </summary>
		public event EventHandler SelectedValueChanged
		{
			add
			{
				box.SelectedValueChanged += value;
			}
			remove
			{
				box.SelectedValueChanged -= value;
			}
		}

		/// <summary>
		///   The text in the box.
		/// </summary>
		public override string Text
		{
			get { return box.Text; }
			set { box.Text = value; }
		}
		/// <summary>
		///   Collection of items in the drop down list.
		/// </summary>
		public ComboBox.ObjectCollection Items
		{
			get { return box.Items; }
		}

		/// <summary>
		///   The currently selected index (-1 if nothing is selected).
		/// </summary>
		public int SelectedIndex
		{
			get { return box.SelectedIndex; }
			set { try { box.SelectedIndex = value; } catch { } }
		}
		/// <summary>
		///   The currently selected item (null if nothing is selected).
		/// </summary>
		public object SelectedItem
		{
			get { return box.SelectedItem; }
			set { box.SelectedItem = value; }
		}
		/// <summary>
		///   The currently selected text.
		/// </summary>
		public string SelectedText
		{
			get { return box.SelectedText; }
			set { box.SelectedText = value; }
		}

		/// <summary>
		///   Should the control resize to avoid showing partial items?
		/// </summary>
		public bool IntegralHeight
		{
			get { return box.IntegralHeight; }
			set { box.IntegralHeight = value; }
		}
		/// <summary>
		///   Should the drop down list be sorted?
		/// </summary>
		public bool Sorted
		{
			get { return box.Sorted; }
			set { try { box.Sorted = value; } catch { } }
		}
		/// <summary>
		///   How far the box drops down in pixels.
		/// </summary>
		public uint DropDownHeight
		{
			get { return (uint)box.DropDownHeight; }
			set { try { box.DropDownHeight = (int)value; } catch { } }
		}
		/// <summary>
		///   How wide the drop down box is in pixels.
		/// </summary>
		public uint DropDownWidth
		{
			get { return (uint)box.DropDownWidth; }
			set { try { box.DropDownWidth = (int)value; } catch { } }
		}

		/// <summary>
		///   The height in pixels of each item in the drop down list.
		/// </summary>
		public uint ItemHeight
		{
			get { return (uint)box.ItemHeight; }
			set { try { box.ItemHeight = (int)value; } catch { } }
		}
		/// <summary>
		///   Maximum drop down items.
		/// </summary>
		public uint MaxDropDownItems
		{
			get { return (uint)box.MaxDropDownItems; }
			set { try { box.MaxDropDownItems = (int)value; } catch { } }
		}
		/// <summary>
		///   Maximum length of text.
		/// </summary>
		public uint MaxLength
		{
			get { return (uint)box.MaxLength; }
			set { box.MaxLength = (int)value; }
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

			box.BackColor      = Theme.FieldColor;
			box.ForeColor      = ForeColor;
			but.BackColor      = BackColor;
			but.ForeColor      = ForeColor;
			boxPanel.BackColor = BackColor;
			boxPanel.ForeColor = ForeColor;
			butPanel.BackColor = BackColor;
			butPanel.ForeColor = ForeColor;

			but.BackgroundImage = box.DroppedDown ? butImages.Images[ Theme.UseDarkTheme ? 1 : 3 ] :
			                                        butImages.Images[ Theme.UseDarkTheme ? 0 : 2 ];
		}

		private void ButtonClicked( object sender, EventArgs e )
		{
			box.DroppedDown = !box.DroppedDown;
			box.BackgroundImage = box.DroppedDown ? ( Theme.UseDarkTheme ? butImages.Images[ 1 ] : butImages.Images[ 3 ] ) :
													( Theme.UseDarkTheme ? butImages.Images[ 0 ] : butImages.Images[ 2 ] );
		}
	}
}
