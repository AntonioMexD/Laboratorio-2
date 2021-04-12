using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio2
{
    public class SchoolStudent : IStudent, IKardex
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }
        public string Address { get; set; }
        public double Qualification { get; set; }
        public string Registration { get; set; }
        public string Description { get; set; }

        public void RegisterDataStudent()
        {
            Console.WriteLine("Ingrese nombre del estudiante: ");
            Name = Console.ReadLine();
            Console.WriteLine("Ingrese edad del estudiante: ");
            Age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese la matricula del estudiante: ");
            Registration = Console.ReadLine();
            Console.WriteLine("Ingrese domicilio del estudiante: ");
            Address = Console.ReadLine();
        }

        public void RegisterInfoStudent()
        {
            Console.WriteLine("Ingrese curso del estudiante: ");
            Grade = Console.ReadLine();
            Console.WriteLine("Ingrese la calificacion del estudiante: ");
            Qualification = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese la descripcion de la nota del estudiante: ");
            Description = Console.ReadLine();
        }

        public void ShowDataStudent()
        {
            Console.WriteLine("Nombre: " + Name);
            Console.WriteLine("Edad: " + Age);
            Console.WriteLine("Direccion: " + Address);
            Console.WriteLine("Matricula: " + Registration);
        }

        public void ShowInfoStudent()
        {
            Console.WriteLine("Curso: " + Grade);
            Console.WriteLine("Calificacion: " + Qualification);
            Console.WriteLine("Descripcion: " + Description);

        }

        public void RegisterSchoolStudent()
        {
            RegisterDataStudent();
            RegisterInfoStudent();
        }

        public void ShowSchoolStudent()
        {
            Console.WriteLine("-----Datos e informacion del estudiante-----");
            ShowDataStudent();
            ShowInfoStudent();
        }
    }
}
