using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Linq
{
    public class LinqRentalDal
    {
        private SqlConnection connection = new SqlConnection(@"Server=.\SQLEXPRESS;Database=RentACar;Trusted_Connection=True;");

        public void RentCar(Rental rental)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("INSERT INTO Rentals(UserId, CarId, RentalDate, ReturnDate) VALUES(@UserId, @CarId, @RentalDate, @ReturnDate)", connection);
            command.Parameters.AddWithValue("@UserId", rental.UserId);
            command.Parameters.AddWithValue("@CarId", rental.CarId);
            command.Parameters.AddWithValue("@RentalDate", rental.RentalDate);
            command.Parameters.AddWithValue("@ReturnDate", rental.ReturnDate);
            command.ExecuteNonQuery();

            connection.Close();
            UpdateCar(rental.CarId);
        }

        public void UpdateCar(int carId)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Cars set IsRented=1 where CarId=@carId",connection);
            command.Parameters.AddWithValue("CarId", carId);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeliverCar(int carId)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Cars set IsRented=null where CarId=@carId", connection);
            command.Parameters.AddWithValue("CarId", carId);
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