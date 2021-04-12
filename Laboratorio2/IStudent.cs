using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio2
{
    public interface IStudent
    {
        string Name { get; set; }
        int Age { get; set; }
        string Address { get; set; }
        void RegisterDataStudent();
        void ShowDataStudent();
    }
}
