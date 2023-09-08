﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace POSPeachie
{

    

    public class DBConnection
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        private double dailysales;
        private int productline;
        private int stockonhand;
        private int critical;
        private string con;
        
        public string MyConnection()
        {
            con = @"Data Source=DESKTOP-GKNKFQR\MSSQLSERVER01;Initial Catalog=POS_DEMO_DB;Integrated Security=True";
            return con;
        }

      
        public double DailySales()
        {
            string sdate = DateTime.Now.ToShortDateString();
            cn = new SqlConnection();
            cn.ConnectionString = con;
            cn.Open();
            cm = new SqlCommand("select isnull(sum(total),0) as total from tblcart where sdate between '" + sdate + "' and '" + sdate + "' and status like 'sold'", cn);
            dailysales = double.Parse(cm.ExecuteScalar().ToString());
            cn.Close();
            return dailysales;
        }

        public double ProductLine()
        {
            cn = new SqlConnection();
            cn.ConnectionString = con;
            cn.Open();
            cm = new SqlCommand("select count(*) from tblproduct", cn);
            productline = int.Parse(cm.ExecuteScalar().ToString());
            cn.Close();
            return productline;
        }

        public double StockOnHand()
        {
            cn = new SqlConnection();
            cn.ConnectionString = con;
            cn.Open();
            cm = new SqlCommand("select isnull(sum(qty),0) as qty from tblproduct", cn);
            stockonhand = int.Parse(cm.ExecuteScalar().ToString());
            cn.Close();
            return stockonhand;
        }

        public double CriticalItems()
        {
            cn = new SqlConnection();
            cn.ConnectionString = con;
            cn.Open();
            cm = new SqlCommand("select count(*) from vwCriticalItems", cn);
            critical = int.Parse(cm.ExecuteScalar().ToString());
            cn.Close();
            return critical;
        }

        public double GetVal()
        {
            double vat=0;
            cn.ConnectionString=MyConnection();
            cn.Open();
            cm = new SqlCommand("select * from tblVat", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                vat = Double.Parse(dr["vat"].ToString());
            }
            dr.Close();
            cn.Close();
            return vat;

        }

        public string GetPassword(string user)
        {
            string password="";
            cn.ConnectionString = MyConnection();
            cn.Open();
            cm = new SqlCommand("select * from tblUser where username =@username", cn);
            cm.Parameters.AddWithValue("@username", user);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                password = dr["password"].ToString();
            }
           
            dr.Close();
            cn.Close();
            return password;
        }
    }
}
