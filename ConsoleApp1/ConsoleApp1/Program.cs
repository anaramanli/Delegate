using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group ab106 = new Group("AB106");
            Group ab105 = new Group("AB105");

            List<Student> students = new List<Student>();
            Student anar = new Student("Anar", "Amanli", 19, 540, ab106);
            Student kamil = new Student("Kamil", "Qehramanov", 20, 350, ab106);
            Student mike = new Student("Mike", "Tyson", 30, 150, ab105);
            Student jake = new Student("Jake", "Paul", 30, 150, ab105);
            Student jack = new Student("Elon", "musk", 29, 760, ab106);


            students.Add(anar);
            students.Add(kamil);
            students.Add(mike);
            students.Add(jack);



            /*bool CheckStudent = students.Any(student => student.Name.Contains("a"));
            Console.WriteLine(CheckStudent);*/

            students.FindAll(s => s.Group == ab106)
                .ForEach(s => Console.WriteLine(s.Id + " " + s.Name));
            Console.WriteLine();
            students.FindAll(s => s.Name.Contains("a")).ForEach(s => Console.WriteLine(s.Id + " " + s.Name));

            Console.WriteLine();
            students.OrderBy(s => s.Credits).ToList().ForEach(s => Console.WriteLine(s.Id + " " + s.Name + " " + s.Credits));

            Console.WriteLine();
            students.FindAll(s => s.Credits > 450).ForEach(s => Console.WriteLine(s.Id + " " + s.Name));

            Console.WriteLine($"All Sum: "+students.Sum(s => s.Credits).ToString());

            Console.WriteLine(students.Any(s => s.Age < 17));
            Console.WriteLine(students.Min(students=> students.Credits));
            Console.WriteLine(students.Max(s => s.Credits));

            Console.WriteLine(students.Any(s => s.Credits >200));

            var studentCheck=(students.FindAll(s=>s.Credits==students.Max(st=>st.Credits) 
                                                  && s.Age == students.Find(st=> st.Credits==students.Max(st2=>st2.Credits)).Age));
            foreach (var student in studentCheck)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Credits: {student.Credits}, Age: {student.Age}");
            }
            // Vicdanlilar ucun olan task
            Console.WriteLine();
            students.OrderBy(s => s.Group.Name)
                .ToList()
                .ForEach(s => Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Group: {s.Group.Name}"));
        }
    }
}
