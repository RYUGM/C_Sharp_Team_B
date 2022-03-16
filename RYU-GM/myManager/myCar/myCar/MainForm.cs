using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myCar
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            try
            {
                textBox_spotNum.Text = DataManager.Cars[0].ParkingSpot.ToString();
                textBox_carnum.Text = DataManager.Cars[0].CarNumber.ToString();
                textBox_driverName.Text = DataManager.Cars[0].DriverName.ToString();
                textBox_phonenum.Text = DataManager.Cars[0].PhoneNumber.ToString();
                
            }
            catch (Exception ex)
            {
                WriteLog("초기 데이터 없음");
                
            }
            if (DataManager.Cars.Count > 0)
                dataGridView_parkingManager.DataSource = DataManager.Cars;

            button_add.Click += delegate (object sender, EventArgs e)
            {
                if(int.TryParse(textBox_parkingSpot_lookUP.Text,out int parkingSpot) == false)
                {
                    MessageBox.Show("숫자 입력");
                    return;
                }if(parkingSpot <= 0)
                {
                    MessageBox.Show("0이상의 숫자 입력");
                    return;
                }
                string contents = string.Empty;
                if(DataManager.Save("insert",parkingSpot,out contents))
                {
                    button_refresh.PerformClick();
                }
                WriteLog(contents);
            };

            button_delete.Click += (sender, e) =>
            {
               

             
                {
                    
                    if (int.TryParse(textBox_parkingSpot_lookUP.Text, out int parkingSpot) == false)
                    {
                        MessageBox.Show("숫자 입력");
                        return;
                    }
                    if (parkingSpot <= 0)
                    {
                        MessageBox.Show("0이상의 숫자 입력");
                        return;
                    }
                    string contents = string.Empty;
                    if (DataManager.Save("delete", parkingSpot, out contents))
                    {
                        button_refresh.PerformClick();
                    }
                    WriteLog(contents);
                };
            };
           
        }

        private void timer_now_Tick(object sender, EventArgs e)
        {
            label_now.Text =
                $"현재시간 : {DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}";
        }

        private void button_parkingAdd_Click(object sender, EventArgs e)
        {
            if (textBox_spotNum.Text.Trim() == "")
                MessageBox.Show("주차 공간 입력");
            else if (textBox_carnum.Text.Trim() == "")
            MessageBox.Show("차량 번호 입력");

            else
            {
                try
                {
                   
                    ParkingCar car = DataManager.Cars.Single((x) => x.ParkingSpot.ToString() == textBox_spotNum.Text);


                    //DataManager.Cars.Single (delegate (ParkingCar parkingCar)
                    //{ return parkingCar.ParkingSpot.ToString() == textBox_spotNum.Text; });

                    //  DataManager.Cars.Single((x) => x.ParkingSpot.ToString() == textBox_spotNum.Text);
                    
                    if(car.CarNumber.Trim() != "")
                        MessageBox.Show("이미 차가 있음");
                    else
                    {
                        car.CarNumber = textBox_carnum.Text;
                        car.DriverName = textBox_driverName.Text;
                        car.PhoneNumber = textBox_phonenum.Text;
                        car.ParkingTime = DateTime.Now;

                        dataGridView_parkingManager.DataSource = null;
                        dataGridView_parkingManager.DataSource = DataManager.Cars;

                        DataManager.Save(car.ParkingSpot,car.CarNumber,car.DriverName,car.PhoneNumber);
                        string contents = $"주차공간 {textBox_spotNum.Text}에 {textBox_carnum.Text}차량을 배치";
                        WriteLog(contents);
                    }

                }
                catch (Exception ex)
                {
                    string contents = $"주차공간 {textBox_spotNum.Text} 은 없습니다";
                    WriteLog(contents);
                  
                }
            }

        }
        private void WriteLog(string contents)
        {
            string logContents = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff")}]{contents}";
            DataManager.PrintLog(logContents);
            MessageBox.Show(contents);
            listBox_logPring.Items.Insert(0, logContents);

        }
        private void button_remove_Click(object sender, EventArgs e)
        {
            if(textBox_spotNum.Text.Trim()=="")
                MessageBox.Show("주차공간 입력!");
            else
            {
                try
                {
                    ParkingCar car = DataManager.Cars.Single((x) => x.ParkingSpot.ToString() == textBox_spotNum.Text);
                    string oldCar = car.CarNumber;
                    car.CarNumber = "";
                    car.DriverName = "";
                    car.PhoneNumber = "";
                    car.ParkingTime = new DateTime();

                    dataGridView_parkingManager.DataSource = null;
                    dataGridView_parkingManager.DataSource = DataManager.Cars;

                    DataManager.Save(int.Parse(textBox_spotNum.Text) , "", "", "", true);
                    string contents = $"주차공간 {textBox_spotNum.Text}에서 {oldCar}차가 출차 함";
                    WriteLog(contents);
                }
                catch (Exception ex)
                {
                    string contents = $"주차공간{textBox_spotNum.Text}는 없음";
                    WriteLog(contents);
                    
                }
              
            }
        }

        private void textBox_spotNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_parkingManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
              
                
                ParkingCar car = dataGridView_parkingManager.CurrentRow.DataBoundItem as ParkingCar;
                textBox_spotNum.Text = car.ParkingSpot.ToString();
                textBox_carnum.Text = car.CarNumber;
                textBox_driverName.Text = car.DriverName;
                textBox_phonenum.Text = car.PhoneNumber;

            } 
            catch (Exception ex)
            {

                
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            DataManager.Load();
            dataGridView_parkingManager.DataSource = null;
            if (DataManager.Cars.Count > 0)
                dataGridView_parkingManager.DataSource = DataManager.Cars;
        }

        private void button_selectedLookUp_Click(object sender, EventArgs e)
        {

            try
            {
            int parkingSpot = int.Parse(textBox_parkingSpot_lookUP.Text);
                string ParkingCar = lookUpParkingSpot(parkingSpot);
                string contents;
                if (ParkingCar != "주차공간없음")
                {
                    contents = $"해당 주차 공간은 존재하지 않습니다.";
                }
                else if(ParkingCar != "")
                {
                    
                    contents = $"주차공간 {parkingSpot}에 주차되어 있는 차는 {ParkingCar}입니다. ";
                }
                else
                {
                    contents = $"주차공간{parkingSpot}에 차가 없음";
                }
                 WriteLog(contents);
            }
            catch (Exception ex)
            {
                WriteLog($"{textBox_parkingSpot_lookUP.Text} 값 오류");
                
            }
        }

        private string lookUpParkingSpot(int parkingSpot)
        {
           foreach (var item in DataManager.Cars)
            {
                if(item.ParkingSpot == parkingSpot)
                    return item.CarNumber.ToString();
                                            
            }
            return "주차공간없음";
        }

        private void button_add_Click(object sender, EventArgs e)
        {

        }

        private void button_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
