using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCar
{
    public class DataManager
    {
        public static List<ParkingCar> Cars = new List<ParkingCar>();
        static DataManager() 
        {
            Load();
        }
        public static void Load() 
        {
            try
            {
                DBHelper.selectQuery();
                Cars.Clear();
                foreach (DataRow item in DBHelper.ds.Tables[0].Rows)
                {
                    ParkingCar tempCar = new ParkingCar();
                    tempCar.ParkingSpot = int.Parse(item["parkingSpot"].ToString());
                    tempCar.CarNumber = item["CarNumber"].ToString();
                    tempCar.DriverName = item["driverName"].ToString();
                    tempCar.PhoneNumber = item["PhoneNumber"].ToString();
                    tempCar.ParkingTime = item["ParkingTime"].ToString() == 
                        "" ? new DateTime() : DateTime.Parse(item["parkingTime"].ToString());

                    Cars.Add(tempCar);
                }
            }
            catch (Exception ex)
            {
               
                System.Windows.Forms.MessageBox.Show(ex.Message);
                PrintLog(ex.StackTrace);
            }
        }
        public static void Save(
            int parkingSpot, string carNumber,
            string driverName, string phoneNumber,
            bool isRemove= false)
        {
            try
            {
                DBHelper.updateQuery(parkingSpot, carNumber, driverName, phoneNumber, isRemove);
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
                PrintLog(ex.StackTrace);
            }
        }
        public static void PrintLog(string contents)
        {
            DirectoryInfo di = new DirectoryInfo("ParkingHistory");
            if (!di.Exists)
            {
                di.Create();

            }
            using (StreamWriter writer = new StreamWriter("ParkingHistory\\ParkingHistory.txt", true))
            {
                writer.WriteLine(contents); 
            }
        }

    }
}
