using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio2
{
    public abstract class School
    {
        protected abstract string NameSchool { get; set; }
        protected abstract IList<Classroom> Classrooms { get; set; }
        public School()
        {

        }
        public abstract void ShowData();
        public abstract void RegisterData();
        public abstract void RegisterClassroom(Course course);
    }
}
