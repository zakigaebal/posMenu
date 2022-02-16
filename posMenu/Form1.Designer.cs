namespace posMenu
{
	partial class Form1
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.주문ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.매출ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.eventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.checkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.상품별매출ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.기간별매출ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.주문ToolStripMenuItem,
            this.매출ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 주문ToolStripMenuItem
			// 
			this.주문ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.eventToolStripMenuItem,
            this.checkToolStripMenuItem,
            this.도움말ToolStripMenuItem,
            this.종료ToolStripMenuItem});
			this.주문ToolStripMenuItem.Name = "주문ToolStripMenuItem";
			this.주문ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.주문ToolStripMenuItem.Text = "주문";
			// 
			// 매출ToolStripMenuItem
			// 
			this.매출ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.상품별매출ToolStripMenuItem,
            this.기간별매출ToolStripMenuItem});
			this.매출ToolStripMenuItem.Name = "매출ToolStripMenuItem";
			this.매출ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.매출ToolStripMenuItem.Text = "매출";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.menuToolStripMenuItem.Text = "Menu";
			// 
			// eventToolStripMenuItem
			// 
			this.eventToolStripMenuItem.Name = "eventToolStripMenuItem";
			this.eventToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.eventToolStripMenuItem.Text = "Event";
			// 
			// checkToolStripMenuItem
			// 
			this.checkToolStripMenuItem.Name = "checkToolStripMenuItem";
			this.checkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.checkToolStripMenuItem.Text = "Check";
			// 
			// 도움말ToolStripMenuItem
			// 
			this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
			this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.도움말ToolStripMenuItem.Text = "도움말";
			// 
			// 종료ToolStripMenuItem
			// 
			this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
			this.종료ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.종료ToolStripMenuItem.Text = "종료";
			// 
			// 상품별매출ToolStripMenuItem
			// 
			this.상품별매출ToolStripMenuItem.Name = "상품별매출ToolStripMenuItem";
			this.상품별매출ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.상품별매출ToolStripMenuItem.Text = "상품별 매출";
			// 
			// 기간별매출ToolStripMenuItem
			// 
			this.기간별매출ToolStripMenuItem.Name = "기간별매출ToolStripMenuItem";
			this.기간별매출ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.기간별매출ToolStripMenuItem.Text = "기간별 매출";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(100, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "label1";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(183, 87);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(215, 21);
			this.textBox1.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(467, 85);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "조회";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(100, 155);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "label1";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(183, 152);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(215, 21);
			this.textBox2.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "메뉴 등록하기";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 주문ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem eventToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem checkToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 매출ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 상품별매출ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 기간별매출ToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
	}
}

