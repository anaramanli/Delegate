using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group ab106 = new Group("AB106");
            Group ab105 = new Group("AB105");
            Student anar = new Student("Anar", "Amanli",19, 440,ab106);
            Student kamil = new Student("Kamil", "Qehramanov",20, 250, ab106);
            Student jack = new Student("Jacxk", "Amanli",19, 440,ab106);
            Student mike = new Student("mike", "Qehramanov",20, 250, ab106);

            List<Student> students = new List<Student>();
            students.Add(anar);
            students.Add(kamil);
            students.Add (jack);
            students.Add(mike);


            bool CheckStudent = students.Any(student => student.Name.Contains("a"));
            Console.WriteLine(CheckStudent);



        }
    }
}
