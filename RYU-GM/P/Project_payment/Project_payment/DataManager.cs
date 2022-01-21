﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_payment
{
    public class DataManager
    {
        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
               "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
               "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
               "User Id=c##scott;Password=tiger;";
        //const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
        //      "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
        //      "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
        //      "User Id=c##RYU;Password=newruh;";
        public static OracleConnection OraConn = new OracleConnection(ORADB);

        public static List<ParkingCar> cars = new List<ParkingCar>();
        const string TABLE = "ParkingCar";

        static void ConnectDB()
        {
            try
            {
                OraConn.Open();
            }
            catch (Exception ex)
            {

                throw new Exception("DB연결 애러" + ex.Message +
                    "애러 위치" + Environment.NewLine + ex.StackTrace);
            }
        }

        public static void selectQuery()
        {
            ConnectDB();
            string sql;
            sql = "select * from " + TABLE + " order by to_number(parkingspot)";
            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = new OracleCommand();
            oda.SelectCommand.Connection = OraConn;
            oda.SelectCommand.CommandText = sql;

            DataSet ds = new DataSet();
            oda.Fill(ds, TABLE);

            cars.Clear();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                ParkingCar car = new ParkingCar();
                car.ParkingSpot = int.Parse(item["parkingspot"].ToString());
                car.CarNumber = item["carnumber"].ToString();
                car.DriverName = item["drivername"].ToString();
                car.PhoneNumber = item["phonenumber"].ToString();
                car.ParkingTime = item["parkingtime"].ToString() ==
                    "" ? new DateTime() : DateTime.Parse(item["parkingtime"].ToString());

                car.result1 = item["result1"].ToString()+"원";

                cars.Add(car);
            }
            OraConn.Close();
        }

        public static void selectQuery_Form2(int parkingspot)
        {
            ConnectDB();
            string sql;
            sql = $"select * from {TABLE} order by to_number({parkingspot})";
            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = new OracleCommand();
            oda.SelectCommand.Connection = OraConn;
            oda.SelectCommand.CommandText = sql;

            DataSet ds = new DataSet();
            oda.Fill(ds, TABLE);

            cars.Clear();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                ParkingCar car = new ParkingCar();
                car.ParkingSpot = int.Parse(item["parkingspot"].ToString());
                car.CarNumber = item["carnumber"].ToString();
                             
                car.ParkingTime = item["parkingtime"].ToString() ==
                    "" ? new DateTime() : DateTime.Parse(item["parkingtime"].ToString());

                car.result1 = item["result1"].ToString() + "원";

                cars.Add(car);
            }
            OraConn.Close();
        }


        public static ParkingCar selectQuery(int spot)
        {
            ConnectDB();
            string sql;
            sql = "select * from " + TABLE + " where parkingspot=" + spot + " order by to_number(parkingspot)";
            OracleDataAdapter oda = new OracleDataAdapter();
            oda.SelectCommand = new OracleCommand();
            oda.SelectCommand.Connection = OraConn;
            oda.SelectCommand.CommandText = sql;

            DataSet ds = new DataSet();
            oda.Fill(ds, TABLE);

            //cars.Clear();

            //foreach (DataRow item in ds.Tables[0].Rows)
            //{
            DataRow item = ds.Tables[0].Rows[0];
            ParkingCar car = new ParkingCar();
            car.ParkingSpot = int.Parse(item["parkingspot"].ToString());
            car.CarNumber = item["Carnumber"].ToString();
            car.DriverName = item["Drivername"].ToString();
            car.PhoneNumber = item["Phonenumber"].ToString();
            car.ParkingTime = item["Parkingtime"].ToString() ==
                "" ? new DateTime() : DateTime.Parse(item["parkingtime"].ToString());

            car.result1 = item["result1"].ToString()+"원";

            //cars.Add(car);
            //}
            OraConn.Close();
            return car;
        }

        static string Query(string menu, string parkingspot, string carnumber, string drivername, string phonenumber)
        {
            string query = "";
            switch (menu)
            {
                case "update":
                    query = $"update {TABLE} set " +
                        $"carnumber='{carnumber}',drivername='{drivername}'," +
                        $"phonenumber='{phonenumber}', parkingtime=sysdate , result=(select round(to_char(systimestamp ,'sssss')/60) FROM parkingcar WHERE parkingspot={parkingspot}) " +
                        $" where parkingspot={parkingspot}";
                    //,result =to_char(systimestamp, 'HH24')  
                    break;
                case "insert":
                    query = $"insert into {TABLE} (parkingspot) values({parkingspot})";
                    break;
                case "delete":
                    query = $"delete from {TABLE} where parkingspot = {parkingspot}";
                    break;

                default:
                    break;
            }
            return query;
        }
        static string Query(string parkingspot)
        {

            //여기서 DB 내부적으로 정산버튼을 누른 시간 - 주차 시작한시간 에 곱하기 1000을 해서 시간당 천원이 나옴
            //string query = $" {TABLE} set result1 = (select sum(((to_char(systimestamp,'HH24')+1)-result)*1000) from {TABLE} where parkingspot={parkingspot}) where parkingspot={parkingspot}";
            string query = $"update parkingcar set result1 = ((SELECT ROUND((TO_DATE(sysdate) - TO_DATE(parkingtime)) * 24)*1000 FROM parkingcar WHERE parkingspot ={ parkingspot})) WHERE parkingspot = { parkingspot }";
            


            return query;
        }
        public static void executeQuery(string menu, string parkingspot, string carnumber = null, string drivername = null, string phonenumber = null)
        {
            ConnectDB();
            string query = "";

            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = OraConn;
                query = Query(menu, parkingspot, carnumber, drivername, phonenumber);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                OraConn.Close();
                throw new Exception(query + "_" + ex.Message + "~~" + Environment.NewLine + ex.StackTrace);
            }

            OraConn.Close();

            selectQuery();
        }
        public static void executeQuery_charge(string parkingspot)
        {

            ConnectDB();
            string query = $"update parkingcar set result1 = " +
                $"round(((select trunc(((to_char(systimestamp ,'sssss')/60)-to_char(result)))  from parkingcar where parkingspot = {parkingspot})/ 60)*1000) WHERE parkingspot = {parkingspot}";


            try
            {

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = OraConn;
                //query = Query(parkingspot);
                //update와 주차 번호를 Query에 담고 실행
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                OraConn.Close();
                throw new Exception(ex.Message + "~~" + Environment.NewLine + ex.StackTrace);
                //query
            }

            OraConn.Close();

            selectQuery();
        }
        public static void executeQuery_refresh()
        {

            ConnectDB();
            string query = $"update parkingcar set result1 = round(((trunc((to_char(systimestamp ,'sssss')/60)-to_char(result)))/60)*1000)";

            try
            {

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = OraConn;
                //query = Query(parkingspot);
                //update와 주차 번호를 Query에 담고 실행
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                OraConn.Close();
                throw new Exception(ex.Message + "~~" + Environment.NewLine + ex.StackTrace);
                //query
            }

            OraConn.Close();

            selectQuery();
        }
    }

}
