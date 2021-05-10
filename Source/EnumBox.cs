////////////////////////////////////////////////////////////////////////////////
// EnumBox.cs 
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

using Size = System.Drawing.Size;

namespace MiForms
{
	/// <summary>
	///   A box that lets the user select an enum value.
	/// </summary>
	[ToolboxItem( true )] [DesignTimeVisible( true )]
	public partial class EnumBox : MiControl, IComponent
	{
		/// <summary>
		///   Constructor.
		/// </summary>
		public EnumBox()
		:	base()
		{
			InitializeComponent();
			OnThemeChanged( null, EventArgs.Empty );

			Resize += OnResize;
			box.SelectedIndexChanged += SelectionIndexChanged;
		}
		/// <summary>
		///   Constructor setting enum type.
		/// </summary>
		/// <param name="etype">
		///   The enum type.
		/// </param>
		public EnumBox( Type etype )
		:	this()
		{
			EnumType = etype;
		}

		/// <summary>
		///   If the control has a label.
		/// </summary>
		public bool HasLabel
		{
			get { return label.Visible; }
			set
			{
				if( value != HasLabel )
				{
					label.Visible = value;
					OnResize( this, EventArgs.Empty );
				}
			}
		}
		/// <summary>
		///   The length in pixels of the label.
		/// </summary>
		public uint LabelWidth
		{
			get { return (uint)m_labLen; }
			set
			{
				m_labLen = (int)value;
				OnResize( this, EventArgs.Empty );
			}
		}
		/// <summary>
		///   The length in pixels of the label.
		/// </summary>
		public uint BoxOffset
		{
			get { return (uint)m_boxOff; }
			set
			{
				m_boxOff = (int)value;
				OnResize( this, EventArgs.Empty );
			}
		}
		/// <summary>
		///   Editor label.
		/// </summary>
		public string Label
		{
			get { return m_label; }
			set
			{
				if( string.IsNullOrWhiteSpace( value ) )
					m_label = string.Empty;
				else
					m_label = value;

				if( label is not null )
					label.Text = value;
			}
		}

		/// <summary>
		///   The enum type.
		/// </summary>
		public Type EnumType
		{
			get { return m_type; }
			set
			{
				if( value is not null && !value.IsEnum )
					MessageBox.Show( this, "Non enum type given to EnumBox.", "Invalid Type" );

				m_type = value;
				box.Items.Clear();

				for( int i = 0; m_type is not null && i < Enum.GetNames( m_type ).Length; i++ )
					box.Items.Add( Enum.GetName( m_type, i ) );
			}
		}

		/// <summary>
		///   Selected index.
		/// </summary>
		public int SelectedIndex
		{
			get { return box.SelectedIndex; }
			set { box.SelectedIndex = value; }
		}
		/// <summary>
		///   Selected index.
		/// </summary>
		public string SelectedText
		{
			get { return box.SelectedText; }
			set { box.SelectedText = value; }
		}
		/// <summary>
		///   The control text.
		/// </summary>
		public string BoxText
		{
			get { return box.Text; }
			set { box.Text = value; }
		}

		/// <summary>
		///   Items in the enum box.
		/// </summary>
		public ComboBox.ObjectCollection Items
		{
			get { return box.Items; }
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

			label.BackColor = BackColor;
			label.ForeColor = ForeColor;
			box.BackColor   = BackColor;
			box.ForeColor   = ForeColor;
		}

		private void OnLoadControl( object sender, EventArgs e )
		{
			label.Text = m_label;
		}
		private void OnResize( object sender, EventArgs e )
		{
			if( HasLabel )
			{
				MinimumSize = new Size( m_labLen + 50, MinimumSize.Height );

				label.Left = 0;
				label.Size = new Size( m_labLen, Height );

				box.Left = label.Width + m_boxOff;
			}
			else
			{
				MinimumSize = new Size( 50, MinimumSize.Height );

				label.Left = Right;
				box.Left   = m_boxOff;
			}

			box.Width = Width - box.Left;
			box.DropDownWidth = (uint)( box.Width - box.Height );
		}

		private void SelectionIndexChanged( object sender, EventArgs e )
		{
			EventHandler handler;

			lock( m_changedLock )
			{
				handler = m_changed;
			}

			handler?.Invoke( this, EventArgs.Empty );
		}

		/// <summary>
		///   Occurs when the value is changed.
		/// </summary>
		public event EventHandler ValueChanged
		{
			add
			{
				lock( m_changedLock )
				{
					m_changed += value;
				}
			}
			remove
			{
				lock( m_changedLock )
				{
					m_changed -= value;
				}
			}
		}

		private string m_label;
		private Type   m_type;
		private int    m_labLen,
		               m_boxOff;

		private EventHandler m_changed;
		private readonly object m_changedLock = new();
	}
}
