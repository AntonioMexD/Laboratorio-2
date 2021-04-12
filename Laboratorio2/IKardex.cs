using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio2
{
    public interface IKardex
    {
        string Grade { get; set; }
        double Qualification { get; set; }
        string Description { get; set; }
        void RegisterInfoStudent();
        void ShowInfoStudent();
    }
}
