////////////////////////////////////////////////////////////////////////////////
// FolderLoader.cs
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
	///   A component that contains a path bar and a button that opens a dialog to select a folder.
	/// </summary>
	[ToolboxItem( true )] [DesignTimeVisible( true )]
	public partial class FolderLoader : MiControl, IComponent
	{
		/// <summary>
		///   Constructor.
		/// </summary>
		public FolderLoader()
		{
			InitializeComponent();
			Resize  += OnResize;
			pathBox.TextChanged += PathTextChanged;
			OnThemeChanged( null, EventArgs.Empty );
			m_labLen = label.Width;
			m_boxOff = 0;
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
		public uint LabelLength
		{
			get { return (uint)m_labLen; }
			set 
			{
				m_labLen = (int)value;
				OnResize( this, EventArgs.Empty );
			}
		}
		/// <summary>
		///   Editor label text.
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
		///   Offset between the label and path box.
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
		///   If the dialog should show the new folder button.
		/// </summary>
		public bool ShowNewFolderButton
		{
			get { return openDialog.ShowNewFolderButton; }
			set { openDialog.ShowNewFolderButton = value; }
		}
		/// <summary>
		///   The descriptive text displayed above the tree view control in the dialog box.
		/// </summary>
		public string Description
		{
			get { return openDialog.Description; }
			set { openDialog.Description = value; }
		}
		/// <summary>
		///   The initial directory for the select folder dialog.
		/// </summary>
		public Environment.SpecialFolder RootFolder
		{
			get { return openDialog.RootFolder; }
			set { openDialog.RootFolder = value; }
		}

		/// <summary>
		///   Current path string.
		/// </summary>
		public string Path
		{
			get { return m_path; }
			set 
			{
				m_path = value;
				pathBox.Text = m_path;
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

			label.BackColor    = BackColor;
			label.ForeColor    = ForeColor;
			boxPanel.BackColor = BackColor;
			boxPanel.ForeColor = ForeColor;
			pathBox.BackColor  = Theme.FieldColor;
			pathBox.ForeColor  = ForeColor;
			butPanel.BackColor = BackColor;
			butPanel.ForeColor = ForeColor;
			pathBut.BackColor  = BackColor;
			pathBut.ForeColor  = ForeColor;

			pathBut.BackgroundImage = Theme.UseDarkTheme ? butImages.Images[ 0 ] : butImages.Images[ 1 ];
		}

		private void OnLoadControl( object sender, EventArgs e )
		{
			label.Text = m_label;
			pathBox.Text = m_path;
		}
		private void OnResize( object sender, EventArgs e )
		{
			if( HasLabel )
			{
				MinimumSize = new Size( m_labLen + m_boxOff + 70 + butPanel.Width + 2, MinimumSize.Height );

				label.Left  = 0;
				label.Width = m_labLen;

				boxPanel.Left  = label.Right + m_boxOff;
				boxPanel.Width = Width - butPanel.Width - 2 - boxPanel.Left;
			}
			else
			{
				MinimumSize = new Size( m_boxOff + 70 + butPanel.Width + 2, MinimumSize.Height );

				label.Left = Right;

				boxPanel.Left  = m_boxOff;
				boxPanel.Width = Width - butPanel.Width - 2;
			}

			butPanel.Left = boxPanel.Right + 2;
		}

		private void PathTextChanged( object sender, EventArgs e )
		{
			Path = pathBox.Text;
			OnValueChanged();
		}
		private void PathButtonClicked( object sender, EventArgs e )
		{
			if( openDialog.ShowDialog( this ) == DialogResult.OK )
			{
				Path = openDialog.SelectedPath;
				OnValueChanged();
			}
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

		string m_label,
		       m_path;

		int m_labLen,
		    m_boxOff;

		EventHandler m_changed;
		readonly object m_changedLock = new object();
	}
}
