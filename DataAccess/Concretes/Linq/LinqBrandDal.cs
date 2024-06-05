using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstracts;
using Entities;

namespace DataAccess.Concretes.Linq
{
    public class LinqBrandDal:IBrandDal
    {
        private SqlConnection connection = new SqlConnection(@"Server=.\SQLEXPRESS;Database=RentACar;Trusted_Connection=True;");

        public DataTable GetAll()
        {
            ConnectionControl();
            // veri adaptörü
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Brands", connection);
            //veri tablosu
            DataTable dataTable = new DataTable();
            // veriyi doldur
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public void Add(Brand brand)
        {
            // Id hatası burda da var
            ConnectionControl();
            SqlCommand command = new SqlCommand("INSERT INTO Brands(BrandId, BrandName) VALUES(@brandId, @brandName)", connection);

            command.Parameters.AddWithValue("@brandId", brand.BrandId);
            command.Parameters.AddWithValue("@brandName", brand.BrandName);

            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Brands where BrandId=@id",connection);
            command.Parameters.AddWithValue("@id",id);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Update(Brand brand)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Brands set BrandName=@brandName where BrandId=@brandId", connection);
            command.Parameters.AddWithValue("@brandName", brand.BrandName);
            command.Parameters.AddWithValue("@brandId", brand.BrandId);
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