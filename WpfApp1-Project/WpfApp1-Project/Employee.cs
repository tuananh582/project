﻿using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1_Project
{
    public  class Employee
    {
        
            public ObjectId Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public decimal Salary { get; set; }
            public decimal product { get; set; }
            public decimal year { get; set; }
        public decimal BonusSalary => product * 1500;
        public decimal TotalSalary => (Salary * 12) + BonusSalary;

        public string Department { get; set; }
            public string City { get; set; }
        

    }
}
