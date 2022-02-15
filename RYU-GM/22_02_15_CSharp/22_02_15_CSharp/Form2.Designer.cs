namespace _22_02_15_CSharp
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.치트키ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.포켓몬ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.아이템ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.스토리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.족ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.먹밥ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ㅌToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "계좌 생성";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(262, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "생성 및 잔금 변경";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(262, 213);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "복사 및 출력";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(416, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(565, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(496, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.치트키ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 치트키ToolStripMenuItem
            // 
            this.치트키ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.포켓몬ToolStripMenuItem,
            this.아이템ToolStripMenuItem,
            this.스토리ToolStripMenuItem});
            this.치트키ToolStripMenuItem.Name = "치트키ToolStripMenuItem";
            this.치트키ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.치트키ToolStripMenuItem.Text = "치트키";
            // 
            // 포켓몬ToolStripMenuItem
            // 
            this.포켓몬ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.족ToolStripMenuItem});
            this.포켓몬ToolStripMenuItem.Name = "포켓몬ToolStripMenuItem";
            this.포켓몬ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.포켓몬ToolStripMenuItem.Text = "포켓몬";
            // 
            // 아이템ToolStripMenuItem
            // 
            this.아이템ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.먹밥ToolStripMenuItem});
            this.아이템ToolStripMenuItem.Name = "아이템ToolStripMenuItem";
            this.아이템ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.아이템ToolStripMenuItem.Text = "아이템";
            // 
            // 스토리ToolStripMenuItem
            // 
            this.스토리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ㅌToolStripMenuItem});
            this.스토리ToolStripMenuItem.Name = "스토리ToolStripMenuItem";
            this.스토리ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.스토리ToolStripMenuItem.Text = "스토리";
            // 
            // 족ToolStripMenuItem
            // 
            this.족ToolStripMenuItem.Name = "족ToolStripMenuItem";
            this.족ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.족ToolStripMenuItem.Text = "600족";
            // 
            // 먹밥ToolStripMenuItem
            // 
            this.먹밥ToolStripMenuItem.Name = "먹밥ToolStripMenuItem";
            this.먹밥ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.먹밥ToolStripMenuItem.Text = "먹밥";
            // 
            // ㅌToolStripMenuItem
            // 
            this.ㅌToolStripMenuItem.Name = "ㅌToolStripMenuItem";
            this.ㅌToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ㅌToolStripMenuItem.Text = "ㅌ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(121, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 치트키ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 포켓몬ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 족ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 아이템ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 먹밥ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 스토리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ㅌToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
    }
}