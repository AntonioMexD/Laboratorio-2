using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio2
{
    public class Classroom
    {
        public string Code { get; set; }
        public string NameClassroom { get; set; }
        public string Teacher { get; set; }
        public IList<SchoolStudent> students;
        public Classroom()
        {
            Code = "";
            students = new List<SchoolStudent>();
        }

        public virtual void RegisterData()
        {
            
        }

        public virtual void ShowData()
        {
            Console.WriteLine("---Informacion de la clase---");
            Console.WriteLine("-"+NameClassroom+"-");
        }

        public virtual void RegisterStudents()
        {

        }
        public virtual void ShowStudents()
        {

        }
        public virtual void RegisterStudentToCourse(SchoolStudent schoolStudent)
        {

        }

    }
}
