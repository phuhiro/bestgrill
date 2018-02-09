using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGrill.DB
{
    public interface IProvider
    {
         DataTable getAll();
         DataTable findById(int id);
    }
}
