using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS_Revision
{
    class PersonList
    {
        private List<PersonProp> personList;

        public PersonList()
        {
            personList = new List<PersonProp>();
        }

        public bool AddUniqueNamedPerson (PersonProp person)
        {
            foreach (PersonProp p in personList)
            {
                if (p.FirstName == person.FirstName && p.LastName == person.LastName)
                {
                    return false;
                }

                else
                {
                    continue;
                }

            }
            personList.Add(person);
            return true;
                
        }

        public List<PersonProp> GetPersonByLastName(string lastname)
        {
            List<PersonProp> newList = new List<PersonProp>();
            foreach (PersonProp p in personList)
            {
                if (p.LastName == lastname)
                    newList.Add(p);
            }
            return newList;
        }


        public int GetCountwithHeightAtorAbove(float height)
        {
            int count = 0;
            foreach (PersonProp p in personList)
            {
                if (p.Height == height)
                    count++;
            }

            return count;
        }

        public bool UpdatePersonByName(PersonProp person)
        {
            bool isFound = false;
            foreach (PersonProp p in personList)
            {
                if (p.FirstName == person.FirstName && p.LastName == person.LastName)
                {
                    isFound = true;
                    p.Height = person.Height;
                    p.Age = person.Age;
                    break;
                }
            }

            return isFound;
        }

        public List<PersonProp> GetAllPersons()
        {
            return personList;
        }

    }
}
