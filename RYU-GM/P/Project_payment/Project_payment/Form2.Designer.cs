namespace Project_payment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.dataGridView_Parking_Car_View_2 = new Sunny.UI.UIDataGridView();
            this.uiRadioButton1 = new Sunny.UI.UIRadioButton();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiRadioButton2 = new Sunny.UI.UIRadioButton();
            this.uiRadioButton4 = new Sunny.UI.UIRadioButton();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.parkingSpotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkingCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Parking_Car_View_2)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkingCarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.Location = new System.Drawing.Point(12, 9);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(113, 40);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "요금 정산";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiButton1
            // 
            this.uiButton1.BackColor = System.Drawing.SystemColors.Control;
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiButton1.Location = new System.Drawing.Point(409, 141);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton1.TabIndex = 1;
            this.uiButton1.Text = "확인";
            // 
            // dataGridView_Parking_Car_View_2
            // 
            this.dataGridView_Parking_Car_View_2.AllowUserToAddRows = false;
            this.dataGridView_Parking_Car_View_2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
            this.dataGridView_Parking_Car_View_2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Parking_Car_View_2.AutoGenerateColumns = false;
            this.dataGridView_Parking_Car_View_2.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView_Parking_Car_View_2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Parking_Car_View_2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Parking_Car_View_2.ColumnHeadersHeight = 32;
            this.dataGridView_Parking_Car_View_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Parking_Car_View_2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parkingSpotDataGridViewTextBoxColumn,
            this.carNumberDataGridViewTextBoxColumn,
            this.parkingTimeDataGridViewTextBoxColumn,
            this.result1DataGridViewTextBoxColumn});
            this.dataGridView_Parking_Car_View_2.DataSource = this.parkingCarBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Parking_Car_View_2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Parking_Car_View_2.EnableHeadersVisualStyles = false;
            this.dataGridView_Parking_Car_View_2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dataGridView_Parking_Car_View_2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.dataGridView_Parking_Car_View_2.Location = new System.Drawing.Point(16, 25);
            this.dataGridView_Parking_Car_View_2.Name = "dataGridView_Parking_Car_View_2";
            this.dataGridView_Parking_Car_View_2.ReadOnly = true;
            this.dataGridView_Parking_Car_View_2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Parking_Car_View_2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dataGridView_Parking_Car_View_2.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_Parking_Car_View_2.RowTemplate.Height = 23;
            this.dataGridView_Parking_Car_View_2.SelectedIndex = -1;
            this.dataGridView_Parking_Car_View_2.ShowGridLine = true;
            this.dataGridView_Parking_Car_View_2.Size = new System.Drawing.Size(493, 97);
            this.dataGridView_Parking_Car_View_2.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
            this.dataGridView_Parking_Car_View_2.Style = Sunny.UI.UIStyle.Custom;
            this.dataGridView_Parking_Car_View_2.TabIndex = 2;
            // 
            // uiRadioButton1
            // 
            this.uiRadioButton1.BackColor = System.Drawing.Color.Transparent;
            this.uiRadioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRadioButton1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiRadioButton1.Location = new System.Drawing.Point(16, 147);
            this.uiRadioButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButton1.Name = "uiRadioButton1";
            this.uiRadioButton1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiRadioButton1.Size = new System.Drawing.Size(140, 29);
            this.uiRadioButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiRadioButton1.TabIndex = 3;
            this.uiRadioButton1.Text = "현금/카드 결제";
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.uiGroupBox1.Controls.Add(this.uiRadioButton4);
            this.uiGroupBox1.Controls.Add(this.uiRadioButton2);
            this.uiGroupBox1.Controls.Add(this.dataGridView_Parking_Car_View_2);
            this.uiGroupBox1.Controls.Add(this.uiButton1);
            this.uiGroupBox1.Controls.Add(this.uiRadioButton1);
            this.uiGroupBox1.FillColor = System.Drawing.Color.Transparent;
            this.uiGroupBox1.FillColor2 = System.Drawing.Color.Transparent;
            this.uiGroupBox1.FillDisableColor = System.Drawing.Color.Transparent;
            this.uiGroupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiGroupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.uiGroupBox1.ForeDisableColor = System.Drawing.Color.Transparent;
            this.uiGroupBox1.Location = new System.Drawing.Point(13, 41);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.RectColor = System.Drawing.Color.Black;
            this.uiGroupBox1.Size = new System.Drawing.Size(522, 248);
            this.uiGroupBox1.Style = Sunny.UI.UIStyle.Custom;
            this.uiGroupBox1.TabIndex = 4;
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox1.Click += new System.EventHandler(this.uiGroupBox1_Click);
            // 
            // uiRadioButton2
            // 
            this.uiRadioButton2.BackColor = System.Drawing.Color.Transparent;
            this.uiRadioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRadioButton2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiRadioButton2.Location = new System.Drawing.Point(182, 147);
            this.uiRadioButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButton2.Name = "uiRadioButton2";
            this.uiRadioButton2.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiRadioButton2.Size = new System.Drawing.Size(117, 29);
            this.uiRadioButton2.Style = Sunny.UI.UIStyle.Custom;
            this.uiRadioButton2.TabIndex = 4;
            this.uiRadioButton2.Text = "이용 고객";
            // 
            // uiRadioButton4
            // 
            this.uiRadioButton4.BackColor = System.Drawing.Color.Transparent;
            this.uiRadioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRadioButton4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiRadioButton4.Location = new System.Drawing.Point(330, 147);
            this.uiRadioButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButton4.Name = "uiRadioButton4";
            this.uiRadioButton4.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiRadioButton4.Size = new System.Drawing.Size(78, 29);
            this.uiRadioButton4.Style = Sunny.UI.UIStyle.Custom;
            this.uiRadioButton4.TabIndex = 6;
            this.uiRadioButton4.Text = "VIP";
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.uiGroupBox2.Controls.Add(this.button7);
            this.uiGroupBox2.Controls.Add(this.button6);
            this.uiGroupBox2.Controls.Add(this.button5);
            this.uiGroupBox2.FillColor = System.Drawing.Color.Transparent;
            this.uiGroupBox2.FillColor2 = System.Drawing.Color.Transparent;
            this.uiGroupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiGroupBox2.Location = new System.Drawing.Point(260, 6);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.RectColor = System.Drawing.Color.Transparent;
            this.uiGroupBox2.Size = new System.Drawing.Size(265, 43);
            this.uiGroupBox2.Style = Sunny.UI.UIStyle.Custom;
            this.uiGroupBox2.TabIndex = 19;
            this.uiGroupBox2.Text = null;
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox2.Click += new System.EventHandler(this.uiGroupBox2_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button7.Location = new System.Drawing.Point(225, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(37, 34);
            this.button7.TabIndex = 15;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button6.Location = new System.Drawing.Point(121, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(46, 25);
            this.button6.TabIndex = 16;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button5.Location = new System.Drawing.Point(173, -3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 40);
            this.button5.TabIndex = 17;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // parkingSpotDataGridViewTextBoxColumn
            // 
            this.parkingSpotDataGridViewTextBoxColumn.DataPropertyName = "ParkingSpot";
            this.parkingSpotDataGridViewTextBoxColumn.HeaderText = "주차 번호";
            this.parkingSpotDataGridViewTextBoxColumn.Name = "parkingSpotDataGridViewTextBoxColumn";
            this.parkingSpotDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carNumberDataGridViewTextBoxColumn
            // 
            this.carNumberDataGridViewTextBoxColumn.DataPropertyName = "CarNumber";
            this.carNumberDataGridViewTextBoxColumn.HeaderText = "자동차 번호";
            this.carNumberDataGridViewTextBoxColumn.Name = "carNumberDataGridViewTextBoxColumn";
            this.carNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parkingTimeDataGridViewTextBoxColumn
            // 
            this.parkingTimeDataGridViewTextBoxColumn.DataPropertyName = "ParkingTime";
            this.parkingTimeDataGridViewTextBoxColumn.HeaderText = "주차 시작 시간";
            this.parkingTimeDataGridViewTextBoxColumn.Name = "parkingTimeDataGridViewTextBoxColumn";
            this.parkingTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.parkingTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // result1DataGridViewTextBoxColumn
            // 
            this.result1DataGridViewTextBoxColumn.DataPropertyName = "result1";
            this.result1DataGridViewTextBoxColumn.HeaderText = "결제 금액";
            this.result1DataGridViewTextBoxColumn.Name = "result1DataGridViewTextBoxColumn";
            this.result1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parkingCarBindingSource
            // 
            this.parkingCarBindingSource.DataSource = typeof(Project_payment.ParkingCar);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(551, 319);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.uiLabel1);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Parking_Car_View_2)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.parkingCarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIDataGridView dataGridView_Parking_Car_View_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkingSpotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn result1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource parkingCarBindingSource;
        private Sunny.UI.UIRadioButton uiRadioButton1;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIRadioButton uiRadioButton4;
        private Sunny.UI.UIRadioButton uiRadioButton2;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}