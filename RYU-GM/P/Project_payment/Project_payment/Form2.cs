using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_payment
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
                     

        }
        public void SetText(string data)
        {
           
            uiTextBox1.Text = data;
            button1_Click(null,null);
            
            
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

                    //뭔데 씨발 진짜 
                   


                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (uiTextBox1.Text == "")
                {
                    MessageBox.Show("주차 공간 입력 하세요");
                    return;
                }

                ParkingCar car = DataManager.selectQuery(int.Parse(uiTextBox1.Text));
                if (car.CarNumber == "")
                {
                    MessageBox.Show("아직 차가 없습니다.");
                }
                else
                {
                   

                    DataManager.executeQuery_refresh1(int.Parse(uiTextBox1.Text));
                                        
                    refreshScreen();
                   

                }
            }
            catch (Exception ex)
            {
               
                throw;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataManager.executeQuery_refresh();
            DataManager.selectQuery();



            refreshScreen();
                                
            Close();
            
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            uiTextBox2.Text = "현금/카드 결제";
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            uiTextBox2.Text = "VIP";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            uiTextBox2.Text = "영수증고객";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (uiTextBox1.Text == "")
                {
                    MessageBox.Show("주차 공간 입력 하세요");
                    return;
                }
                if(uiTextBox2.Text == "")
                {
                    MessageBox.Show("결제 방법 선택");
                    return;
                }

                ParkingCar car = DataManager.selectQuery(int.Parse(uiTextBox1.Text));
                if (car.CarNumber == "")
                {
                    MessageBox.Show("아직 차가 없습니다.");
                }
                else
                {
                    string result = DataManager.cars[0].result1;
                    string tempsrt = Regex.Replace(result, @"\D", "");
                    DataManager.executeQuery_form3_total(uiDatePicker1.Text, tempsrt);



                    DataManager.executeQuery("update", uiTextBox1.Text, "", "", "");
                   
                    DataManager.executeQuery_refresh1(int.Parse(uiTextBox1.Text));
                    refreshScreen();

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        
    }

        private void uiTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            DataManager.executeQuery_refresh();
            DataManager.selectQuery();
                                  

            refreshScreen();
            Close();    
        }

        private void uiGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (uiTextBox1.Text == "")
                {
                    MessageBox.Show("주차 공간 입력 하세요");
                    return;
                }

                ParkingCar car = DataManager.selectQuery(int.Parse(uiTextBox1.Text));
                if (car.CarNumber == "")
                {
                    MessageBox.Show("아직 차가 없습니다.");
                }
                else
                {


                    DataManager.executeQuery_refresh1(int.Parse(uiTextBox1.Text));

                    refreshScreen();


                }
            }
            catch (Exception ex)
            {

                throw;
            }
        
    }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (uiTextBox1.Text == "")
                {
                    MessageBox.Show("주차 공간 입력 하세요");
                    return;
                }
                if (uiTextBox2.Text == "")
                {
                    MessageBox.Show("결제 방법 선택");
                    return;
                }

                ParkingCar car = DataManager.selectQuery(int.Parse(uiTextBox1.Text));
                if (car.CarNumber == "")
                {
                    MessageBox.Show("아직 차가 없습니다.");
                }
                else
                {
                    string result = DataManager.cars[0].result1;
                    string tempsrt = Regex.Replace(result, @"\D", "");
                    DataManager.executeQuery_form3_total(uiDatePicker1.Text, tempsrt);



                    DataManager.executeQuery("update", uiTextBox1.Text, "", "", "");

                    DataManager.executeQuery_refresh1(int.Parse(uiTextBox1.Text));
                    refreshScreen();

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void uiRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            uiTextBox2.Text = "현금/카드 결제";
        }

        private void uiRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            uiTextBox2.Text = "VIP";
        }

        private void uiRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            uiTextBox2.Text = "영수증고객";
        }
    }
}
