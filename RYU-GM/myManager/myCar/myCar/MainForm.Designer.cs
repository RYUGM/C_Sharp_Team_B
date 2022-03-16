namespace myCar
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
            this.button_remove = new System.Windows.Forms.Button();
            this.button_parkingAdd = new System.Windows.Forms.Button();
            this.textBox_phonenum = new System.Windows.Forms.TextBox();
            this.textBox_driverName = new System.Windows.Forms.TextBox();
            this.textBox_carnum = new System.Windows.Forms.TextBox();
            this.textBox_spotNum = new System.Windows.Forms.TextBox();
            this.label_phonenum = new System.Windows.Forms.Label();
            this.label_driverName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_selectedLookUp = new System.Windows.Forms.Button();
            this.textBox_parkingSpot_lookUP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView_parkingManager = new System.Windows.Forms.DataGridView();
            this.listBox_logPring = new System.Windows.Forms.ListBox();
            this.label_now = new System.Windows.Forms.Label();
            this.timer_now = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_parkingManager)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_remove);
            this.groupBox1.Controls.Add(this.button_parkingAdd);
            this.groupBox1.Controls.Add(this.textBox_phonenum);
            this.groupBox1.Controls.Add(this.textBox_driverName);
            this.groupBox1.Controls.Add(this.textBox_carnum);
            this.groupBox1.Controls.Add(this.textBox_spotNum);
            this.groupBox1.Controls.Add(this.label_phonenum);
            this.groupBox1.Controls.Add(this.label_driverName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(37, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "주차/출차";
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(230, 71);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(75, 23);
            this.button_remove.TabIndex = 13;
            this.button_remove.Text = "출차";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_parkingAdd
            // 
            this.button_parkingAdd.Location = new System.Drawing.Point(230, 29);
            this.button_parkingAdd.Name = "button_parkingAdd";
            this.button_parkingAdd.Size = new System.Drawing.Size(75, 23);
            this.button_parkingAdd.TabIndex = 12;
            this.button_parkingAdd.Text = "주차";
            this.button_parkingAdd.UseVisualStyleBackColor = true;
            this.button_parkingAdd.Click += new System.EventHandler(this.button_parkingAdd_Click);
            // 
            // textBox_phonenum
            // 
            this.textBox_phonenum.Location = new System.Drawing.Point(83, 149);
            this.textBox_phonenum.Name = "textBox_phonenum";
            this.textBox_phonenum.Size = new System.Drawing.Size(100, 21);
            this.textBox_phonenum.TabIndex = 11;
            // 
            // textBox_driverName
            // 
            this.textBox_driverName.Location = new System.Drawing.Point(83, 109);
            this.textBox_driverName.Name = "textBox_driverName";
            this.textBox_driverName.Size = new System.Drawing.Size(100, 21);
            this.textBox_driverName.TabIndex = 10;
            // 
            // textBox_carnum
            // 
            this.textBox_carnum.Location = new System.Drawing.Point(83, 68);
            this.textBox_carnum.Name = "textBox_carnum";
            this.textBox_carnum.Size = new System.Drawing.Size(100, 21);
            this.textBox_carnum.TabIndex = 9;
            // 
            // textBox_spotNum
            // 
            this.textBox_spotNum.Location = new System.Drawing.Point(83, 29);
            this.textBox_spotNum.Name = "textBox_spotNum";
            this.textBox_spotNum.Size = new System.Drawing.Size(100, 21);
            this.textBox_spotNum.TabIndex = 8;
            this.textBox_spotNum.TextChanged += new System.EventHandler(this.textBox_spotNum_TextChanged);
            // 
            // label_phonenum
            // 
            this.label_phonenum.AutoSize = true;
            this.label_phonenum.Location = new System.Drawing.Point(23, 152);
            this.label_phonenum.Name = "label_phonenum";
            this.label_phonenum.Size = new System.Drawing.Size(53, 12);
            this.label_phonenum.TabIndex = 7;
            this.label_phonenum.Text = "전화번호";
            // 
            // label_driverName
            // 
            this.label_driverName.AutoSize = true;
            this.label_driverName.Location = new System.Drawing.Point(23, 112);
            this.label_driverName.Name = "label_driverName";
            this.label_driverName.Size = new System.Drawing.Size(53, 12);
            this.label_driverName.TabIndex = 6;
            this.label_driverName.Text = "차주이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "차량번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "공간 번호";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_refresh);
            this.groupBox2.Controls.Add(this.button_delete);
            this.groupBox2.Controls.Add(this.button_add);
            this.groupBox2.Controls.Add(this.button_selectedLookUp);
            this.groupBox2.Controls.Add(this.textBox_parkingSpot_lookUP);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(446, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 208);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "주차 공간 관리";
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(244, 141);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(140, 23);
            this.button_refresh.TabIndex = 18;
            this.button_refresh.Text = "전체 갱신";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(244, 101);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(140, 23);
            this.button_delete.TabIndex = 17;
            this.button_delete.Text = "공간 삭제";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(244, 66);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(140, 23);
            this.button_add.TabIndex = 16;
            this.button_add.Text = "공간 추가";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_selectedLookUp
            // 
            this.button_selectedLookUp.Location = new System.Drawing.Point(244, 29);
            this.button_selectedLookUp.Name = "button_selectedLookUp";
            this.button_selectedLookUp.Size = new System.Drawing.Size(140, 23);
            this.button_selectedLookUp.TabIndex = 15;
            this.button_selectedLookUp.Text = "해당 공간 조회";
            this.button_selectedLookUp.UseVisualStyleBackColor = true;
            this.button_selectedLookUp.Click += new System.EventHandler(this.button_selectedLookUp_Click);
            // 
            // textBox_parkingSpot_lookUP
            // 
            this.textBox_parkingSpot_lookUP.Location = new System.Drawing.Point(97, 29);
            this.textBox_parkingSpot_lookUP.Name = "textBox_parkingSpot_lookUP";
            this.textBox_parkingSpot_lookUP.Size = new System.Drawing.Size(100, 21);
            this.textBox_parkingSpot_lookUP.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "공간 번호";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView_parkingManager);
            this.groupBox3.Location = new System.Drawing.Point(37, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1173, 208);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "주차 현황";
            // 
            // dataGridView_parkingManager
            // 
            this.dataGridView_parkingManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_parkingManager.Location = new System.Drawing.Point(15, 20);
            this.dataGridView_parkingManager.Name = "dataGridView_parkingManager";
            this.dataGridView_parkingManager.RowTemplate.Height = 23;
            this.dataGridView_parkingManager.Size = new System.Drawing.Size(1152, 182);
            this.dataGridView_parkingManager.TabIndex = 19;
            this.dataGridView_parkingManager.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_parkingManager_CellClick);
            // 
            // listBox_logPring
            // 
            this.listBox_logPring.FormattingEnabled = true;
            this.listBox_logPring.ItemHeight = 12;
            this.listBox_logPring.Location = new System.Drawing.Point(37, 489);
            this.listBox_logPring.Name = "listBox_logPring";
            this.listBox_logPring.Size = new System.Drawing.Size(1173, 160);
            this.listBox_logPring.TabIndex = 2;
            // 
            // label_now
            // 
            this.label_now.AutoSize = true;
            this.label_now.Location = new System.Drawing.Point(35, 693);
            this.label_now.Name = "label_now";
            this.label_now.Size = new System.Drawing.Size(11, 12);
            this.label_now.TabIndex = 3;
            this.label_now.Text = "-";
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
            this.ClientSize = new System.Drawing.Size(1262, 729);
            this.Controls.Add(this.label_now);
            this.Controls.Add(this.listBox_logPring);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_parkingManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_parkingAdd;
        private System.Windows.Forms.TextBox textBox_phonenum;
        private System.Windows.Forms.TextBox textBox_driverName;
        private System.Windows.Forms.TextBox textBox_carnum;
        private System.Windows.Forms.TextBox textBox_spotNum;
        private System.Windows.Forms.Label label_phonenum;
        private System.Windows.Forms.Label label_driverName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_selectedLookUp;
        private System.Windows.Forms.TextBox textBox_parkingSpot_lookUP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView_parkingManager;
        private System.Windows.Forms.ListBox listBox_logPring;
        private System.Windows.Forms.Label label_now;
        private System.Windows.Forms.Timer timer_now;
    }
}

