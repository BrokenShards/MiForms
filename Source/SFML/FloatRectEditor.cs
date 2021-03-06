////////////////////////////////////////////////////////////////////////////////
// FloatRectEditor.cs 
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

using SFML.Graphics;
using SFML.System;

namespace MiForms
{
	/// <summary>
	///   Constrol for editing FloatRect.
	/// </summary>
	[ToolboxItem( true )] [DesignTimeVisible( true )]
	public partial class FloatRectEditor : MiControl, IComponent
	{
		/// <summary>
		///   Constructor.
		/// </summary>
		public FloatRectEditor()
		:	base()
		{
			InitializeComponent();
			OnThemeChanged( null, EventArgs.Empty );

			Resize += OnResize;

			m_label   = "Rect";
			m_labLen  = label.Width;
			Value     = default;
			Increment = 1;

			posVec.ValueChanged  += OnValueChanged;
			sizeVec.ValueChanged += OnValueChanged;
		}
		/// <summary>
		///   Constructor setting minimum and maximum values.
		/// </summary>
		/// <param name="minpos">
		///   Minimum position value.
		/// </param>
		/// <param name="maxpos">
		///   Maximum position value.
		/// </param>
		/// <param name="minsize">
		///   Minimum size value.
		/// </param>
		/// <param name="maxsize">
		///   Maximum size value.
		/// </param>
		public FloatRectEditor( float minpos, float maxpos, float minsize, float maxsize )
		:	this()
		{
			MinXValue = minpos;
			MinYValue = minpos;
			MinWValue = minsize;
			MinHValue = minsize;

			MaxXValue = maxpos;
			MaxYValue = maxpos;
			MaxWValue = maxsize;
			MaxHValue = maxsize;

			Value = default;
		}
		/// <summary>
		///   Constructor setting minimum and maximum values.
		/// </summary>
		/// <param name="val">
		///   Initial value.
		/// </param>
		/// <param name="minpos">
		///   Minimum position value.
		/// </param>
		/// <param name="maxpos">
		///   Maximum position value.
		/// </param>
		/// <param name="minsize">
		///   Minimum size value.
		/// </param>
		/// <param name="maxsize">
		///   Maximum size value.
		/// </param>
		public FloatRectEditor( FloatRect val, float minpos = int.MinValue, float maxpos = int.MaxValue,
							    float minsize = 1, float maxsize = int.MaxValue )
		:	this( minpos, maxpos, minsize, maxsize )
		{
			Value = val;
		}
		/// <summary>
		///   Constructor setting minimum and maximum values.
		/// </summary>
		/// <param name="label">
		///   Label text.
		/// </param>
		/// <param name="val">
		///   Initial value.
		/// </param>
		/// <param name="minpos">
		///   Minimum position value.
		/// </param>
		/// <param name="maxpos">
		///   Maximum position value.
		/// </param>
		/// <param name="minsize">
		///   Minimum size value.
		/// </param>
		/// <param name="maxsize">
		///   Maximum size value.
		/// </param>
		public FloatRectEditor( string label, FloatRect val = default, float minpos = int.MinValue,
							    float maxpos = int.MaxValue, float minsize = 1, float maxsize = int.MaxValue )
		:	this( val, minpos, maxpos, minsize, maxsize )
		{
			Label = label;
		}

		/// <summary>
		///   Minimum X value.
		/// </summary>
		public float MinXValue
		{
			get { return posVec.MinXValue; }
			set { posVec.MinXValue = value; }
		}
		/// <summary>
		///   Minimum Y value.
		/// </summary>
		public float MinYValue
		{
			get { return posVec.MinYValue; }
			set { posVec.MinYValue = value; }
		}
		/// <summary>
		///   Minimum width value.
		/// </summary>
		public float MinWValue
		{
			get { return sizeVec.MinXValue; }
			set { sizeVec.MinXValue = value; }
		}
		/// <summary>
		///   Minimum height value.
		/// </summary>
		public float MinHValue
		{
			get { return sizeVec.MinYValue; }
			set { sizeVec.MinYValue = value; }
		}

		/// <summary>
		///   Maximum X value.
		/// </summary>
		public float MaxXValue
		{
			get { return posVec.MaxXValue; }
			set { posVec.MaxXValue = value; }
		}
		/// <summary>
		///   Maximum Y value.
		/// </summary>
		public float MaxYValue
		{
			get { return posVec.MaxYValue; }
			set { posVec.MaxYValue = value; }
		}
		/// <summary>
		///   Maximum width value.
		/// </summary>
		public float MaxWValue
		{
			get { return sizeVec.MaxXValue; }
			set { sizeVec.MaxXValue = value; }
		}
		/// <summary>
		///   Maximum height value.
		/// </summary>
		public float MaxHValue
		{
			get { return sizeVec.MaxYValue; }
			set { sizeVec.MaxYValue = value; }
		}

