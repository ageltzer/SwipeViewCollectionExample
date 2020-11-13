using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using SingleSwipeCollectionExample.Models;
using Xamarin.Forms;

namespace SingleSwipeCollectionExample.ViewModels
{
    public class SwipeViewCollectionViewModel : INotifyPropertyChanged
    {
        public SwipeViewCollectionViewModel()
        {
            Persons = new List<Person>
            {
                new Person { Name =  "Albert"},
                new Person { Name =  "Burak"},
                new Person { Name =  "Conny"},
                new Person { Name =  "Dolly"},
                new Person { Name =  "Erik"},
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private List<Person> _persons;
        public List<Person> Persons
        {
            get => _persons;
            set
            {
                if (_persons != value)
                {
                    _persons = value;
                    OnPropertyChanged();
                }
            }
        }

        private Command<Person> _deletePersonCommand;
        public Command<Person> DeletePersonCommand => _deletePersonCommand ??= new Command<Person>((person) => Persons.Remove(person));

        private Command<Person> _openItemChangedCommand;
        public Command<Person> OpenItemChangedCommand => _openItemChangedCommand ??= new Command<Person>(ChangeOpenPersonItem);
        private void ChangeOpenPersonItem(Person swipedPersonItem)
        {
            if (swipedPersonItem != null && swipedPersonItem.IsOpen)
            {
                if (Persons.Count < 2)
                    return;

                foreach (var person in Persons.Where(x => x != swipedPersonItem && x.IsOpen))
                {
                    person.IsOpen = false;
                }
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
