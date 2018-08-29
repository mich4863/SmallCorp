using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallCorp.Entities
{
    public class Person : EntityBase
    {
        private string firstname;
        private string lastname;

        public Person(int id, string firstname, string lastname)
            : base(id)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        public Person(string firstname, string lastname) 
            : this(id: default, firstname, lastname) { }
        

        public string Firstname
        {
            get
            {
                return firstname;
            }

            set
            {
                firstname = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }

            set
            {
                lastname = value;
            }
        }
    }
}
