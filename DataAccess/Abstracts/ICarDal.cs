using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.Abstracts
{
    public interface ICarDal
    {
        DataTable GetAll();
        void Add(Car car);
        void Update(Car car);
        void Delete(int id);
    }
}