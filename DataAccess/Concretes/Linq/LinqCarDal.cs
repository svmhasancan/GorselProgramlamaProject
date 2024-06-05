﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DataAccess.Abstracts;
using Entities;

namespace DataAccess.Concretes.Linq
{
    public class LinqCarDal : ICarDal
    {
        private SqlConnection connection = new SqlConnection(@"Server=.\SQLEXPRESS;Database=RentACar;Trusted_Connection=True;");

        public DataTable GetAll()
        {
            string query = @"
                SELECT 
                    c.CarId,
                    b.BrandName,
                    col.ColorName,
                    c.Name,
                    c.ModelYear,
                    c.DailyPrice,
                    c.Description
                FROM 
                    Cars c
                JOIN 
                    Brands b ON c.BrandId = b.BrandId
                JOIN 
                    Colors col ON c.ColorId = col.ColorId";

            // veri adaptörü
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            //veri tablosu
            DataTable dataTable = new DataTable();
            // veriyi doldur
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public void Add(Car car)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("INSERT INTO Cars(BrandId, ColorId, Name, ModelYear, DailyPrice, Description) VALUES(@brandId, @colorId, @name, @modelYear, @dailyPrice, @description)", connection);

            command.Parameters.AddWithValue("@brandId", car.BrandId);
            command.Parameters.AddWithValue("@colorId", car.ColorId);
            command.Parameters.AddWithValue("@name", car.Name);
            command.Parameters.AddWithValue("@modelYear", car.ModelYear);
            command.Parameters.AddWithValue("@dailyPrice", car.DailyPrice);
            command.Parameters.AddWithValue("@description", car.Description);

            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Update(Car car)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Cars set Name=@name,BrandId=@brandId,ColorId=@colorId,ModelYear=@modelYear,DailyPrice=@dailyPrice,Description=@description where CarId=@carId",connection);
            command.Parameters.AddWithValue("@name", car.Name);
            command.Parameters.AddWithValue("@brandId", car.BrandId);
            command.Parameters.AddWithValue("@colorId", car.ColorId);
            command.Parameters.AddWithValue("@modelYear", car.ModelYear);
            command.Parameters.AddWithValue("@dailyPrice", car.DailyPrice);
            command.Parameters.AddWithValue("@description", car.Description);
            command.Parameters.AddWithValue("@carId", car.CarId);
            command.ExecuteNonQuery();

            connection.Close();
        }

        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Cars where CarId=@id",connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void ConnectionControl()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
    }
}