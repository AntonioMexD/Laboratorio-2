using System;

namespace Laboratorio2
{
    class Program
    {
        public static void Main(string[] args)
        {
            SchoolRegistration schoolRegistration = new SchoolRegistration();
            schoolRegistration.RegisterData();
            schoolRegistration.Menu();
        }
    }
}
