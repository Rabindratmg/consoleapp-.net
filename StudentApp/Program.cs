using System.IO;
using System.Text.Json;
using StudentApp;







StudentMethod studentmethod = new StudentMethod();
List<StudentModel> students = new List<StudentModel>();


int option;

do
{
    Console.WriteLine("1. Enter the student Info ");
    Console.WriteLine("2. Update the student Info");
    Console.WriteLine("3. Delete the student Info");
    Console.WriteLine("4. Display all the student Info");
    Console.Write("Choose and option from above:");
    option = int.Parse(Console.ReadLine());
    switch (option)
    {
        case 1:
            students = studentmethod.RegisterStudent(students);
            string jsonString = JsonSerializer.Serialize(students, new JsonSerializerOptions() { WriteIndented = true });
            using (StreamWriter saveFile = new StreamWriter(@"E:\Csharp\StudentInfo.json"))
            {
                saveFile.WriteLine(jsonString);
            }
            break;

        case 2:
            students = studentmethod.UpdateStudent(students);
            string updatestring = JsonSerializer.Serialize(students, new JsonSerializerOptions() { WriteIndented = true });
            using (StreamWriter updateFile = new StreamWriter(@"E:\Csharp\StudentInfo.json"))
            {
                updateFile.WriteLine(updatestring);
            }
            break;

        case 3:
            students = studentmethod.DeleteStudent(students);
            string deletestudent = JsonSerializer.Serialize(students, new JsonSerializerOptions() { WriteIndented = true });
            using (StreamWriter updateFile = new StreamWriter(@"E:\Csharp\StudentInfo.json"))
            {
                updateFile.WriteLine(deletestudent);
            }
            
            break;

        case 4:
            studentmethod.GetStudentDetails(students);
            break;

    }

}
while (option > 0 && option < 5);