		/// <summary>
		///   Decimal places to display.
		/// </summary>
		public uint DecimalPlaces
		{
			get { return posVec.DecimalPlaces; }
			set
			{
				posVec.DecimalPlaces = value;
				sizeVec.DecimalPlaces = value;
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

				posVec.Increment = value;
				sizeVec.Increment = value;
			}
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
			get { return posVec.BoxLabelWidth; }
			set
			{
				posVec.BoxLabelWidth  = value;
				sizeVec.BoxLabelWidth = value;
			}
		}
		/// <summary>
		///   The length in pixels of the boxes.
		/// </summary>
		public uint BoxWidth
		{
			get { return posVec.BoxWidth; }
			set
			{
				posVec.BoxWidth  = value;
				sizeVec.BoxWidth = value;
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
		///   X value.
		/// </summary>
		public float XValue
		{
			get { return posVec.XValue; }
			set { posVec.XValue = value; }
		}
		/// <summary>
		///   Y value.
		/// </summary>
		public float YValue
		{
			get { return posVec.YValue; }
			set { posVec.YValue = value; }
		}
		/// <summary>
		///   X value.
		/// </summary>
		public float WValue
		{
			get { return sizeVec.XValue; }
			set { sizeVec.XValue = value; }
		}
		/// <summary>
		///   Y value.
		/// </summary>
		public float HValue
		{
			get { return sizeVec.YValue; }
			set { sizeVec.YValue = value; }
		}

		/// <summary>
		///   The label for the X value.
		/// </summary>
		public string XLabel
		{
			get { return posVec.XLabel; }
			set { posVec.XLabel = value; }
		}
		/// <summary>
		///   The label for the Y value.
		/// </summary>
		public string YLabel
		{
			get { return posVec.YLabel; }
			set { posVec.YLabel = value; }
		}
		/// <summary>
		///   The label for the X value.
		/// </summary>
		public string WLabel
		{
			get { return sizeVec.XLabel; }
			set { sizeVec.XLabel = value; }
		}
		/// <summary>
		///   The label for the Y value.
		/// </summary>
		public string HLabel
		{
			get { return sizeVec.YLabel; }
			set { sizeVec.YLabel = value; }
		}

		/// <summary>
		///   Current value.
		/// </summary>
		public FloatRect Value
		{
			get { return m_value; }
			set
			{
				posVec.Value  = new Vector2f( value.Left,  value.Top );
				sizeVec.Value = new Vector2f( value.Width, value.Height );
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

			label.BackColor   = BackColor;
			label.ForeColor   = ForeColor;
			posVec.BackColor  = BackColor;
			posVec.ForeColor  = ForeColor;
			sizeVec.BackColor = BackColor;
			sizeVec.ForeColor = ForeColor;
		}

		private void OnValueChanged( object sender, EventArgs e )
		{
			m_value = new FloatRect( posVec.Value, sizeVec.Value );

			EventHandler handler;

			lock( m_changedLock )
			{
				handler = m_changed;
			}

			handler?.Invoke( this, EventArgs.Empty );
		}

		private void OnControlLoad( object sender, EventArgs e )
		{
			label.Text = m_label;
		}
		private void OnResize( object sender, EventArgs e )
		{
			if( HasLabel )
			{
				MinimumSize = new Size( m_labLen + posVec.MinimumSize.Width,
													   MinimumSize.Height );

				label.Location = new Point( 0, 0 );
				label.Size     = new Size( m_labLen, Height );

				posVec.Location  = new Point( label.Right, 0 );
				posVec.Size      = new Size( Width - m_labLen, Height / 2 );
				sizeVec.Location = new Point( label.Right, Height / 2 );
				sizeVec.Size     = posVec.Size;
			}
			else
			{
				MinimumSize = new Size( posVec.MinimumSize.Width, MinimumSize.Height );

				label.Left = Right;

				posVec.Location  = new Point( 0, 0 );
				posVec.Size      = new Size( Width, Height / 2 );
				sizeVec.Location = new Point( 0, Height / 2 );
				sizeVec.Size     = posVec.Size;
			}
		}

		private string    m_label;
		private FloatRect m_value;
		private float m_inc;
		private int m_labLen;

		private EventHandler m_changed;
		private readonly object m_changedLock = new();
	}
}
