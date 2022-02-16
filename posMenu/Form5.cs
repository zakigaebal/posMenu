using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace posMenu
{
	public partial class Form5 : Form
	{
		public Form5()
		{
			InitializeComponent();
		}

		public Form5(SqlConnection con)
		{
			Con = con;
		}

		public SqlConnection Con { get; }
	}
}
