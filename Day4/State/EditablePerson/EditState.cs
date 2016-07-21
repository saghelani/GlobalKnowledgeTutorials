using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EditablePerson
{
    public partial class Person
    {
        private class EditState : PersonState
        {
            public override int Age
            {
                get
                {
                    return innerPerson.age;
                }

                set
                {
                    innerPerson.age = value;
                }
            }

            public override string Name
            {
                get
                {
                    return innerPerson.name;
                }

                set
                {
                    innerPerson.name = value;
                }
            }

            public EditState(Person person) : base(person)
            {                
            }

            public override void Commit()
            {
                innerPerson.SetState(innerPerson.viewState);
            }
        }
    }
}
