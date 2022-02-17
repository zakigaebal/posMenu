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
using MySql.Data.MySqlClient;

namespace posMenu
{
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}

		public Form4(MySqlConnection con)
		{
	
		}

		public SqlConnection Con { get; }
	}
}
