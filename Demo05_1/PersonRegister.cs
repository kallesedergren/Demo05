/* 
 * Copyright (C) KMS
 *
 * Part of Person Application project.
 *
 * Creation: 10.2.2016
 * Author: Kalle Sedergren
 *
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05_1
{
    /// <summary>
    /// This class holds peson objects in a collection.
    /// </summary>
    class PersonRegister
    {
        /// <summary>
        /// Person List stores person objects.
        /// </summary>
        private List<Person> persons; 

        /// <summary>
        /// Default constructor initializes a collection.
        /// </summary>
        public PersonRegister()
        {
            persons = new List<Person>();
        }

        /// <summary>
        /// Adds a new person to collection. 
        /// </summary>
        /// <param name="person">person to added</param>
        public void AddPerson(Person person)
        {
            persons.Add(person);
        }

        /// <summary>
        /// Returns a person to caller application. 
        /// </summary>
        /// <param name="index">person index in collection</param>
        /// <returns>person object</returns>

        public Person GetPerson(int index)
        {
            if (index < persons.Count)
            {
                return persons.ElementAt(index);
            } else
            {
                return null;
            }
        }

        public Person FindPerson(string socialSecurityNumber)
        {
            //for(int i=0;i<persons.Count;i++)

            foreach(Person person in persons)
            {
                //is sotus same
                if (socialSecurityNumber.Equals(person.SocialSecurityNumber))
                {
                    return person; //Person found with that sotu.
                }
            }
            return null; //Person not found.
        }

        public void PrintData()
        {
            Console.WriteLine("******************************* \n");
            Console.WriteLine("* My awesome collection * \n");
            Console.WriteLine("******************************* \n");
            foreach (Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }
            
        }
    }
}
