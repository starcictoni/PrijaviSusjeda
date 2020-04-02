using System;
using System.Collections;
using System.Collections.Generic;

namespace PrijaviSusjeda.Data
{
    public class People
    {
        public static List<Person> people = new List<Person>();

        public bool AddPerson(Person person)
        {
            people.Add(person);
            return true;
        }
    }
}