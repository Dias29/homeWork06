using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespaces
{
    public class Person
    {
        private string _fname;
        private string _lname;
        private string _nationality;
        private int _age;
        private double _growth;
        private double _weight;

        public Person(string fname, string lname, string nationality, int age, double growth, double weight)
        {
            _fname = fname;
            _lname = lname;
            _age = age;
            _nationality = nationality;
            _age = age;
            _growth = growth;
            _weight = weight;
        }

        public void SetFName(string fname)
        {
            _fname = fname;
        }

        public string GetFname()
        {
            return _fname;
        }

        public void SetLName(string lname)
        {
            _lname = lname;
        }
        public string GetLName()
        {
            return _lname;
        }

        public void SetNationality(string nationality)
        {
            _nationality = nationality;
        }
        public string GetNationality()
        {
            return _nationality;
        }

        public void SetAge(int age)
        {
            _age = age;
        }
        public int GetAge()
        {
            return _age;
        }

        public void SetGrowth(int growth)
        {
            _growth = growth;
        }
        public double GetGrowth()
        {
            return _growth;
        }

        public void SetWeight(int weight)
        {
            _weight = weight;
        }
        public double GetWeight()
        {
            return _weight;
        }



    }
}
