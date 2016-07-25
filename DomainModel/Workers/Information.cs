using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Workers
{
    class Information
    {
        private int? Age { set; get; }
        private string Gender { set; get; }

        public Information(int? _age, string _gender)
        {
            if (_age > 0 || _age < 100)
            {
                Age = _age;
            }
            else Age = null;
            Gender = _gender;
        }

        public string GetGender() => Gender;

        public int? GetAge() => Age;
    }
}