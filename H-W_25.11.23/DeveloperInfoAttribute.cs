using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_25._11._23
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class DeveloperInfoAttribute : Attribute
    {
        public string DeveloperName { get; }
        public string Date { get; }
        public string Company { get; set; }

        public DeveloperInfoAttribute(string developerName, string date, string company)
        {
            DeveloperName = developerName;
            Date = date;
            Company = company;
        }
    }
}
