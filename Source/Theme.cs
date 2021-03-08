////////////////////////////////////////////////////////////////////////////////
// Theme.cs 
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
using System.Drawing;

namespace MiForms
{
	/// <summary>
	///   Contains control theme information.
	/// </summary>
	public static class Theme
	{
		/// <summary>
		///   True for the dark color scheme, false for the light.
		/// </summary>
		public static bool UseDarkTheme
		{
			get { return m_dark; }
			set
			{
				if( value != m_dark )
				{
					m_dark = value;
					OnThemeChanged();
				}
			}
		}

		/// <summary>
		///   The background color used for the current color scheme.
		/// </summary>
		public static Color BackColor
		{
			get { return UseDarkTheme ? DarkBackColor : LightBackColor; }
		}
		/// <summary>
		///   The foreground color used for the current color scheme.
		/// </summary>
		public static Color ForeColor
		{
			get { return UseDarkTheme ? DarkForeColor : LightForeColor; }
		}
		/// <summary>
		///   The field color used for the current color scheme.
		/// </summary>
		public static Color FieldColor
		{
			get { return UseDarkTheme ? DarkFieldColor : LightFieldColor; }
		}

		/// <summary>
		///   The background color used for the light color scheme.
		/// </summary>
		public static Color LightBackColor
		{
			get { return m_light_back; }
			set
			{
				if( value != m_light_back )
				{
					m_light_back = value;
					OnThemeChanged();
				}
			}
		}
		/// <summary>
		///   The foreground color used for the light color scheme.
		/// </summary>
		public static Color LightForeColor
		{
			get { return m_light_fore; }
			set
			{
				if( value != m_light_fore )
				{
					m_light_fore = value;
					OnThemeChanged();
				}
			}
		}
		/// <summary>
		///   The field color used for the light color scheme.
		/// </summary>
		public static Color LightFieldColor
		{
			get { return m_light_field; }
			set
			{
				if( value != m_light_field )
				{
					m_light_field = value;
					OnThemeChanged();
				}
			}
		}

		/// <summary>
		///   The background color used for the dark color scheme.
		/// </summary>
		public static Color DarkBackColor
		{
			get { return m_dark_back; }
			set
			{
				if( value != m_dark_back )
				{
					m_dark_back = value;
					OnThemeChanged();
				}
			}
		}
		/// <summary>
		///   The foreground color used for the dark color scheme.
		/// </summary>
		public static Color DarkForeColor
		{
			get { return m_dark_fore; }
			set
			{
				if( value != m_dark_fore )
				{
					m_dark_fore = value;
					OnThemeChanged();
				}
			}
		}
		/// <summary>
		///   The field color used for the dark color scheme.
		/// </summary>
		public static Color DarkFieldColor
		{
			get { return m_dark_field; }
			set
			{
				if( value != m_dark_field )
				{
					m_dark_field = value;
					OnThemeChanged();
				}
			}
		}

		/// <summary>
		///   Occurs when the theme is changed.
		/// </summary>
		public static event EventHandler ThemeChanged
		{
			add
			{
				lock( m_theme_changed_lock )
				{
					m_theme_changed += value;
				}
			}
			remove
			{
				lock( m_theme_changed_lock )
				{
					m_theme_changed -= value;
				}
			}
		}

		/// <summary>
		///   Converts a <see cref="System.Drawing.Color"/> to a <see cref="SFML.Graphics.Color"/>.
		/// </summary>
		/// <param name="col">
		///   The color to convert.
		/// </param>
		/// <returns>
		///   The color converted to an SFML color.
		/// </returns>
		public static SFML.Graphics.Color ToSFColor( Color col )
		{
			return new SFML.Graphics.Color( col.R, col.G, col.B, col.A );
		}
		/// <summary>
		///   Converts a <see cref="SFML.Graphics.Color"/> to a <see cref="System.Drawing.Color"/>.
		/// </summary>
		/// <param name="col">
		///   The color to convert.
		/// </param>
		/// <returns>
		///   The color converted from an SFML color.
		/// </returns>
		public static Color FromSFColor( SFML.Graphics.Color col )
		{
			return Color.FromArgb( col.A, col.R, col.G, col.B );
		}

		private static void OnThemeChanged()
		{
			EventHandler handler;

			lock( m_theme_changed_lock )
			{
				handler = m_theme_changed;
			}

			handler?.Invoke( null, EventArgs.Empty );
		}

		private static bool  m_dark        = true;
		private static Color m_dark_back   = Color.FromArgb( 255,  45,  45,  48 ),
							 m_dark_fore   = Color.FromArgb( 255, 240, 240, 240 ),
							 m_dark_field  = Color.FromArgb( 255,  28,  28,  28 ),
							 m_light_back  = Color.FromArgb( 255, 240, 240, 240 ),
							 m_light_fore  = Color.FromArgb( 255,  28,  28,  28 ),
							 m_light_field = Color.FromArgb( 255, 255, 255, 255 );

		private static EventHandler    m_theme_changed;
		private static readonly object m_theme_changed_lock = new object();
	}
}
