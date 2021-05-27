using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Student
    {
        //fields
        //First put in the fields this is the datatype with and underscore then the giving name
        // To keep everything protected we make this private and use camelCase
        private string _firstName;
        private string _lastName;
        private string _id;
        private float _gpa;

        //Properties it seems this is how the finds the objects that  I am making 
        // The get is the display i think and the set is the value so it will look like 
        // also this happens in a public string with the datatype and the giving name in UPPERCASE dont forget the brackets around the get and set no ; at the end of the public dataType X

        // public dataType X 
        //{ 
        //  get{ return _x;}
        //  set{ _x = value;}
        //}

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }



        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public float Gpa
        {
            get { return _gpa; }
            set { _gpa = value; }
        }
        //ctors not sure how to exsplan this but the are how the objects will show really ask more about this when you have time for now follow the Employee guild on _3Wednesday   ->Charity -> Employee.cs
        public Student(string firstName, string lastName, string id, float gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Gpa = gpa;
        }
        public Student()
        {

        }
        public override string ToString()
        {
            //return base.ToString();
            return string.Format("Student: \n" +
                "First Name: {0}\n" +
                "Last Name: {1}\n" +
                "Id: {2}\n" +
                "Gpa: {3:f}\n\n",
                FirstName, LastName, Id, Gpa);

        }
    }
}
