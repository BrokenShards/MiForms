////////////////////////////////////////////////////////////////////////////////
// MovableForm.cs 
////////////////////////////////////////////////////////////////////////////////
//
// MiEditor - A basic entity editor for the MiFramework.
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
using System.Drawing;
using System.Windows.Forms;

namespace MiForms
{
	/// <summary>
	///   Possible points that a window can be resized from.
	/// </summary>
	[Flags]
	public enum WindowPoint
	{
		/// <summary>
		///   Window has no resize points and cannot be resized.
		/// </summary>
		None = 0,
		/// <summary>
		///   Window can be resized from the top border.
		/// </summary>
		Top = 1,
		/// <summary>
		///   Window can be resized from the bottom border.
		/// </summary>
		Bottom = 2,
		/// <summary>
		///   Window can be resized from the left border.
		/// </summary>
		Left = 4,
		/// <summary>
		///   Window can be resized from the right border.
		/// </summary>
		Right = 8,

		/// <summary>
		///   Window can be resized vertically from the top and bottom borders.
		/// </summary>
		TopBottom = Top | Bottom,
		/// <summary>
		///   Window can be resized from the top border, left border and the top left corner.
		/// </summary>
		TopLeft = Top | Left,
		/// <summary>
		///   Window can be resized from the top border, right border and the top right corner.
		/// </summary>
		TopRight = Top | Right,
		/// <summary>
		///   Window can be resized horizontally from the left and right borders.
		/// </summary>
		LeftRight = Left | Right,
		/// <summary>
		///   Window can be resized from the bottom border, left border and the bottom left corner.
		/// </summary>
		BottomLeft = Bottom | Left,
		/// <summary>
		///   Window can be resized from the bottom border, right border and the bottom right corner.
		/// </summary>
		BottomRight = Bottom | Right,

		/// <summary>
		///   Window can be resized from all four borders and corners.
		/// </summary>
		All = Top | Bottom | Left | Right
	}

	/// <summary>
	///   A borderless form that can still be moved and resized.
	/// </summary>
	public class MovableForm : MiForm
	{
		/// <summary>
		///   Constructor.
		/// </summary>
		public MovableForm()
		:	base()
		{
			Movable     = true;
			Resizable   = true;
			Dragging    = false;
			ResizePoint = (uint)WindowPoint.All;
		}

		/// <summary>
		///   If the form can be moved.
		/// </summary>
		public bool Movable
		{
			get; set;
		}
		/// <summary>
		///   If the form can be resized.
		/// </summary>
		public bool Resizable
		{
			get; set;
		}
		/// <summary>
		///   If the window is currently being dragged.
		/// </summary>
		public bool Dragging
		{
			get; private set;
		}
		/// <summary>
		///   The points the window can be resized from.
		/// </summary>
		public uint ResizePoint
		{
			get; set;
		}

		/// <summary>
		///   Sets a control as the grip point to move the window.
		/// </summary>
		/// <param name="c">
		///   The control to set as the grip point.
		/// </param>
		protected void SetDragControl( Control c )
		{
			if( c is null )
				return;

			c.MouseDown += TitleMouseDown;
			c.MouseMove += TitleMouseMove;
			c.MouseUp   += TitleMouseUp;
		}
		/// <summary>
		///   Unsets a control that was previously set as the grip point to move the window.
		/// </summary>
		/// <param name="c">
		///   The control to unset as the grip point.
		/// </param>
		protected void UnsetDragControl( Control c )
		{
			if( c is null )
				return;

			c.MouseDown -= TitleMouseDown;
			c.MouseMove -= TitleMouseMove;
			c.MouseUp   -= TitleMouseUp;
		}

		/// <summary>
		///   Processes window messages; used to capture the window resize event.
		/// </summary>
		/// <param name="m"></param>
		protected override void WndProc( ref Message m )
		{
			if( m.Msg is 0x84 )
			{
				Point pos = PointToClient( new Point( m.LParam.ToInt32() ) );

				if( ( ResizePoint & (uint)WindowPoint.Top ) is not 0 )
				{
					if( pos.Y <= _grip )
					{
						if( ( ResizePoint & (uint)WindowPoint.Left ) is not 0 )
						{
							if( pos.X <= _grip )
							{
								m.Result = (IntPtr)HTTOPLEFT;
								return;
							}
						}
						if( ( ResizePoint & (uint)WindowPoint.Right ) is not 0 )
						{
							if( pos.X >= ClientSize.Width - _grip )
							{
								m.Result = (IntPtr)HTTOPRIGHT;
								return;
							}
						}

						m.Result = (IntPtr)HTTOP;
						return;
					}
				}				
				if( ( ResizePoint & (uint)WindowPoint.Bottom ) is not 0 )
				{
					if( pos.Y >= ClientSize.Height - _grip )
					{
						if( ( ResizePoint & (uint)WindowPoint.Left ) is not 0 )
						{
							if( pos.X <= _grip )
							{
								m.Result = (IntPtr)HTBOTTOMLEFT;
								return;
							}
						}
						if( ( ResizePoint & (uint)WindowPoint.Right ) is not 0 )
						{
							if( pos.X >= ClientSize.Width - _grip )
							{
								m.Result = (IntPtr)HTBOTTOMRIGHT;
								return;
							}
						}

						m.Result = (IntPtr)HTBOTTOM;
						return;
					}
				}

				if( ( ResizePoint & (uint)WindowPoint.Left ) is not 0 )
				{
					if( pos.X <= _grip )
					{
						m.Result = (IntPtr)HTLEFT;
						return;
					}
				}
				if( ( ResizePoint & (uint)WindowPoint.Right ) is not 0 )
				{
					if( pos.X >= ClientSize.Width - _grip )
					{
						m.Result = (IntPtr)HTRIGHT;
						return;
					}
				}
			}

			base.WndProc( ref m );
		}

		private void TitleMouseMove( object sender, MouseEventArgs e )
		{
			if( Movable && Dragging )
			{
				Point dif = Point.Subtract( Cursor.Position, new Size( m_dragCursorPoint ) );
				Location = Point.Add( m_dragFormPoint, new Size( dif ) );
			}
		}
		private void TitleMouseUp( object sender, MouseEventArgs e )
		{
			Dragging = false;
		}
		private void TitleMouseDown( object sender, MouseEventArgs e )
		{
			if( Movable )
			{
				Dragging = true;
				m_dragCursorPoint = Cursor.Position;
				m_dragFormPoint = Location;
			}
		}

		private Point m_dragCursorPoint;
		private Point m_dragFormPoint;

		private const int _grip = 16;

		private const int HTLEFT        = 10,
		                  HTRIGHT       = 11,
		                  HTTOP         = 12,
		                  HTTOPLEFT     = 13,
		                  HTTOPRIGHT    = 14,
						  HTBOTTOM      = 15,
		                  HTBOTTOMLEFT  = 16,
		                  HTBOTTOMRIGHT = 17;
	}
}
