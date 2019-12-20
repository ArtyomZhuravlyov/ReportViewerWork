using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDL2
{
    public class StudentRepository
    {
        public static List<Student> GetStudents()

        {

            List<Student> list = new List<Student>

            {
                  new Student

                {

                    StudentID = 2,

                    Name = "Rohit2",

                    Address = "Uttar Pradesh, Allahabad",

                    Marks = 90,

                    DateofBirth = Convert.ToDateTime("4-Feb-1991")

                },

                  new Student

                {

                    StudentID = 2,

                    Name = "Rohit2",

                    Address = "Uttar Pradesh, Allahabad",

                    Marks = 99,

                    DateofBirth = Convert.ToDateTime("4-Feb-1991")

                },

                new Student

                {

                    StudentID = 1,

                    Name = "Rohit",

                    Address = "Uttar Pradesh, Allahabad",

                    Marks = 90,

                    DateofBirth = Convert.ToDateTime("4-Feb-1991")

                },

                new Student

                {

                    StudentID = 2,

                    Name = "Rahul",

                    Address = "Uttar Pradesh, Kanpur",

                    Marks = 85,

                    DateofBirth = Convert.ToDateTime("21-Oct-1991")

                },

                new Student

                {

                    StudentID = 3,

                    Name = "Rati",

                    Address = "Uttar Pradesh, Varanasi",

                    Marks = 80,

                    DateofBirth = Convert.ToDateTime("21-Dec-1991")

                },

                 new Student

                {

                    StudentID = 3,

                    Name = "Rati",

                    Address = "Uttar Pradesh, Varanasi",

                    Marks = 80,

                    DateofBirth = Convert.ToDateTime("21-Dec-1991")

                },

                  new Student

                {

                    StudentID = 3,

                    Name = "Rati",

                    Address = "Uttar Pradesh, Varanasi",

                    Marks = 80,

                    DateofBirth = Convert.ToDateTime("21-Dec-1991")

                },

                   new Student

                {

                    StudentID = 3,

                    Name = "Rati",

                    Address = "Uttar Pradesh, Varanasi888888888888888888888888888888888888888888",

                    Marks = 80,

                    DateofBirth = Convert.ToDateTime("21-Dec-1991")

                },

                new Student

                {

                    StudentID = 4,

                    Name = "Shweta",

                    Address = "Uttar Pradesh, Allahabad",

                    Marks = 75,

                    DateofBirth = Convert.ToDateTime("21-Nov-1991")

                },

                new Student

                {

                    StudentID = 5,

                    Name = "Arun",

                    Address = "Uttar Pradesh, Lucknow",

                    Marks = 70,

                    DateofBirth = Convert.ToDateTime("3-Mar-1989")

                }

            };



            return list;

        }

    }
}
