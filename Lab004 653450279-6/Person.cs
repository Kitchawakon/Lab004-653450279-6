using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab004_653450279_6
{
    public class Person
    {
        private string name;
        private int age;
        private int birthYear;
        private int gpa;

        public Person(string name, int bYear)
        {
            this.name = name;
            this.birthYear = bYear;
            this.age = 2565 - bYear;
            this.gpa = 0;
        }
        public int getAge()
        {
            return this.age;
        }
        public string getName()
        {
            return this.name;
        }
        public int getGpa()
        {
            return this.gpa;
        }
    }
}
