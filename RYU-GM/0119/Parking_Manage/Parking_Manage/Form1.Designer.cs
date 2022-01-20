namespace Parking_Manage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_park_out = new System.Windows.Forms.Button();
            this.btn_park_in = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_phone_num = new System.Windows.Forms.TextBox();
            this.textBox_driver_name = new System.Windows.Forms.TextBox();
            this.textBox_carnum = new System.Windows.Forms.TextBox();
            this.textBox_parking_spot = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Parking_Car_View = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.textBox_spot_manager = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkingSpotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkingCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Parking_Car_View)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkingCarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_park_out);
            this.groupBox1.Controls.Add(this.btn_park_in);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_phone_num);
            this.groupBox1.Controls.Add(this.textBox_driver_name);
            this.groupBox1.Controls.Add(this.textBox_carnum);
            this.groupBox1.Controls.Add(this.textBox_parking_spot);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(291, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "주차/출차";
            // 
            // btn_park_out
            // 
            this.btn_park_out.Location = new System.Drawing.Point(189, 80);
            this.btn_park_out.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_park_out.Name = "btn_park_out";
            this.btn_park_out.Size = new System.Drawing.Size(75, 29);
            this.btn_park_out.TabIndex = 11;
            this.btn_park_out.Text = "출차";
            this.btn_park_out.UseVisualStyleBackColor = true;
            this.btn_park_out.Click += new System.EventHandler(this.btn_park_out_Click);
            // 
            // btn_park_in
            // 
            this.btn_park_in.Location = new System.Drawing.Point(189, 33);
            this.btn_park_in.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_park_in.Name = "btn_park_in";
            this.btn_park_in.Size = new System.Drawing.Size(75, 29);
            this.btn_park_in.TabIndex = 10;
            this.btn_park_in.Text = "주차";
            this.btn_park_in.UseVisualStyleBackColor = true;
            this.btn_park_in.Click += new System.EventHandler(this.btn_park_in_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "전화번호";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "차주이름";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "차량번호";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "공간번호";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_phone_num
            // 
            this.textBox_phone_num.Location = new System.Drawing.Point(64, 175);
            this.textBox_phone_num.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_phone_num.Name = "textBox_phone_num";
            this.textBox_phone_num.Size = new System.Drawing.Size(100, 23);
            this.textBox_phone_num.TabIndex = 5;
            // 
            // textBox_driver_name
            // 
            this.textBox_driver_name.Location = new System.Drawing.Point(64, 123);
            this.textBox_driver_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_driver_name.Name = "textBox_driver_name";
            this.textBox_driver_name.Size = new System.Drawing.Size(100, 23);
            this.textBox_driver_name.TabIndex = 4;
            // 
            // textBox_carnum
            // 
            this.textBox_carnum.Location = new System.Drawing.Point(64, 76);
            this.textBox_carnum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_carnum.Name = "textBox_carnum";
            this.textBox_carnum.Size = new System.Drawing.Size(100, 23);
            this.textBox_carnum.TabIndex = 3;
            // 
            // textBox_parking_spot
            // 
            this.textBox_parking_spot.Location = new System.Drawing.Point(64, 33);
            this.textBox_parking_spot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_parking_spot.Name = "textBox_parking_spot";
            this.textBox_parking_spot.Size = new System.Drawing.Size(100, 23);
            this.textBox_parking_spot.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView_Parking_Car_View);
            this.groupBox3.Location = new System.Drawing.Point(12, 277);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(770, 270);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "주차현황";
            // 
            // dataGridView_Parking_Car_View
            // 
            this.dataGridView_Parking_Car_View.AllowUserToAddRows = false;
            this.dataGridView_Parking_Car_View.AllowUserToDeleteRows = false;
            this.dataGridView_Parking_Car_View.AutoGenerateColumns = false;
            this.dataGridView_Parking_Car_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Parking_Car_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parkingSpotDataGridViewTextBoxColumn,
            this.carNumberDataGridViewTextBoxColumn,
            this.driverNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.parkingTimeDataGridViewTextBoxColumn,
            this.result});
            this.dataGridView_Parking_Car_View.DataSource = this.parkingCarBindingSource;
            this.dataGridView_Parking_Car_View.Location = new System.Drawing.Point(0, 21);
            this.dataGridView_Parking_Car_View.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_Parking_Car_View.Name = "dataGridView_Parking_Car_View";
            this.dataGridView_Parking_Car_View.ReadOnly = true;
            this.dataGridView_Parking_Car_View.RowTemplate.Height = 23;
            this.dataGridView_Parking_Car_View.Size = new System.Drawing.Size(871, 241);
            this.dataGridView_Parking_Car_View.TabIndex = 0;
            this.dataGridView_Parking_Car_View.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Parking_Car_View_CellClick);
            this.dataGridView_Parking_Car_View.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Parking_Car_View_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_del);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.textBox_spot_manager);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(362, 24);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(332, 125);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "주차공간 관리";
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(191, 71);
            this.btn_del.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 29);
            this.btn_del.TabIndex = 13;
            this.btn_del.Text = "공간삭제";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(191, 31);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 29);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "공간추가";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // textBox_spot_manager
            // 
            this.textBox_spot_manager.Location = new System.Drawing.Point(71, 34);
            this.textBox_spot_manager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_spot_manager.Name = "textBox_spot_manager";
            this.textBox_spot_manager.Size = new System.Drawing.Size(100, 23);
            this.textBox_spot_manager.TabIndex = 12;
            this.textBox_spot_manager.TextChanged += new System.EventHandler(this.textBox_spot_manager_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "공간번호";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(659, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(507, 194);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 14;
            this.button2.Text = "정산";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // result
            // 
            this.result.DataPropertyName = "result";
            this.result.HeaderText = "요금1";
            this.result.Name = "result";
            this.result.ReadOnly = true;
            // 
            // parkingSpotDataGridViewTextBoxColumn
            // 
            this.parkingSpotDataGridViewTextBoxColumn.DataPropertyName = "ParkingSpot";
            this.parkingSpotDataGridViewTextBoxColumn.HeaderText = "ParkingSpot";
            this.parkingSpotDataGridViewTextBoxColumn.Name = "parkingSpotDataGridViewTextBoxColumn";
            this.parkingSpotDataGridViewTextBoxColumn.ReadOnly = true;
            this.parkingSpotDataGridViewTextBoxColumn.Width = 125;
            // 
            // carNumberDataGridViewTextBoxColumn
            // 
            this.carNumberDataGridViewTextBoxColumn.DataPropertyName = "CarNumber";
            this.carNumberDataGridViewTextBoxColumn.HeaderText = "CarNumber";
            this.carNumberDataGridViewTextBoxColumn.Name = "carNumberDataGridViewTextBoxColumn";
            this.carNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.carNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // driverNameDataGridViewTextBoxColumn
            // 
            this.driverNameDataGridViewTextBoxColumn.DataPropertyName = "DriverName";
            this.driverNameDataGridViewTextBoxColumn.HeaderText = "DriverName";
            this.driverNameDataGridViewTextBoxColumn.Name = "driverNameDataGridViewTextBoxColumn";
            this.driverNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.driverNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // parkingTimeDataGridViewTextBoxColumn
            // 
            this.parkingTimeDataGridViewTextBoxColumn.DataPropertyName = "ParkingTime";
            this.parkingTimeDataGridViewTextBoxColumn.HeaderText = "ParkingTime";
            this.parkingTimeDataGridViewTextBoxColumn.Name = "parkingTimeDataGridViewTextBoxColumn";
            this.parkingTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.parkingTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // parkingCarBindingSource
            // 
            this.parkingCarBindingSource.DataSource = typeof(Parking_Manage.ParkingCar);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(692, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(942, 630);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Parking_Car_View)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkingCarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_park_out;
        private System.Windows.Forms.Button btn_park_in;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_phone_num;
        private System.Windows.Forms.TextBox textBox_driver_name;
        private System.Windows.Forms.TextBox textBox_carnum;
        private System.Windows.Forms.TextBox textBox_parking_spot;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView_Parking_Car_View;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox textBox_spot_manager;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource parkingCarBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkingSpotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private System.Windows.Forms.Button button3;
    }
}

