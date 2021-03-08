////////////////////////////////////////////////////////////////////////////////
// Vec2iEditor.cs 
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
using SFML.System;

using ContentAlignment = System.Drawing.ContentAlignment;
using Size             = System.Drawing.Size;

namespace MiForms
{
	/// <summary>
	///   Control for editing Vector2i.
	/// </summary>
	[ToolboxItem( true )] [DesignTimeVisible( true )]
	public partial class Vec2iEditor : MiControl, IComponent
	{
		/// <summary>
		///   Constructor.
		/// </summary>
		public Vec2iEditor()
		{
			InitializeComponent();
			Resize += OnResize;
			xBox.ValueChanged += XChanged;
			yBox.ValueChanged += YChanged;

			OnThemeChanged( null, EventArgs.Empty );

			m_label     = nameof( Vector2i );
			m_labLen    = label.Width;
			m_boxLabLen = xLab.Width;
			m_boxLen    = xBox.Width;
			Value       = default;
			Increment   = 1;
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
		public Vec2iEditor( int min, int max )
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
		public Vec2iEditor( Vector2i val, int min = int.MinValue, int max = int.MaxValue )
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
		public Vec2iEditor( string label, Vector2i val = default, int min = int.MinValue, int max = int.MaxValue )
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

				if( label != null )
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
		///   The amount to increment or decrement on each button click.
		/// </summary>
		public int Increment
		{
			get { return m_inc; }
			set
			{
				m_inc = value;

				xBox.Increment = m_inc;
				yBox.Increment = m_inc;
			}
		}

		/// <summary>
		///   Minimum X value.
		/// </summary>
		public int MinXValue
		{
			get { return (int)xBox.Minimum; }
			set { xBox.Minimum = value; }
		}
		/// <summary>
		///   Minimum X value.
		/// </summary>
		public int MaxXValue
		{
			get { return (int)xBox.Maximum; }
			set { xBox.Maximum = value; }
		}
		/// <summary>
		///   X value.
		/// </summary>
		public int XValue
		{
			get { return m_value.X; }
			set 
			{ 
				m_value.X = value;
				xBox.Value = m_value.X;
				OnValueChanged();
			}
		}

		/// <summary>
		///   Minimum Y value.
		/// </summary>
		public int MinYValue
		{
			get { return (int)yBox.Minimum; }
			set { yBox.Minimum = value; }
		}
		/// <summary>
		///   Minimum Y value.
		/// </summary>
		public int MaxYValue
		{
			get { return (int)yBox.Maximum; }
			set { yBox.Maximum = value; }
		}
		/// <summary>
		///   Y value.
		/// </summary>
		public int YValue
		{
			get { return m_value.Y; }
			set
			{
				m_value.Y = value;
				yBox.Value = m_value.Y;
				OnValueChanged();
			}
		}

		/// <summary>
		///   Current value.
		/// </summary>
		public Vector2i Value
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

				xBox.Value = m_value.X;
				yBox.Value = m_value.Y;
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
		}

		private void OnLoadControl( object sender, EventArgs e )
		{
			label.Text = m_label;

			xBox.Value = Value.X;
			yBox.Value = Value.Y;
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
			XValue = (int)xBox.Value;
		}
		private void YChanged( object sender, EventArgs e )
		{
			YValue = (int)yBox.Value;
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

		Vector2i m_value;
		string   m_label;
		int      m_inc,
		         m_labLen,
		         m_boxLabLen,
		         m_boxLen;

		EventHandler m_changed;
		readonly object m_changedLock = new object();
	}
}
