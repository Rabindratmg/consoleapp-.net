using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class StudentMethod
    {
        public void GetStudentDetails(List<StudentModel> studentslist)
        {
            foreach (StudentModel student in studentslist)
            {
                Console.WriteLine(student.Name);
            }
        }

        public List<StudentModel> RegisterStudent(List<StudentModel> students)
        {
            StudentModel studentmodel = new StudentModel();
            Console.Write("Enter student id: ");
            studentmodel.Id = int.Parse(Console.ReadLine());
            Console.Write("Enter student name: ");
            studentmodel.Name = Console.ReadLine();
            Console.Write("Enter student address: ");
            studentmodel.Address = Console.ReadLine();
            students.Add(studentmodel);
            Console.WriteLine("Student with given info recored successfully");
            return students;


        }

        public List<StudentModel> DeleteStudent(List<StudentModel> studentslist)
        {
            int count = 0;
            Console.Write("Enter student id to delete: ");
            int id = int.Parse(Console.ReadLine());
            foreach (StudentModel student in studentslist)
            {
                if (id == student.Id)
                {
                    studentslist.Remove(student);
                    Console.WriteLine("Input id deleted sucessfully");
                    count = count + 1;
                    return studentslist;

                }
                


            }
            if (count==0)
            {
                Console.WriteLine("ID not found");
            }
            return null;
        }
        public List<StudentModel> UpdateStudent(List<StudentModel> studentslist)
        {
            int count = 0;
            Console.Write("Enter student id to update: ");
            int id = int.Parse(Console.ReadLine());
            foreach(StudentModel student in studentslist)
            {
                if(id == student.Id)
                {
                    Console.Write("Enter student name: ");
                    student.Name = Console.ReadLine();
                    Console.Write("Enter student address: ");
                    student.Address = Console.ReadLine();
                    Console.WriteLine("Updated successfully");
                    count = count + 1;
                    return studentslist;

                }
               

            }
            if(count == 0)
            {
                Console.WriteLine("Id not found");
            }
            return null;
        }
    }
}
