using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Person
    {
        protected DateTime _dataOfBirth;
        public string Name;
        private int _dollarsCount;

        int Age
        {
            get
            {
                return ((int)(DateTime.Now - _dataOfBirth).TotalDays) / 365;
            }
        }
    }
}
