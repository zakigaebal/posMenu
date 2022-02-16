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
  public partial class Form2 : Form
  {
    SqlConnection con;
    SqlCommand cmd;
    SqlDataAdapter adt;
    string sql;
    public Form2(SqlConnection con)
    {
      InitializeComponent();
      this.con = con;
      if (con.State != ConnectionState.Open)
        con.Open();
    }

    private void Form2_Load(object sender, EventArgs e)
    {
      // TODO: 이 코드는 데이터를 'posDBDataSet.TBposmenu' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
      // this.tBposmenuTableAdapter.Fill(this.posDBDataSet.TBposmenu);

      sql = "select * from TBposmenu ";
      cmd = new SqlCommand(sql, con);

      adt = new SqlDataAdapter(cmd);
      DataTable tb = new DataTable();
      adt.Fill(tb);
      dataGridView1.DataSource = tb.DefaultView;

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      txtNum.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
      txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
      txtPrice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      // OK 버튼(결제 금액 계산)
      if (txtNum.Text == "" || txtName.Text == "" || txtPrice.Text == "" || lblDate.Text == "")
        MessageBox.Show("항목을 모두 입력해주세요.", "Option", MessageBoxButtons.OK, MessageBoxIcon.Error);
      else
      {
        long tot = Int32.Parse(txtPrice.Text) * Int32.Parse(txtCnt.Text);
        lblTotal.Text = tot.ToString();

        txtMemo.Text = "주문하신 " + txtName.Text + "음료 " + txtCnt.Text + "잔 해서 총 " +
            lblTotal.Text + "원 입니다.";

        txtNum.Text = monthCalendar1.SelectionStart.ToString("yyyyMMdd") + lblSeq.Text + txtNum.Text;
      }
    }

    private void button5_Click(object sender, EventArgs e)
    {
      // + 버튼
      int cnt = Int32.Parse(txtCnt.Text);
      cnt += 1;
      txtCnt.Text = cnt.ToString();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      // - 버튼
      if (txtCnt.Text != "0")
      {
        int cnt = Int32.Parse(txtCnt.Text);
        cnt -= 1;
        txtCnt.Text = cnt.ToString();
      }

    }

    private void button7_Click(object sender, EventArgs e)
    {
      // 종료 버튼
      if (con.State != ConnectionState.Closed)
        con.Close();
      this.Close();
    }

    private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
    {
      lblDate.Text = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
    }

    private void textBox5_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

		private void lblDate_TextChanged(object sender, EventArgs e)
		{

		}
	}
}