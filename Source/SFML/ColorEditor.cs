////////////////////////////////////////////////////////////////////////////////
// ColorEditor.cs 
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

using SFML.Graphics;

using Point = System.Drawing.Point;
using Size  = System.Drawing.Size;

namespace MiForms
{
	/// <summary>
	///   Control for editing Vector2f.
	/// </summary>
	[ToolboxItem( true )] [DesignTimeVisible( true )]
	public partial class ColorEditor : MiControl, IComponent
	{
		/// <summary>
		///   Constructor.
		/// </summary>
		public ColorEditor()
		:	base()
		{
			InitializeComponent();
			Resize += OnResize;
			rBox.ValueChanged += RedChanged;
			gBox.ValueChanged += GreenChanged;
			bBox.ValueChanged += BlueChanged;
			aBox.ValueChanged += AlphaChanged;

			OnThemeChanged( null, EventArgs.Empty );

			m_label = string.Empty;
			Value   = default;
		}
		/// <summary>
		///   Constructor setting the value.
		/// </summary>
		/// <param name="val">
		///   Value.
		/// </param>
		public ColorEditor( Color val )
		:	this()
		{
			Value = val;
		}
		/// <summary>
		///   Constructor setting label along with value.
		/// </summary>
		/// <param name="label">
		///   Label text.
		/// </param>
		/// <param name="val">
		///   Value.
		/// </param>
		public ColorEditor( string label, Color val = default )
		:	this( val )
		{
			Label = label;
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
		///   If the control has a label.
		/// </summary>
		public bool HasPickerButton
		{
			get
			{
				return m_hasPicker;
			}
			set
			{
				m_hasPicker = value;
				colBut.Visible = m_hasPicker;
				colBut.Enabled = m_hasPicker;
				OnResize( this, EventArgs.Empty );
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

				if( label != null )
					label.Text = value; 
			}
		}

		/// <summary>
		///   X value.
		/// </summary>
		public byte RValue
		{
			get { return m_value.R; }
			set 
			{
				m_value.R  = value;
				rBox.Value = m_value.R;
				OnValueChanged();
			}
		}
		/// <summary>
		///   Y value.
		/// </summary>
		public byte GValue
		{
			get { return m_value.G; }
			set
			{
				m_value.G  = value;
				gBox.Value = m_value.G;
				OnValueChanged();
			}
		}
		/// <summary>
		///   X value.
		/// </summary>
		public byte BValue
		{
			get { return m_value.B; }
			set
			{
				m_value.B = value;
				bBox.Value = m_value.B;
				OnValueChanged();
			}
		}
		/// <summary>
		///   Y value.
		/// </summary>
		public byte AValue
		{
			get { return m_value.A; }
			set
			{
				m_value.A = value;
				aBox.Value = m_value.A;
				OnValueChanged();
			}
		}

		/// <summary>
		///   The width of the number boxes.
		/// </summary>
		public uint BoxWidth
		{
			get { return (uint)m_boxLen; }
			set
			{
				m_boxLen = (int)value;
				OnResize( this, EventArgs.Empty );
			}
		}
		/// <summary>
		///   The width of the number boxes.
		/// </summary>
		public uint ColorLabelWidth
		{
			get { return (uint)m_boxLabLen; }
			set
			{
				m_boxLabLen = (int)value;
				OnResize( this, EventArgs.Empty );
			}
		}

		/// <summary>
		///   Current value.
		/// </summary>
		public Color Value
		{
			get { return m_value; }
			set
			{
				m_value = value;
				rBox.Value = m_value.R;
				gBox.Value = m_value.G;
				bBox.Value = m_value.B;
				aBox.Value = m_value.A;
				OnValueChanged();
			}
		}

		/// <summary>
		///   Occurs when the value is changed.
		/// </summary>
		public event EventHandler ValueChanged
		{
			add
			{
				lock( m_valueLock )
				{
					m_valueChanged += value;
				}
			}
			remove
			{
				lock( m_valueLock )
				{
					m_valueChanged -= value;
				}
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

			label.BackColor  = BackColor;
			label.ForeColor  = ForeColor;
			rLab.BackColor   = BackColor;
			rLab.ForeColor   = ForeColor;
			gLab.BackColor   = BackColor;
			gLab.ForeColor   = ForeColor;
			bLab.BackColor   = BackColor;
			bLab.ForeColor   = ForeColor;
			aLab.BackColor   = BackColor;
			aLab.ForeColor   = ForeColor;
			colBut.BackColor = BackColor;
			colBut.ForeColor = ForeColor;

			colBut.BackgroundImage = Theme.UseDarkTheme ? colImages.Images[ 0 ] : colImages.Images[ 1 ];
		}

		private void OnLoadControl( object sender, EventArgs e )
		{
			label.Text = m_label;
			Value = Value;
		}
		private void OnResize( object sender, EventArgs e )
		{
			int butwidth = HasPickerButton ? colBut.Width : 0;

			if( HasLabel )
			{
				MinimumSize = new Size( m_labLen + ( ( m_boxLabLen + m_boxLen ) * 4 ) + butwidth + 2, MinimumSize.Height );

				label.Left  = 0;
				label.Width = m_labLen;

				int rem = Width - m_labLen - butwidth;

				rLab.Location = new Point( m_labLen, 0 );
				rLab.Size     = new Size( m_boxLabLen, Height );
				rBox.Location = new Point( rLab.Right, 0 );
				rBox.Size     = new Size( m_boxLen, Height );

				gLab.Location = new Point( m_labLen + ( rem / 4 ), 0 );
				gLab.Size     = new Size( m_boxLabLen, Height );
				gBox.Location = new Point( gLab.Right, 0 );
				gBox.Size     = new Size( m_boxLen, Height );

				bLab.Location = new Point( m_labLen + ( rem / 4 * 2 ), 0 );
				bLab.Size     = new Size( m_boxLabLen, Height );
				bBox.Location = new Point( bLab.Right, 0 );
				bBox.Size     = new Size( m_boxLen, Height );

				aLab.Location = new Point( m_labLen + ( rem / 4 * 3 ), 0 );
				aLab.Size     = new Size( m_boxLabLen, Height );
				aBox.Location = new Point( aLab.Right, 0 );
				aBox.Size     = new Size( m_boxLen, Height );
			}
			else
			{
				MinimumSize = new Size( ( ( m_boxLabLen + m_boxLen ) * 4 ) + butwidth + 2, MinimumSize.Height );

				label.Left = Right;

				int rem = Width - butwidth;

				rLab.Location = new Point( 0, 0 );
				rLab.Size     = new Size( m_boxLabLen, Height );
				rBox.Location = new Point( rLab.Right, 0 );
				rBox.Size     = new Size( m_boxLen, Height );

				gLab.Location = new Point( rem / 4, 0 );
				gLab.Size     = new Size( m_boxLabLen, Height );
				gBox.Location = new Point( gLab.Right, 0 );
				gBox.Size     = new Size( m_boxLen, Height );

				bLab.Location = new Point( rem / 4 * 2, 0 );
				bLab.Size     = new Size( m_boxLabLen, Height );
				bBox.Location = new Point( bLab.Right, 0 );
				bBox.Size     = new Size( m_boxLen, Height );

				aLab.Location = new Point( rem / 4 * 3, 0 );
				aLab.Size     = new Size( m_boxLabLen, Height );
				aBox.Location = new Point( aLab.Right, 0 );
				aBox.Size     = new Size( m_boxLen, Height );
			}

			colBut.Left = Right - colBut.Width - 2;
		}

		private void OnValueChanged()
		{
			EventHandler handler;

			lock( m_valueLock )
			{
				handler = m_valueChanged;
			}

			handler?.Invoke( this, EventArgs.Empty );
		}

		private void RedChanged( object sender, EventArgs e )
		{
			m_value.R = (byte)rBox.Value;
			OnValueChanged();
		}
		private void GreenChanged( object sender, EventArgs e )
		{
			m_value.G = (byte)gBox.Value;
			OnValueChanged();
		}
		private void BlueChanged( object sender, EventArgs e )
		{
			m_value.B = (byte)bBox.Value;
			OnValueChanged();
		}
		private void AlphaChanged( object sender, EventArgs e )
		{
			m_value.A = (byte)aBox.Value;
			OnValueChanged();
		}

		private void ColorPickerClicked( object sender, EventArgs e )
		{
			colDialog.Color = System.Drawing.Color.FromArgb( Value.A, Value.R, Value.G, Value.B );

			if( colDialog.ShowDialog( this ) == DialogResult.OK )
			{
				Value = new Color( colDialog.Color.R, colDialog.Color.G, colDialog.Color.B, colDialog.Color.A );
				OnValueChanged();
			}
		}

		Color  m_value;
		string m_label;

		bool m_hasPicker;
		int  m_labLen,
			 m_boxLen,
			 m_boxLabLen;

		EventHandler m_valueChanged;
		readonly object m_valueLock = new object();
	}
}
