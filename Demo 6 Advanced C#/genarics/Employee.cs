using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_6_Advanced_C_.genarics
{
    internal class Employee
    {
        public int id {  get; set; }
        public string? name { get; set; }
        public double salary { get; set; }

        public override string ToString()
        {
            return $"{id} :: {name} :: {salary}";


        } 

        public static bool operator == (Employee left, Employee right)
        {
           // return (left.id == right.id) && (left.name == right.name) && (left.salary == right.salary);
              return left.Equals(right) ;
        } 

        public static bool operator != (Employee left, Employee right)
        {
           return (left.id != right.id) || (left.name != right.name) || (left.salary != right.salary);

        }
        public override bool Equals(object obj)
        { Employee employee =(Employee?)obj;
            return  (this.id== employee?.id) && (this.name== employee?.name) && (this.salary== employee?.salary);

        }
        public override int GetHashCode()
        {
            return this.id.GetHashCode()+this.name?.GetHashCode()??0+this.salary.GetHashCode();
        }

    }

}
