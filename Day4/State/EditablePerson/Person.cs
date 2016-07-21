using System;
using System.Collections.Generic;
using System.Text;

namespace EditablePerson
{
    // partial allows you to define the same class name in different files and then complier stiches them together
    public partial class Person
    {
        private string name;

        private PersonState currentState;
        private EditState editState;
        private ViewState viewState;

        public Person()
        {
            currentState = null;
            editState = new EditState(this);
            viewState = new ViewState(this);
            SetState(viewState);
        }

        public string Name
        {
            get { return currentState.Name; }
            set { currentState.Name = value; }
        }
        
        private int age;

        public int Age
        {
            get { return currentState.Age; }
            set { currentState.Age = value; }
        }

        public override string ToString()
        {
            return String.Format("{0}, Aged {1} years", name, age);
        }

        public void Edit()
        {
            currentState.Edit();
        }

        public void Commit()
        {
            currentState.Commit();
        }

        private void SetState(PersonState newState)
        {
            currentState = newState;
        }
    }
}
