﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cineplex_prototype_01
{
	public partial class form_UpdateMovie : Form
	{
		public form_UpdateMovie()
		{
			InitializeComponent ();
		}

		private void back2Admin_fromUM_Click( object sender, EventArgs e )
		{
			this.Close ();
		}
	}
}
