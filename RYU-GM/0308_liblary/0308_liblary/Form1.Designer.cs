namespace _0308_liblary
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.menuStrip_manager = new System.Windows.Forms.MenuStrip();
            this.도서관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사용자관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label_allBookCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_allUserCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_allBorrowedBook = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_allDelayedBook = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.button_borrow = new System.Windows.Forms.Button();
            this.button_return = new System.Windows.Forms.Button();
            this.textBox_isbn = new System.Windows.Forms.TextBox();
            this.textBox_BookName = new System.Windows.Forms.TextBox();
            this.textBox_UserId = new System.Windows.Forms.TextBox();
            this.dataGridView_BookManager = new System.Windows.Forms.DataGridView();
            this.dataGridView_UserManager = new System.Windows.Forms.DataGridView();
            this.statusStrip_now = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_now = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer_now = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip_manager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BookManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UserManager)).BeginInit();
            this.statusStrip_now.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label_allDelayedBook);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label_allBorrowedBook);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label_allUserCount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_allBookCount);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "도서관 현황";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_UserId);
            this.groupBox2.Controls.Add(this.textBox_BookName);
            this.groupBox2.Controls.Add(this.textBox_isbn);
            this.groupBox2.Controls.Add(this.button_return);
            this.groupBox2.Controls.Add(this.button_borrow);
            this.groupBox2.Controls.Add(this.label44);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(273, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(908, 178);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "대여/반납";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView_BookManager);
            this.groupBox3.Location = new System.Drawing.Point(12, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1169, 178);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "도서 현황";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView_UserManager);
            this.groupBox4.Location = new System.Drawing.Point(12, 471);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1169, 173);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "사용자 현황";
            // 
            // menuStrip_manager
            // 
            this.menuStrip_manager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도서관리ToolStripMenuItem,
            this.사용자관리ToolStripMenuItem});
            this.menuStrip_manager.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_manager.Name = "menuStrip_manager";
            this.menuStrip_manager.Size = new System.Drawing.Size(1198, 24);
            this.menuStrip_manager.TabIndex = 3;
            this.menuStrip_manager.Text = "menuStrip1";
            // 
            // 도서관리ToolStripMenuItem
            // 
            this.도서관리ToolStripMenuItem.Name = "도서관리ToolStripMenuItem";
            this.도서관리ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.도서관리ToolStripMenuItem.Text = "도서관리";
            this.도서관리ToolStripMenuItem.Click += new System.EventHandler(this.도서관리ToolStripMenuItem_Click);
            // 
            // 사용자관리ToolStripMenuItem
            // 
            this.사용자관리ToolStripMenuItem.Name = "사용자관리ToolStripMenuItem";
            this.사용자관리ToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.사용자관리ToolStripMenuItem.Text = "사용자 관리";
            this.사용자관리ToolStripMenuItem.Click += new System.EventHandler(this.사용자관리ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "전체 도서 수";
            // 
            // label_allBookCount
            // 
            this.label_allBookCount.AutoSize = true;
            this.label_allBookCount.Location = new System.Drawing.Point(125, 32);
            this.label_allBookCount.Name = "label_allBookCount";
            this.label_allBookCount.Size = new System.Drawing.Size(11, 12);
            this.label_allBookCount.TabIndex = 1;
            this.label_allBookCount.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "사용자 수";
            // 
            // label_allUserCount
            // 
            this.label_allUserCount.AutoSize = true;
            this.label_allUserCount.Location = new System.Drawing.Point(125, 67);
            this.label_allUserCount.Name = "label_allUserCount";
            this.label_allUserCount.Size = new System.Drawing.Size(11, 12);
            this.label_allUserCount.TabIndex = 3;
            this.label_allUserCount.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "대충중인 도서";
            // 
            // label_allBorrowedBook
            // 
            this.label_allBorrowedBook.AutoSize = true;
            this.label_allBorrowedBook.Location = new System.Drawing.Point(125, 109);
            this.label_allBorrowedBook.Name = "label_allBorrowedBook";
            this.label_allBorrowedBook.Size = new System.Drawing.Size(11, 12);
            this.label_allBorrowedBook.TabIndex = 5;
            this.label_allBorrowedBook.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "연체중인 도서";
            // 
            // label_allDelayedBook
            // 
            this.label_allDelayedBook.AutoSize = true;
            this.label_allDelayedBook.Location = new System.Drawing.Point(125, 146);
            this.label_allDelayedBook.Name = "label_allDelayedBook";
            this.label_allDelayedBook.Size = new System.Drawing.Size(11, 12);
            this.label_allDelayedBook.TabIndex = 7;
            this.label_allDelayedBook.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "ISBN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "도서 이름";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(20, 121);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(56, 12);
            this.label44.TabIndex = 2;
            this.label44.Text = "사용자 ID";
            // 
            // button_borrow
            // 
            this.button_borrow.Location = new System.Drawing.Point(694, 144);
            this.button_borrow.Name = "button_borrow";
            this.button_borrow.Size = new System.Drawing.Size(75, 23);
            this.button_borrow.TabIndex = 3;
            this.button_borrow.Text = "대여";
            this.button_borrow.UseVisualStyleBackColor = true;
            // 
            // button_return
            // 
            this.button_return.Location = new System.Drawing.Point(798, 144);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(75, 23);
            this.button_return.TabIndex = 4;
            this.button_return.Text = "반납";
            this.button_return.UseVisualStyleBackColor = true;
            // 
            // textBox_isbn
            // 
            this.textBox_isbn.Location = new System.Drawing.Point(120, 27);
            this.textBox_isbn.Name = "textBox_isbn";
            this.textBox_isbn.Size = new System.Drawing.Size(753, 21);
            this.textBox_isbn.TabIndex = 5;
            // 
            // textBox_BookName
            // 
            this.textBox_BookName.Location = new System.Drawing.Point(120, 73);
            this.textBox_BookName.Name = "textBox_BookName";
            this.textBox_BookName.Size = new System.Drawing.Size(753, 21);
            this.textBox_BookName.TabIndex = 6;
            // 
            // textBox_UserId
            // 
            this.textBox_UserId.Location = new System.Drawing.Point(120, 117);
            this.textBox_UserId.Name = "textBox_UserId";
            this.textBox_UserId.Size = new System.Drawing.Size(753, 21);
            this.textBox_UserId.TabIndex = 7;
            // 
            // dataGridView_BookManager
            // 
            this.dataGridView_BookManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BookManager.Location = new System.Drawing.Point(8, 20);
            this.dataGridView_BookManager.Name = "dataGridView_BookManager";
            this.dataGridView_BookManager.RowTemplate.Height = 23;
            this.dataGridView_BookManager.Size = new System.Drawing.Size(1155, 150);
            this.dataGridView_BookManager.TabIndex = 8;
            // 
            // dataGridView_UserManager
            // 
            this.dataGridView_UserManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_UserManager.Location = new System.Drawing.Point(7, 14);
            this.dataGridView_UserManager.Name = "dataGridView_UserManager";
            this.dataGridView_UserManager.RowTemplate.Height = 23;
            this.dataGridView_UserManager.Size = new System.Drawing.Size(1155, 150);
            this.dataGridView_UserManager.TabIndex = 9;
            // 
            // statusStrip_now
            // 
            this.statusStrip_now.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_now});
            this.statusStrip_now.Location = new System.Drawing.Point(0, 712);
            this.statusStrip_now.Name = "statusStrip_now";
            this.statusStrip_now.Size = new System.Drawing.Size(1198, 22);
            this.statusStrip_now.TabIndex = 4;
            this.statusStrip_now.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_now
            // 
            this.toolStripStatusLabel_now.Name = "toolStripStatusLabel_now";
            this.toolStripStatusLabel_now.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel_now.Text = "-";
            // 
            // timer_now
            // 
            this.timer_now.Enabled = true;
            this.timer_now.Interval = 1000;
            this.timer_now.Tick += new System.EventHandler(this.timer_now_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 734);
            this.Controls.Add(this.statusStrip_now);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip_manager);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.menuStrip_manager.ResumeLayout(false);
            this.menuStrip_manager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BookManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UserManager)).EndInit();
            this.statusStrip_now.ResumeLayout(false);
            this.statusStrip_now.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_allDelayedBook;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_allBorrowedBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_allUserCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_allBookCount;
        private System.Windows.Forms.TextBox textBox_UserId;
        private System.Windows.Forms.TextBox textBox_BookName;
        private System.Windows.Forms.TextBox textBox_isbn;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.Button button_borrow;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip_manager;
        private System.Windows.Forms.ToolStripMenuItem 도서관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사용자관리ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView_BookManager;
        private System.Windows.Forms.DataGridView dataGridView_UserManager;
        private System.Windows.Forms.StatusStrip statusStrip_now;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_now;
        private System.Windows.Forms.Timer timer_now;
    }
}

