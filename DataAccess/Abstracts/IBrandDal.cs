using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.Abstracts
{
    public interface IBrandDal
    {
        DataTable GetAll();
        void Add(Brand brand);
        void Update(Brand brand);
        void Delete(int id);
    }
}