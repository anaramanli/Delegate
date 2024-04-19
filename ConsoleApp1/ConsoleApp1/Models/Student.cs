using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Student
    {
		private string _name;
        private string _surname;
        private int _age;
		private short _credits;
		static int count;
		private int _id;
		public int Id { get { return _id; } private set { }}
        public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public string Surname
		{
			get { return _surname; }
			set { _surname = value; }
		}
		
		public int Age
		{
			get { return _age; }
			set { _age = value; }
		}
        public Group Group { get; set; }
        public short Credits { get; set; }
        public Student(string name, string surname, int age, short credits, Group group)
        {
            Name = name;
			Surname = surname;
			Age = age;
			Credits = credits;
			count++;
			_id = count;
			Group = group;
        }

    }
}
