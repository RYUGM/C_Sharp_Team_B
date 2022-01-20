namespace Project_payment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView_Parking_Car_View = new Sunny.UI.UIDataGridView();
            this.btn_park_in = new Sunny.UI.UIButton();
            this.textBox_parking_spot = new Sunny.UI.UITextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_park_out = new Sunny.UI.UIButton();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.textBox_phone_num = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.textBox_driver_name = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.textBox_carnum = new Sunny.UI.UITextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_del = new Sunny.UI.UIButton();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.btn_add = new Sunny.UI.UIButton();
            this.textBox_spot_manager = new Sunny.UI.UITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uiButton5 = new Sunny.UI.UIButton();
            this.button2 = new Sunny.UI.UIButton();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.parkingSpotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkingCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Parking_Car_View)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkingCarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1356, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 53);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_Parking_Car_View
            // 
            this.dataGridView_Parking_Car_View.AllowUserToAddRows = false;
            this.dataGridView_Parking_Car_View.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dataGridView_Parking_Car_View.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Parking_Car_View.AutoGenerateColumns = false;
            this.dataGridView_Parking_Car_View.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView_Parking_Car_View.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Parking_Car_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Parking_Car_View.ColumnHeadersHeight = 32;
            this.dataGridView_Parking_Car_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Parking_Car_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parkingSpotDataGridViewTextBoxColumn,
            this.carNumberDataGridViewTextBoxColumn,
            this.driverNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.parkingTimeDataGridViewTextBoxColumn,
            this.result1DataGridViewTextBoxColumn,
            this.result});
            this.dataGridView_Parking_Car_View.DataSource = this.parkingCarBindingSource;
            this.dataGridView_Parking_Car_View.EnableHeadersVisualStyles = false;
            this.dataGridView_Parking_Car_View.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dataGridView_Parking_Car_View.GridColor = System.Drawing.Color.Black;
            this.dataGridView_Parking_Car_View.Location = new System.Drawing.Point(369, 65);
            this.dataGridView_Parking_Car_View.Name = "dataGridView_Parking_Car_View";
            this.dataGridView_Parking_Car_View.ReadOnly = true;
            this.dataGridView_Parking_Car_View.RectColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Parking_Car_View.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridView_Parking_Car_View.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Parking_Car_View.RowTemplate.Height = 23;
            this.dataGridView_Parking_Car_View.SelectedIndex = -1;
            this.dataGridView_Parking_Car_View.ShowGridLine = true;
            this.dataGridView_Parking_Car_View.Size = new System.Drawing.Size(984, 537);
            this.dataGridView_Parking_Car_View.TabIndex = 1;
            this.dataGridView_Parking_Car_View.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Parking_Car_View_CellContentClick);
            // 
            // btn_park_in
            // 
            this.btn_park_in.BackColor = System.Drawing.Color.Black;
            this.btn_park_in.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_park_in.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btn_park_in.FillDisableColor = System.Drawing.Color.Transparent;
            this.btn_park_in.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_park_in.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_park_in.Location = new System.Drawing.Point(27, 220);
            this.btn_park_in.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_park_in.Name = "btn_park_in";
            this.btn_park_in.Size = new System.Drawing.Size(100, 35);
            this.btn_park_in.Style = Sunny.UI.UIStyle.Custom;
            this.btn_park_in.TabIndex = 2;
            this.btn_park_in.Text = "등록";
            this.btn_park_in.TipsForeColor = System.Drawing.Color.Black;
            this.btn_park_in.UseWaitCursor = true;
            this.btn_park_in.Click += new System.EventHandler(this.btn_park_in_Click);
            // 
            // textBox_parking_spot
            // 
            this.textBox_parking_spot.ButtonSymbol = 61761;
            this.textBox_parking_spot.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_parking_spot.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.textBox_parking_spot.Location = new System.Drawing.Point(122, 47);
            this.textBox_parking_spot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_parking_spot.Maximum = 2147483647D;
            this.textBox_parking_spot.Minimum = -2147483648D;
            this.textBox_parking_spot.MinimumSize = new System.Drawing.Size(1, 16);
            this.textBox_parking_spot.Name = "textBox_parking_spot";
            this.textBox_parking_spot.Size = new System.Drawing.Size(150, 29);
            this.textBox_parking_spot.TabIndex = 3;
            this.textBox_parking_spot.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.textBox_parking_spot.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.btn_park_out);
            this.groupBox1.Controls.Add(this.uiLabel4);
            this.groupBox1.Controls.Add(this.textBox_phone_num);
            this.groupBox1.Controls.Add(this.uiLabel3);
            this.groupBox1.Controls.Add(this.uiLabel2);
            this.groupBox1.Controls.Add(this.textBox_driver_name);
            this.groupBox1.Controls.Add(this.uiLabel1);
            this.groupBox1.Controls.Add(this.textBox_carnum);
            this.groupBox1.Controls.Add(this.btn_park_in);
            this.groupBox1.Controls.Add(this.textBox_parking_spot);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(36, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 274);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "주차 등록/정산";
            this.groupBox1.UseWaitCursor = true;
            // 
            // btn_park_out
            // 
            this.btn_park_out.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_park_out.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btn_park_out.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_park_out.ForeColor = System.Drawing.Color.Black;
            this.btn_park_out.Location = new System.Drawing.Point(172, 220);
            this.btn_park_out.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_park_out.Name = "btn_park_out";
            this.btn_park_out.Size = new System.Drawing.Size(100, 35);
            this.btn_park_out.Style = Sunny.UI.UIStyle.Custom;
            this.btn_park_out.TabIndex = 10;
            this.btn_park_out.Text = "정산";
            this.btn_park_out.UseWaitCursor = true;
            this.btn_park_out.Click += new System.EventHandler(this.btn_park_out_Click);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel4.Location = new System.Drawing.Point(23, 164);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(80, 23);
            this.uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel4.TabIndex = 9;
            this.uiLabel4.Text = "전화 번호";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.UseWaitCursor = true;
            // 
            // textBox_phone_num
            // 
            this.textBox_phone_num.ButtonSymbol = 61761;
            this.textBox_phone_num.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_phone_num.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.textBox_phone_num.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.textBox_phone_num.Location = new System.Drawing.Point(122, 164);
            this.textBox_phone_num.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_phone_num.Maximum = 2147483647D;
            this.textBox_phone_num.Minimum = -2147483648D;
            this.textBox_phone_num.MinimumSize = new System.Drawing.Size(1, 16);
            this.textBox_phone_num.Name = "textBox_phone_num";
            this.textBox_phone_num.Size = new System.Drawing.Size(150, 29);
            this.textBox_phone_num.Style = Sunny.UI.UIStyle.Custom;
            this.textBox_phone_num.TabIndex = 8;
            this.textBox_phone_num.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.textBox_phone_num.UseWaitCursor = true;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel3.Location = new System.Drawing.Point(35, 125);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(68, 23);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 7;
            this.uiLabel3.Text = "고객명";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.UseWaitCursor = true;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel2.Location = new System.Drawing.Point(23, 86);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(80, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 7;
            this.uiLabel2.Text = "자량 번호";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.UseWaitCursor = true;
            // 
            // textBox_driver_name
            // 
            this.textBox_driver_name.ButtonSymbol = 61761;
            this.textBox_driver_name.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_driver_name.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.textBox_driver_name.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.textBox_driver_name.Location = new System.Drawing.Point(122, 125);
            this.textBox_driver_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_driver_name.Maximum = 2147483647D;
            this.textBox_driver_name.Minimum = -2147483648D;
            this.textBox_driver_name.MinimumSize = new System.Drawing.Size(1, 16);
            this.textBox_driver_name.Name = "textBox_driver_name";
            this.textBox_driver_name.Size = new System.Drawing.Size(150, 29);
            this.textBox_driver_name.Style = Sunny.UI.UIStyle.Custom;
            this.textBox_driver_name.TabIndex = 6;
            this.textBox_driver_name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.textBox_driver_name.UseWaitCursor = true;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel1.Location = new System.Drawing.Point(23, 47);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(80, 23);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 5;
            this.uiLabel1.Text = "주차 번호";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.UseWaitCursor = true;
            // 
            // textBox_carnum
            // 
            this.textBox_carnum.ButtonSymbol = 61761;
            this.textBox_carnum.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox_carnum.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.textBox_carnum.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.textBox_carnum.Location = new System.Drawing.Point(122, 86);
            this.textBox_carnum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_carnum.Maximum = 2147483647D;
            this.textBox_carnum.Minimum = -2147483648D;
            this.textBox_carnum.MinimumSize = new System.Drawing.Size(1, 16);
            this.textBox_carnum.Name = "textBox_carnum";
            this.textBox_carnum.Size = new System.Drawing.Size(150, 29);
            this.textBox_carnum.Style = Sunny.UI.UIStyle.Custom;
            this.textBox_carnum.TabIndex = 6;
            this.textBox_carnum.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.textBox_carnum.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.btn_del);
            this.groupBox2.Controls.Add(this.uiLabel8);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.textBox_spot_manager);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(36, 434);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 168);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "주차 공간 관리";
            // 
            // btn_del
            // 
            this.btn_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_del.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btn_del.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.ForeColor = System.Drawing.Color.Black;
            this.btn_del.Location = new System.Drawing.Point(172, 113);
            this.btn_del.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(100, 35);
            this.btn_del.Style = Sunny.UI.UIStyle.Custom;
            this.btn_del.TabIndex = 10;
            this.btn_del.Text = "공간 삭제";
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel8.Location = new System.Drawing.Point(23, 47);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(80, 23);
            this.uiLabel8.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel8.TabIndex = 5;
            this.uiLabel8.Text = "주차번호";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_add
            // 
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btn_add.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(27, 113);
            this.btn_add.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 35);
            this.btn_add.Style = Sunny.UI.UIStyle.Custom;
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "공간 추가";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // textBox_spot_manager
            // 
            this.textBox_spot_manager.ButtonSymbol = 61761;
            this.textBox_spot_manager.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_spot_manager.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.textBox_spot_manager.Location = new System.Drawing.Point(122, 47);
            this.textBox_spot_manager.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_spot_manager.Maximum = 2147483647D;
            this.textBox_spot_manager.Minimum = -2147483648D;
            this.textBox_spot_manager.MinimumSize = new System.Drawing.Size(1, 16);
            this.textBox_spot_manager.Name = "textBox_spot_manager";
            this.textBox_spot_manager.Size = new System.Drawing.Size(150, 29);
            this.textBox_spot_manager.TabIndex = 3;
            this.textBox_spot_manager.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(46, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 2);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // uiButton5
            // 
            this.uiButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton5.FillColor = System.Drawing.Color.CornflowerBlue;
            this.uiButton5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiButton5.ForeColor = System.Drawing.Color.Black;
            this.uiButton5.Location = new System.Drawing.Point(1253, 626);
            this.uiButton5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton5.Name = "uiButton5";
            this.uiButton5.Size = new System.Drawing.Size(100, 35);
            this.uiButton5.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton5.TabIndex = 11;
            this.uiButton5.Text = "폼2";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FillColor = System.Drawing.Color.CornflowerBlue;
            this.button2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(1110, 626);
            this.button2.MinimumSize = new System.Drawing.Size(1, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.Style = Sunny.UI.UIStyle.Custom;
            this.button2.TabIndex = 11;
            this.button2.Text = "정산";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // result
            // 
            this.result.DataPropertyName = "result";
            this.result.HeaderText = "고객 수준";
            this.result.Name = "result";
            this.result.ReadOnly = true;
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel5.ForeColor = System.Drawing.Color.Navy;
            this.uiLabel5.Location = new System.Drawing.Point(12, 18);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(334, 56);
            this.uiLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel5.TabIndex = 12;
            this.uiLabel5.Text = "(주)KB 주차관리 프로그램";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.UseWaitCursor = true;
            this.uiLabel5.Click += new System.EventHandler(this.uiLabel5_Click);
            // 
            // parkingSpotDataGridViewTextBoxColumn
            // 
            this.parkingSpotDataGridViewTextBoxColumn.DataPropertyName = "ParkingSpot";
            this.parkingSpotDataGridViewTextBoxColumn.HeaderText = "주차 번호";
            this.parkingSpotDataGridViewTextBoxColumn.Name = "parkingSpotDataGridViewTextBoxColumn";
            this.parkingSpotDataGridViewTextBoxColumn.ReadOnly = true;
            this.parkingSpotDataGridViewTextBoxColumn.Width = 130;
            // 
            // carNumberDataGridViewTextBoxColumn
            // 
            this.carNumberDataGridViewTextBoxColumn.DataPropertyName = "CarNumber";
            this.carNumberDataGridViewTextBoxColumn.HeaderText = "차량 번호";
            this.carNumberDataGridViewTextBoxColumn.Name = "carNumberDataGridViewTextBoxColumn";
            this.carNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.carNumberDataGridViewTextBoxColumn.Width = 130;
            // 
            // driverNameDataGridViewTextBoxColumn
            // 
            this.driverNameDataGridViewTextBoxColumn.DataPropertyName = "DriverName";
            this.driverNameDataGridViewTextBoxColumn.HeaderText = "고객명";
            this.driverNameDataGridViewTextBoxColumn.Name = "driverNameDataGridViewTextBoxColumn";
            this.driverNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.driverNameDataGridViewTextBoxColumn.Width = 130;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "전화번호";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneNumberDataGridViewTextBoxColumn.Width = 130;
            // 
            // parkingTimeDataGridViewTextBoxColumn
            // 
            this.parkingTimeDataGridViewTextBoxColumn.DataPropertyName = "ParkingTime";
            this.parkingTimeDataGridViewTextBoxColumn.HeaderText = "주차시간 ";
            this.parkingTimeDataGridViewTextBoxColumn.Name = "parkingTimeDataGridViewTextBoxColumn";
            this.parkingTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.parkingTimeDataGridViewTextBoxColumn.Width = 190;
            // 
            // result1DataGridViewTextBoxColumn
            // 
            this.result1DataGridViewTextBoxColumn.DataPropertyName = "result1";
            this.result1DataGridViewTextBoxColumn.HeaderText = "요금";
            this.result1DataGridViewTextBoxColumn.Name = "result1DataGridViewTextBoxColumn";
            this.result1DataGridViewTextBoxColumn.ReadOnly = true;
            this.result1DataGridViewTextBoxColumn.Width = 130;
            // 
            // parkingCarBindingSource
            // 
            this.parkingCarBindingSource.DataSource = typeof(Project_payment.ParkingCar);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1413, 673);
            this.ControlBox = false;
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.uiButton5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_Parking_Car_View);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Parking_Car_View)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.parkingCarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Sunny.UI.UIDataGridView dataGridView_Parking_Car_View;
        private System.Windows.Forms.BindingSource parkingCarBindingSource;
        private Sunny.UI.UIButton btn_park_in;
        private Sunny.UI.UITextBox textBox_parking_spot;
        private System.Windows.Forms.GroupBox groupBox1;
        private Sunny.UI.UIButton btn_park_out;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox textBox_phone_num;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox textBox_driver_name;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox textBox_carnum;
        private System.Windows.Forms.GroupBox groupBox2;
        private Sunny.UI.UIButton btn_del;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UIButton btn_add;
        private Sunny.UI.UITextBox textBox_spot_manager;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIButton uiButton5;
        private Sunny.UI.UIButton button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkingSpotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn result1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private Sunny.UI.UILabel uiLabel5;
    }
}

