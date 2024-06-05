using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstracts;
using Entities;

namespace DataAccess.Concretes.Linq
{
    public class LinqColorDal:IColorDal
    {
        private SqlConnection connection = new SqlConnection(@"Server=.\SQLEXPRESS;Database=RentACar;Trusted_Connection=True;");
        public DataTable GetAll()
        {
            ConnectionControl();
            // veri adaptörü
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Colors", connection);
            //veri tablosu
            DataTable dataTable = new DataTable();
            // veriyi doldur
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        private void ConnectionControl()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void Add(Color color)
        {

            // Id hatası var
            ConnectionControl();
            SqlCommand command1 = new SqlCommand("SET IDENTITY_INSERT Colors ON",connection);
            SqlCommand command = new SqlCommand("INSERT INTO Colors(ColorId, ColorName) VALUES(@colorId, @colorName)", connection);

            command.Parameters.AddWithValue("@colorId", color.ColorId);
            command.Parameters.AddWithValue("@colorName", color.ColorName);

            command1.ExecuteNonQuery();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Update(Color color)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Colors set ColorName=@name where ColorId=@colorId", connection);
            command.Parameters.AddWithValue("@name", color.ColorName);
            command.Parameters.AddWithValue("@colorId", color.ColorId);
            command.ExecuteNonQuery();

            connection.Close();
        }

        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Colors where ColorId=@id", connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}