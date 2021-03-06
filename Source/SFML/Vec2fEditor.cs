////////////////////////////////////////////////////////////////////////////////
// Vec2fEditor.cs 
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

using SFML.System;

namespace MiForms
{
	/// <summary>
	///   Control for editing Vector2f.
	/// </summary>
	[ToolboxItem( true )] [DesignTimeVisible( true )]
	public partial class Vec2fEditor : MiControl, IComponent
	{
		/// <summary>
		///   Constructor.
		/// </summary>
		public Vec2fEditor()
		:	base()
		{
			InitializeComponent();
			OnThemeChanged( null, EventArgs.Empty );

			Resize += OnResize;
			xBox.ValueChanged += XChanged;
			yBox.ValueChanged += YChanged;

			m_label     = nameof( Vector2f );
			m_labLen    = label.Width;
			m_boxLabLen = xLab.Width;
			m_boxLen    = xBox.Width;
			Value       = default;

			DecimalPlaces = 2;
			Increment     = 1;
		}
		/// <summary>
		///   Constructor setting minimum and maximum values.
		/// </summary>
		/// <param name="min">
		///   Minimum value.
		/// </param>
		/// <param name="max">
		///   Maximum value.
		/// </param>
		public Vec2fEditor( float min, float max )
		:	this()
		{
			MinXValue = min;
			MinYValue = min;
			MaxXValue = max;
			MaxYValue = max;
		}
		/// <summary>
		///   Constructor setting value along with minimum and maximum.
		/// </summary>
		/// <param name="val">
		///   Value.
		/// </param>
		/// <param name="min">
		///   Minimum value.
		/// </param>
		/// <param name="max">
		///   Maximum value.
		/// </param>
		public Vec2fEditor( Vector2f val, float min = float.MinValue, float max = float.MaxValue )
		:	this( min, max )
		{
			XValue = val.X;
			YValue = val.Y;
		}
		/// <summary>
		///   Constructor setting label along with value, minimum and maximum.
		/// </summary>
		/// <param name="label">
		///   Label text.
		/// </param>
		/// <param name="val">
		///   Value.
		/// </param>
		/// <param name="min">
		///   Minimum value.
		/// </param>
		/// <param name="max">
		///   Maximum value.
		/// </param>
		public Vec2fEditor( string label, Vector2f val = default, float min = float.MinValue, float max = float.MaxValue )
		:	this( val, min, max )
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
		///   The length in pixels of the box labels.
		/// </summary>
		public uint BoxLabelWidth
		{
			get { return (uint)m_boxLabLen; }
			set
			{
				m_boxLabLen = (int)value;
				OnResize( this, EventArgs.Empty );
			}
		}
		/// <summary>
		///   The length in pixels of the boxes.
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
		///   The text alignment of the label.
		/// </summary>
		public ContentAlignment LabelAlignment
		{
			get { return label.TextAlign; }
			set { label.TextAlign = value; }
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
		///   The x value label string.
		/// </summary>
		public string XLabel
		{
			get { return xLab.Text; }
			set { xLab.Text = value; }
		}
		/// <summary>
		///   The y value label string.
		/// </summary>
		public string YLabel
		{
			get { return yLab.Text; }
			set { yLab.Text = value; }
		}

		/// <summary>
		///   Decimal places to display.
		/// </summary>
		public uint DecimalPlaces
		{
			get { return m_dec; }
			set
			{
				m_dec = value;

				xBox.DecimalPlaces = m_dec;
				yBox.DecimalPlaces = m_dec;
			}
		}
		/// <summary>
		///   The amount to increment or decrement on each button click.
		/// </summary>
		public float Increment
		{
			get { return m_inc; }
			set
			{
				m_inc = value;

				xBox.Increment = (decimal)m_inc;
				yBox.Increment = (decimal)m_inc;
			}
		}

		/// <summary>
		///   Minimum X value.
		/// </summary>
		public float MinXValue
		{
			get { return (float)xBox.Minimum; }
			set 
			{
				xBox.Minimum = value < (float)decimal.MinValue ? decimal.MinValue :
					( value > (float)decimal.MaxValue ? decimal.MaxValue : (decimal)value );
			}
		}
		/// <summary>
		///   Minimum X value.
		/// </summary>
		public float MaxXValue
		{
			get { return (float)xBox.Maximum; }
			set
			{
				xBox.Maximum = value < (float)decimal.MinValue ? decimal.MinValue :
				  ( value > (float)decimal.MaxValue ? decimal.MaxValue : (decimal)value );
			}
		}
		/// <summary>
		///   X value.
		/// </summary>
		public float XValue
		{
			get { return m_value.X; }
			set
			{
				m_value.X = value < MinXValue ? MinXValue : ( value > MaxXValue ? MaxXValue : value );
				xBox.Value = (decimal)m_value.X;
				OnValueChanged();
			}
		}

		/// <summary>
		///   Minimum Y value.
		/// </summary>
		public float MinYValue
		{
			get { return (float)yBox.Minimum; }
			set { yBox.Minimum = value < (float)decimal.MinValue ? decimal.MinValue :
					( value > (float)decimal.MaxValue ? decimal.MaxValue : (decimal)value ); }
		}
		/// <summary>
		///   Minimum Y value.
		/// </summary>
		public float MaxYValue
		{
			get { return (float)yBox.Maximum; }
			set { yBox.Maximum = value < (float)decimal.MinValue ? decimal.MinValue :
					( value > (float)decimal.MaxValue ? decimal.MaxValue : (decimal)value ); }
		}
		/// <summary>
		///   Y value.
		/// </summary>
		public float YValue
		{
			get { return m_value.Y; }
			set
			{
				m_value.Y = value < MinYValue ? MinYValue : ( value > MaxYValue ? MaxYValue : value );
				yBox.Value = (decimal)m_value.Y;
				OnValueChanged();
			}
		}

		/// <summary>
		///   Current value.
		/// </summary>
		public Vector2f Value
		{
			get { return m_value; }
			set
			{
				if( value.X < MinXValue )
					value.X = MinXValue;
				else if( value.X > MaxXValue )
					value.X = MaxXValue;

				if( value.Y < MinYValue )
					value.Y = MinYValue;
				else if( value.Y > MaxYValue )
					value.Y = MaxYValue;

				m_value = value;

				xBox.Value = (decimal)m_value.X;
				yBox.Value = (decimal)m_value.Y;
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

			xLab.BackColor  = BackColor;
			xLab.ForeColor  = ForeColor;
			yLab.BackColor  = BackColor;
			yLab.ForeColor  = ForeColor;

			xBox.BackColor  = BackColor;
			xBox.ForeColor  = ForeColor;
			yBox.BackColor  = BackColor;
			yBox.ForeColor  = ForeColor;
		}

		private void OnLoadControl( object sender, EventArgs e )
		{
			label.Text = m_label;

			xBox.Value = (decimal)Value.X;
			yBox.Value = (decimal)Value.Y;
		}
		private void OnResize( object sender, EventArgs e )
		{
			label.Size = new Size( m_labLen, Height );
			xLab.Size  = new Size( m_boxLabLen, Height );
			yLab.Size  = new Size( m_boxLabLen, Height );
			xBox.Size  = new Size( m_boxLen, Height );
			yBox.Size  = new Size( m_boxLen, Height );

			if( HasLabel )
			{
				MinimumSize = new Size( m_labLen + ( ( m_boxLabLen + m_boxLen ) * 2 ), MinimumSize.Height );

				label.Left = 0;
				xLab.Left  = label.Right;
			}
			else
			{
				MinimumSize = new Size( ( m_boxLabLen + m_boxLen ) * 2, MinimumSize.Height );

				label.Left = Right;
				xLab.Left  = 0;
			}
			
			xBox.Left = xLab.Right;
			yBox.Left = Width - yBox.Width;
			yLab.Left = yBox.Left - yLab.Width;
		}

		private void XChanged( object sender, EventArgs e )
		{
			XValue = (float)xBox.Value;
			OnValueChanged();
		}
		private void YChanged( object sender, EventArgs e )
		{
			YValue = (float)yBox.Value;
			OnValueChanged();
		}
		private void OnValueChanged()
		{
			EventHandler handler;

			lock( m_changedLock )
			{
				handler = m_changed;
			}

			handler?.Invoke( this, EventArgs.Empty );
		}

		private Vector2f m_value;
		private string   m_label;
		private uint     m_dec;
		private float    m_inc;
		private int      m_labLen,
		                 m_boxLabLen,
		                 m_boxLen;

		private EventHandler m_changed;
		private readonly object m_changedLock = new();
	}
}
