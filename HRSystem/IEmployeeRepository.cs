using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem
{
    public interface IEmployeeRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T model);
        void Update(T newEmp, int id);
        void Delete(int id);
    }
}
