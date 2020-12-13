using System;
using System.Collections.Generic;
using System.Text;

namespace DZ__
{
    abstract class AbstractFarmerWorker
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }
        public float Experience { get; set; }
        public string Department { get; set; }


        public AbstractFarmerWorker(string name,string surname,decimal salary,float experince,string department)
        {
            Name = name;
            Surname = surname;
            if (salary < 0)
            {
                throw new Exception("Некорректный ввод <0");
            }
            Salary = salary;
            if (experince < 0)
            {
                throw new Exception("Некорректный ввод <0");
            }
            Experience = experince;
            Department = department;
        }

        public abstract string info();
        public abstract bool equals(object o);

    }
}
