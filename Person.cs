using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2v2
{

    public class Person
    {
        
        private string fname;
        private string lname;
        private System.DateTime bdate;

        public Person (string FirstName, string LastName, DateTime studentBDate)
        {
            fname = FirstName;
            lname = LastName;
            bdate = studentBDate;
        }
        
        public Person()
        {
            fname = "аАндрей";
            lname = "аАщеулов";
            bdate = new DateTime(2013, 12, 1);
        }

        public string Fname
        {
            get
            {
                return fname;
            }
        }
        public string Lname
        {
            get
            {
                return lname;
            }
        }

        DateTime BDate 
        {
            get
            {
                return bdate;
            }
           

        }
        int intBdate
        {
            get
            {
                return Convert.ToInt32(bdate);
            }
            set
            {
                bdate = Convert.ToDateTime(value);
            }
        }

        public string ToFullString()
        {
            return "Имя: " + fname + "\n" + "Фамилия: " + lname + "\n" + "Дата рождения: " + BDate;
        }

        public string ToShortString()
        {
            return "Имя: " + fname + "\n" + "Фамилия: " + lname;
        }




    }
}
