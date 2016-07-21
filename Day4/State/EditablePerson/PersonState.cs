using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EditablePerson
{
    public partial class Person
    {
        // nested class can only be seen by the parent class when private
        // nested class - inner class has access to private parts of parent when passed in the constructor e.g. person.name
        private abstract class PersonState
        {
            protected readonly Person innerPerson;

            protected PersonState(Person innerPerson)
            {
                this.innerPerson = innerPerson;
            }

            public virtual string Name
            {
                get { throw new NotImplementedException(); }
                set { throw new NotImplementedException(); }
            }

            public virtual int Age
            {
                get { throw new NotImplementedException(); }
                set { throw new NotImplementedException(); }
            }

            public virtual void Edit()
            {
                throw new NotImplementedException();
            }

            public virtual void Commit()
            {
                throw new NotImplementedException();
            }
        }
    }
}
