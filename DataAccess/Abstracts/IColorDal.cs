using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.Abstracts
{
    public interface IColorDal
    {
        DataTable GetAll();
        void Add(Color color);
        void Update(Color color);
        void Delete(int id);
    }
}