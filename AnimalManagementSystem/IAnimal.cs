using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalManagementSystem
{
    internal interface IAnimal
    {
        protected int ID { get; set; }
        protected string Name { get; set; }
        protected int Age { get; set; }
    }
}
