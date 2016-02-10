using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a register
            PersonRegister myFriends = new PersonRegister();

            //Create a few persons
            Person person1 = new Person();
            person1.Firstname = "Matti";
            person1.Lastname = "Mainio";
            person1.SocialSecurityNumber = "091209-235G";


            Person person2 = new Person { Firstname = "Kirsi", Lastname = "Kernel", SocialSecurityNumber = "893423-855O" };


            //Add persons to collection
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);


            //Get one person from register
            Person person3 = myFriends.GetPerson(1); // index - 0
            if (person3 != null)
            {
                Console.WriteLine(person3.ToString());
            } else
            {
                Console.WriteLine("Can not find person in that index.");
            }


            string sotu = "091209-235G4325";
            Console.WriteLine("Finding person with sotu: " + sotu);
            Person person4 = myFriends.FindPerson(sotu);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            } else
            {
                Console.WriteLine("Person can't be found with that sotu. \n");
            }

            myFriends.PrintData();
        }
    }
}
