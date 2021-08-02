using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PkuEmployee.Model
{
    public interface INameble
    {
        int Id { get; set; }
        string Name { get; set; }
    }
}
