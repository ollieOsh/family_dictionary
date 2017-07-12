using System;
using System.Collections.Generic;

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

            myFamily.Add("broski", new Dictionary<string, string>(){ 
                {"name", "Tinie"},
                {"age", "29"}
            });

            foreach (KeyValuePair<string, Dictionary<string, string>> member in myFamily){
                // string name = "";
                // string age = "";
                // foreach(KeyValuePair<string, string> details in member.Value){
                //     if(details.Key == "name"){
                //         name = details.Value;
                //     }else{
                //         age = details.Value;
                //     }
                // }
                // Console.WriteLine($"{name} is my {member.Key} and is {age} years old");
                Console.WriteLine("{0} is my {1} and is {2} years old", member.Value["name"], member.Key, member.Value["age"]);
            }
            
        }
    }
}
