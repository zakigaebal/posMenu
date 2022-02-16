namespace posMenu
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtNum = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.txtCnt = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.lblSeq = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.txtMemo = new System.Windows.Forms.TextBox();
			this.lblTotal = new System.Windows.Forms.Label();
			this.lblDate = new System.Windows.Forms.TextBox();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(26, 28);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.Size = new System.Drawing.Size(762, 150);
			this.dataGridView1.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.textBox5);
			this.panel1.Controls.Add(this.textBox4);
			this.panel1.Controls.Add(this.txtPrice);
			this.panel1.Controls.Add(this.txtName);
			this.panel1.Controls.Add(this.txtNum);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(496, 217);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(277, 221);
			this.panel1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(674, 187);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "주문량";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "Menu";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 12);
			this.label3.TabIndex = 2;
			this.label3.Text = "Price";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 100);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 12);
			this.label4.TabIndex = 2;
			this.label4.Text = "Count";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 136);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 12);
			this.label5.TabIndex = 2;
			this.label5.Text = "Payment";
			// 
			// txtNum
			// 
			this.txtNum.Location = new System.Drawing.Point(80, 8);
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(173, 21);
			this.txtNum.TabIndex = 3;
			this.txtNum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(80, 40);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(173, 21);
			this.txtName.TabIndex = 3;
			this.txtName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(80, 67);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(173, 21);
			this.txtPrice.TabIndex = 3;
			this.txtPrice.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(80, 104);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 21);
			this.textBox4.TabIndex = 3;
			this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(80, 131);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(135, 21);
			this.textBox5.TabIndex = 3;
			this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(187, 104);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(41, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "+";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(233, 104);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(41, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "-";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(233, 131);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(41, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "OK";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(24, 181);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(64, 23);
			this.button4.TabIndex = 4;
			this.button4.Text = "주문";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(109, 181);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(59, 23);
			this.button5.TabIndex = 4;
			this.button5.Text = "변경";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(202, 181);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(59, 23);
			this.button6.TabIndex = 4;
			this.button6.Text = "취소";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// txtCnt
			// 
			this.txtCnt.Location = new System.Drawing.Point(738, 184);
			this.txtCnt.Name = "txtCnt";
			this.txtCnt.Size = new System.Drawing.Size(35, 21);
			this.txtCnt.TabIndex = 3;
			this.txtCnt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.monthCalendar1);
			this.panel2.Controls.Add(this.lblDate);
			this.panel2.Controls.Add(this.txtMemo);
			this.panel2.Controls.Add(this.textBox7);
			this.panel2.Controls.Add(this.lblTotal);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.lblSeq);
			this.panel2.Location = new System.Drawing.Point(26, 217);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(456, 233);
			this.panel2.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 8);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 12);
			this.label6.TabIndex = 1;
			this.label6.Text = "Number";
			// 
			// lblSeq
			// 
			this.lblSeq.AutoSize = true;
			this.lblSeq.Location = new System.Drawing.Point(256, 12);
			this.lblSeq.Name = "lblSeq";
			this.lblSeq.Size = new System.Drawing.Size(53, 12);
			this.lblSeq.TabIndex = 1;
			this.lblSeq.Text = "주문번호";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(256, 68);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(41, 12);
			this.label8.TabIndex = 1;
			this.label8.Text = "Memo";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(258, 30);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(178, 21);
			this.textBox7.TabIndex = 2;
			// 
			// txtMemo
			// 
			this.txtMemo.Location = new System.Drawing.Point(258, 83);
			this.txtMemo.Multiline = true;
			this.txtMemo.Name = "txtMemo";
			this.txtMemo.Size = new System.Drawing.Size(178, 88);
			this.txtMemo.TabIndex = 2;
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(256, 193);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(161, 12);
			this.lblTotal.TabIndex = 1;
			this.lblTotal.Text = "주문이 맞는지 확인해 주세요";
			// 
			// lblDate
			// 
			this.lblDate.Location = new System.Drawing.Point(17, 184);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(220, 21);
			this.lblDate.TabIndex = 2;
			this.lblDate.TextChanged += new System.EventHandler(this.lblDate_TextChanged);
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(17, 9);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 3;
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(520, 459);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(97, 23);
			this.button7.TabIndex = 5;
			this.button7.Text = "주문확인";
			this.button7.UseVisualStyleBackColor = true;
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(660, 459);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(97, 23);
			this.button8.TabIndex = 5;
			this.button8.Text = "종료";
			this.button8.UseVisualStyleBackColor = true;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 494);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txtCnt);
			this.Controls.Add(this.label1);
			this.Name = "Form2";
			this.Text = "메뉴";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtNum;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtCnt;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox lblDate;
		private System.Windows.Forms.TextBox txtMemo;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblSeq;
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
	}
}