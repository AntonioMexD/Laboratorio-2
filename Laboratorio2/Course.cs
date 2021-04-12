using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio2
{
    public class Course:Classroom
    {
        public Course()
        {
            NameClassroom = "";
            Teacher = "";
        }

        public override void RegisterData()
        {
            Console.WriteLine("Ingrese codigo del salon de clases");
            Code = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre de la clase");
            NameClassroom = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del profesor(a)");
            Teacher = Console.ReadLine();
        }
        public override void RegisterStudents()
        {
            SchoolStudent schoolStudent = new SchoolStudent();
            Console.Clear();
            Console.WriteLine("Ingrese datos del nuevo estudiante");
            schoolStudent.RegisterSchoolStudent();
            students.Add(schoolStudent);
        }
        public override void ShowData()
        {
            base.ShowData();
            Console.WriteLine("Clase: "+NameClassroom);
            Console.WriteLine("Profesor: " + Teacher);
        }
        public override void ShowStudents()
        {
            foreach(var student in students)
            {
                student.ShowDataStudent();
            }
        }
        public override void RegisterStudentToCourse(SchoolStudent schoolStudent)
        {
            students.Add(schoolStudent);
        }

    }
}
