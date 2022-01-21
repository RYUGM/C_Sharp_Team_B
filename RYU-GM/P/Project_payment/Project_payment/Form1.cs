using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_payment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataManager.selectQuery();
            refreshScreen();
        }
        void refreshScreen()
        {
            dataGridView_Parking_Car_View.DataSource = null;
            //dataGridView_Parking_Car_View1.DataSource = null;
            try
            {
                if (DataManager.cars.Count > 0)
                {
                    dataGridView_Parking_Car_View.DataSource = DataManager.cars;
                    //dataGridView_Parking_Car_View1.DataSource = DataManager.cars;
                    textBox_parking_spot.Text = DataManager.cars[0].ParkingSpot.ToString();
                    textBox_spot_manager.Text = textBox_parking_spot.Text;
                    textBox_carnum.Text = DataManager.cars[0].CarNumber;
                    textBox_driver_name.Text = DataManager.cars[0].DriverName;
                    textBox_phone_num.Text = DataManager.cars[0].PhoneNumber;


                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_park_in_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_parking_spot.Text == "")
                {
                    MessageBox.Show("주차 공간 입력 하세요");
                    return;
                }
                if (textBox_carnum.Text == "")
                {
                    MessageBox.Show("차번호 입력");
                    return;
                }
                ParkingCar car = DataManager.selectQuery(int.Parse(textBox_parking_spot.Text));
                if (car.CarNumber != "")
                {
                    MessageBox.Show("이미 주차 됨");
                }
                else
                {
                    DataManager.executeQuery("update", textBox_parking_spot.Text, textBox_carnum.Text,
                        textBox_driver_name.Text, textBox_phone_num.Text);
                    DataManager.selectQuery();
                    refreshScreen();
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                throw;
            }
        }

        private void btn_park_out_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox_parking_spot.Text == "")
                {
                    MessageBox.Show("주차 공간 입력 하세요");
                    return;
                }

                ParkingCar car = DataManager.selectQuery(int.Parse(textBox_parking_spot.Text));
                if (car.CarNumber == "")
                {
                    MessageBox.Show("아직 차가 없습니다.");
                }
                else
                {
                    DataManager.executeQuery("update", textBox_parking_spot.Text, "", "", "");
                    DataManager.selectQuery();
                    refreshScreen();
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                throw;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DataManager.executeQuery("insert", textBox_spot_manager.Text);
            refreshScreen();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DataManager.executeQuery("delete", textBox_spot_manager.Text);
            refreshScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //시간당 천원 , 정산 버튼 
            try
            {
                if (textBox_parking_spot.Text == "")
                {
                    MessageBox.Show("주차 공간 입력 하세요");
                    //정산할 공간을 입력 안할시 출력
                    return;
                }


                else
                {
                    //update와 주차 공간 값을 가지고 executeQuery1로 이동
                    DataManager.executeQuery_charge(textBox_parking_spot.Text);

                    DataManager.selectQuery();
                    refreshScreen();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                throw;
            }
        }

        private void dataGridView_Parking_Car_View_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void uiLabel5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           this.WindowState= FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized){
                this.WindowState=FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Normal){
                this.WindowState = FormWindowState.Maximized;
            }
           
            
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_parking_spot.Text == "")
                {
                    MessageBox.Show("주차 공간 입력 하세요");
                    return;
                }
                if (textBox_carnum.Text == "")
                {
                    MessageBox.Show("차번호 입력");
                    return;
                }
                ParkingCar car = DataManager.selectQuery(int.Parse(textBox_parking_spot.Text));
                if (car.CarNumber != "")
                {
                    MessageBox.Show("이미 주차 됨");
                }
                else
                {
                    DataManager.executeQuery("update", textBox_parking_spot.Text, textBox_carnum.Text,
                        textBox_driver_name.Text, textBox_phone_num.Text);
                    DataManager.selectQuery();
                    refreshScreen();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                throw;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
    
}
