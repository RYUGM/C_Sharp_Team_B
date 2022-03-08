namespace _0308_liblary
{
    partial class BookManager
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
            this.groupBox_ = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_books = new System.Windows.Forms.DataGridView();
            this.textBox_lsbn = new System.Windows.Forms.TextBox();
            this.textBox_bookName = new System.Windows.Forms.TextBox();
            this.textBox_publisher = new System.Windows.Forms.TextBox();
            this.textBox_page = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_modify = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.groupBox_.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_books)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_
            // 
            this.groupBox_.Controls.Add(this.button_delete);
            this.groupBox_.Controls.Add(this.button_modify);
            this.groupBox_.Controls.Add(this.button_add);
            this.groupBox_.Controls.Add(this.label4);
            this.groupBox_.Controls.Add(this.label3);
            this.groupBox_.Controls.Add(this.label2);
            this.groupBox_.Controls.Add(this.label1);
            this.groupBox_.Controls.Add(this.textBox_page);
            this.groupBox_.Controls.Add(this.textBox_publisher);
            this.groupBox_.Controls.Add(this.textBox_bookName);
            this.groupBox_.Controls.Add(this.textBox_lsbn);
            this.groupBox_.Location = new System.Drawing.Point(12, 23);
            this.groupBox_.Name = "groupBox_";
            this.groupBox_.Size = new System.Drawing.Size(1266, 288);
            this.groupBox_.TabIndex = 0;
            this.groupBox_.TabStop = false;
            this.groupBox_.Text = "도서 추가/수정/삭제";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_books);
            this.groupBox2.Location = new System.Drawing.Point(12, 352);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1266, 288);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "도서 현황";
            // 
            // dataGridView_books
            // 
            this.dataGridView_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_books.Location = new System.Drawing.Point(6, 20);
            this.dataGridView_books.Name = "dataGridView_books";
            this.dataGridView_books.RowTemplate.Height = 23;
            this.dataGridView_books.Size = new System.Drawing.Size(1254, 262);
            this.dataGridView_books.TabIndex = 0;
            this.dataGridView_books.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_books_CellClick);
            // 
            // textBox_lsbn
            // 
            this.textBox_lsbn.Location = new System.Drawing.Point(99, 34);
            this.textBox_lsbn.Name = "textBox_lsbn";
            this.textBox_lsbn.Size = new System.Drawing.Size(1138, 21);
            this.textBox_lsbn.TabIndex = 0;
            // 
            // textBox_bookName
            // 
            this.textBox_bookName.Location = new System.Drawing.Point(99, 84);
            this.textBox_bookName.Name = "textBox_bookName";
            this.textBox_bookName.Size = new System.Drawing.Size(1138, 21);
            this.textBox_bookName.TabIndex = 1;
            // 
            // textBox_publisher
            // 
            this.textBox_publisher.Location = new System.Drawing.Point(99, 136);
            this.textBox_publisher.Name = "textBox_publisher";
            this.textBox_publisher.Size = new System.Drawing.Size(1138, 21);
            this.textBox_publisher.TabIndex = 2;
            // 
            // textBox_page
            // 
            this.textBox_page.Location = new System.Drawing.Point(99, 187);
            this.textBox_page.Name = "textBox_page";
            this.textBox_page.Size = new System.Drawing.Size(1138, 21);
            this.textBox_page.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "LSBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "도서이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "출판사";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "페이지";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(490, 235);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "추가";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_modify
            // 
            this.button_modify.Location = new System.Drawing.Point(595, 235);
            this.button_modify.Name = "button_modify";
            this.button_modify.Size = new System.Drawing.Size(75, 23);
            this.button_modify.TabIndex = 9;
            this.button_modify.Text = "수정";
            this.button_modify.UseVisualStyleBackColor = true;
            this.button_modify.Click += new System.EventHandler(this.button_modify_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(701, 235);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 10;
            this.button_delete.Text = "삭제";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // BookManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 716);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_);
            this.Name = "BookManager";
            this.Text = "BookManager";
            this.Load += new System.EventHandler(this.BookManager_Load);
            this.groupBox_.ResumeLayout(false);
            this.groupBox_.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_books)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_modify;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_page;
        private System.Windows.Forms.TextBox textBox_publisher;
        private System.Windows.Forms.TextBox textBox_bookName;
        private System.Windows.Forms.TextBox textBox_lsbn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_books;
    }
}