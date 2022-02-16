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
	public partial class Form1 : Form
	{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataReader reader;
    string sql;
    public Form1()
		{
      InitializeComponent();
      //string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\exCS\\posSystem\\posDB.mdf;Integrated Security=True;Connect Timeout=30";
      //con = new SqlConnection(constr);
      //con.Open();
    }

    private void menuToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // Menu 화면
      Form2 frm2 = new Form2(con);
      frm2.Show();
    }

    private void eventToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // Event 화면
      Form3 frm3 = new Form3();
      frm3.Show();
    }

    private void checkToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // Check 화면
      Form4 frm4 = new Form4(con);
      frm4.Show();
    }

    private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // 화면 종료
      if (con.State != ConnectionState.Closed)
        con.Close();
      this.Close();
    }

    private void 상품별매출ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // 상품별 매출
      Form5 frm5 = new Form5(con);
      frm5.Show();
    }

    private void 기간별매출ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // 기간별 매출
      Form6 frm6 = new Form6(con);
      frm6.Show();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      // 조회 버튼
      string value1 = textBox1.Text;

      if (con.State != ConnectionState.Open)
        con.Open();

      sql = "select * from TBposmenu " +
          " where id= '" + value1 + "' ";
      cmd = new SqlCommand(sql, con);

      reader = cmd.ExecuteReader();
      while (reader.Read())
      {
        textBox1.Text = reader["id"].ToString();
        textBox2.Text = reader["name"].ToString();
        txtOption.Text = reader["price"].ToString();
        txtOption.Text = reader["options"].ToString();
      }
      reader.Close();

      if (con.State != ConnectionState.Closed)
        con.Close();

    }
    private void button2_Click(object sender, EventArgs e)
    {
      // 등록 버튼
      if (txtOption.Text == "")
        MessageBox.Show("옵션 선택을 해주시길 바랍니다.\nICE 또는 HOT으로 선택가능합니다.", "Option", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      else
      {
        if (con.State != ConnectionState.Open)
          con.Open();

        string value1, value2, value3, value4;
        value1 = textBox1.Text;
        value2 = textBox2.Text;
        value3 = txtOption.Text;
        value4 = txtOption.Text;

        sql = "insert into TBposmenu " +
            " values('" + value1 + "', N'" + value2 + "', '" + value3 + "', '" + value4 + "')";
        cmd = new SqlCommand(sql, con);
        cmd.ExecuteNonQuery();

        if (con.State != ConnectionState.Closed)
          con.Close();

        MessageBox.Show("등록이 완료되었습니다.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      // 수정 버튼
      if (con.State != ConnectionState.Open)
        con.Open();

      string value1, value2, value3, value4;
      value1 = textBox1.Text;
      value2 = textBox2.Text;
      value3 = txtOption.Text;
      value4 = txtOption.Text;

      sql = "update TBposmenu " +
          " set name = N'" + value2 + "', " +
          " price = '" + value3 + "', " +
          " options = '" + value4 + "' " +
          " where id = '" + value1 + "' ";
      cmd = new SqlCommand(sql, con);
      cmd.ExecuteNonQuery();

      if (con.State != ConnectionState.Closed)
        con.Close();

      radioButton1.Checked = false; radioButton2.Checked = false;
      textBox1.Text = ""; textBox2.Text = ""; txtOption.Text = ""; txtOption.Text = "";
      MessageBox.Show("수정이 완료되었습니다.", "modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void button4_Click(object sender, EventArgs e)
    {
      // 삭제 버튼
      if (con.State != ConnectionState.Open)
        con.Open();

      string value1 = textBox1.Text;

      sql = "delete from TBposmenu " +
          " where id = '" + value1 + "' ";
      cmd = new SqlCommand(sql, con);
      cmd.ExecuteNonQuery();

      if (con.State != ConnectionState.Closed)
        con.Close();

      radioButton1.Checked = false; radioButton2.Checked = false;
      textBox1.Text = ""; textBox2.Text = ""; txtOption.Text = ""; txtOption.Text = "";
      MessageBox.Show("삭제가 완료되었습니다.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void TextBox1_Click(object sender, EventArgs e)
    {
      textBox1.Text = ""; textBox2.Text = ""; txtOption.Text = "";
    }

    private void button5_Click(object sender, EventArgs e)
    {
      // 종료 버튼
      if (con.State != ConnectionState.Closed)     // DB 연결이 닫히지 않은 경우 닫음.
        con.Close();
      this.Close();
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
      txtOption.Text = radioButton1.Text;
    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {
      txtOption.Text = radioButton2.Text;
    }

    private void textBox1_Click(object sender, EventArgs e)
    {
      radioButton1.Checked = false; radioButton2.Checked = false;
      textBox1.Text = ""; textBox2.Text = ""; txtOption.Text = ""; txtOption.Text = "";
    }

    private void 도움말ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MessageBox.Show("등록 번호는 고유한 값을 입력해야 합니다.\n" +
          "조회 버튼을 눌러 등록된 음료의 여부를 확인해주시기 바랍니다.", "신 메뉴 등록 시 유의사항", MessageBoxButtons.OK,
          MessageBoxIcon.Exclamation);
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
