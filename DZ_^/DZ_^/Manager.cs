using System;
using System.Collections.Generic;
using System.Text;

namespace DZ__
{
    class Manager : AbstractFarmerWorker
    {
        public Manager(string name, string surname, decimal salary, float experince, string department)
            : base(name, surname, salary, experince, department) { }
        public override string info() { return String.Format("Position: Manager\n Name: {0}\n Surname: {1}\n Salary: {2}\n Experience: {3}\n Department: {4}"
            , Name, Surname, Salary, Experience, Department); }
        public override bool equals(object o) => (o is Manager obj) && obj.Name == Name && obj.Surname == Surname
            && obj.Salary == Salary && obj.Experience == Experience && obj.Department == Department;
    }
}
