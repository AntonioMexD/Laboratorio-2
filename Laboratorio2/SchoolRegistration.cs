using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio2
{
    public class SchoolRegistration:School
    {
        protected override string NameSchool { get; set; }
        protected override IList<Classroom> Classrooms { get; set; }
        public string Principal { get; set; }
        public string Location { get; set; }

        public SchoolRegistration()
        {
            Classrooms = new List<Classroom>();
            Classroom course = new Course();
        }

        public override void ShowData()
        {
            Console.WriteLine("---Datos de la escuela---");
            Console.WriteLine("Nombre de la escuela: " + NameSchool);
            Console.WriteLine("Nombre del director: " + Principal);
            Console.WriteLine("Ubicacion de la escuela: " + Location);
        }

        public override void RegisterData()
        {
            Console.WriteLine("Ingrese nombre de la escuela");
            NameSchool = Console.ReadLine();
            Console.WriteLine("Ingrese nombre del director");
            Principal = Console.ReadLine();
            Console.WriteLine("Ingrese la ubicacion de la escuela");
            Location = Console.ReadLine();
        }

        public override void RegisterClassroom(Course course)
        {
            Classrooms.Add(course);
        }

        public void AddClassroom()
        {
            Classroom classroomCourse = new Course();
            classroomCourse.RegisterData();
            Classrooms.Add(classroomCourse);
        }
        public void ShowClassrooms()
        {
            foreach (var clasrooms in Classrooms)
            {
                clasrooms.ShowData();
            }             
        }
        public Classroom FindClassroom(string NameClassroom)
        {
            foreach(var classroom in Classrooms)
            {
                if (classroom.NameClassroom == NameClassroom)
                {
                    return classroom;
                }
            }
            return null;
        }
        public void ShowStudentsClassroom()
        {
            string NameClassroom;
            Console.WriteLine("Ingrese El Nombre De La Clase");
            NameClassroom = Console.ReadLine();
            Console.WriteLine("Estudiantes: ");
            var classroom = FindClassroom(NameClassroom);
            if (classroom != null)
            {
                classroom.ShowStudents();
            }
            else
            {
                Console.WriteLine("¡El salon de clases ingresado no existe en la base de datos!");
            }
        }
        public void AddStudentToClassroom()
        {
            string NameClassroom;
            Console.WriteLine("Ingrese El Nombre Del Salon De Clases");
            NameClassroom = Console.ReadLine();
            Console.WriteLine("Estudiantes: ");
            var classroom = FindClassroom(NameClassroom);
            if (classroom != null)
            {
                SchoolStudent schoolStudent = new SchoolStudent();
                schoolStudent.RegisterSchoolStudent();
                classroom.RegisterStudentToCourse(schoolStudent);
            }
            else
            {
                Console.WriteLine("¡El salon de clases ingresado no existe en la base de datos!");
            }
        }

        public void Menu()
        {
            int SelectOption;
            do
            {
                Console.WriteLine("---Menu Principal---");
                Console.WriteLine("1.- Mostrar Informacion Del Colegio");
                Console.WriteLine("2.- Añadir Salon De Clases");
                Console.WriteLine("3.- Mostrar Salones De Clases");
                Console.WriteLine("4.- Mostrar Estudiantes De Un Salon De Clases");
                Console.WriteLine("5.- Registrar Un Estudiante A Un Salon De Clases");
                SelectOption = Convert.ToInt16(Console.ReadLine());
                switch (SelectOption)
                {
                    case 1:
                        ShowData();
                        break;
                    case 2:
                        AddClassroom();
                        break;
                    case 3:
                        ShowClassrooms();
                        break;
                    case 4:
                        ShowStudentsClassroom();
                        break;
                    case 5:
                        AddStudentToClassroom();
                        break;
                    default:
                        break;
                }
            } while (SelectOption != 0);
        }
    }
}
