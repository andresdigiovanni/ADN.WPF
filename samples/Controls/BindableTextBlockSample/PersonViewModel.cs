using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace BindableTextBlockSample
{
    class PersonViewModel
    {
        private readonly Person _person = new Person();


        public ObservableCollection<Inline> Name
        {
            get => new ObservableCollection<Inline>()
            {
                new Run
                {
                    Text = _person.Name
                }
            };
        }

        public ObservableCollection<Inline> Gender
        {
            get => new ObservableCollection<Inline>()
            {
                new Run
                {
                    Text = _person.Gender
                }
            };
        }
    }
}
