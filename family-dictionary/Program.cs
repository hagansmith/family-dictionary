using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){
                {"name", "Krista"},
                {"age", "42"}
            });

            myFamily.Add("sister too", new Dictionary<string, string>(){
                {"name", "Sue"},
                {"age", "42"}
            });

            foreach (var familyMember in myFamily)
            {
                var relationship = familyMember.Key;
                var name = familyMember.Value["name"];
                var age = familyMember.Value["age"];

                Console.WriteLine($"{name} is my {relationship} and is {age} years old");
            }

            Console.ReadLine();
            
        }
    }
}
