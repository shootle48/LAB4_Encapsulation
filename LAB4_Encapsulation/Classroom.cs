using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_Encapsulation
{
    public class Classroom
    {
        private string name;
        private List<Person> persons = new List<Person>();
        private List<double> GPAs = new List<double>();
        private List<string> names = new List<string>();

        public Classroom(string name)
        {
            this.name = name;
        }
        public void addPersonToClass(Person person)
        {
            this.persons.Add(person);
        }
        public string showAllPersoninClass()
        {
            string result = "";
            foreach (var person in this.persons)
            {
                result += person.name +"\t\t" + person.gpa+ "\r\n";
            }
            return result;
        }
        public void addGPAToClass()
        {
            foreach (var person in persons)
            {
                GPAs.Add(person.gpa);
                names.Add(person.name);
            }
        }
        public int showTotalAgeinClass()
        {
            int Result = 0;
            foreach (var person in this.persons)
            {
                Result = person.birthYear;
            }
            return Result;
        }

        public double showGPXMax()
        {
            double max = GPAs.Max();            
            return max;
        }

        public double showGPXMin()
        {
            double min = GPAs.Min();
            return min;
        }

        public double showGPXAvg()
        {
            double avg = GPAs.Average();
            return avg;
        }

        public string showNameMax()
        {
            return names[GPAs.IndexOf(GPAs.Max())];
        }

        public string showNameMin()
        {
            return names[GPAs.IndexOf(GPAs.Min())];
        }
    } 
}
