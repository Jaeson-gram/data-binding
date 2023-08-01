using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding.Models
{
    public class Person : INotifyPropertyChanged
    {
        private string name;
        private string phone;
        private string address;

        public string Name
        {
            get => name; set
            {
                name = value;


                //4.5 call the (event handler) method to let us edit the property
                OnPropertyChanged();
            }
        }

        public string Phone
        {
            get => phone; set
            {
                phone = value;

                //4.5 call the (event handler) method to let us edit the property
                OnPropertyChanged();
            }
        }
        public string Address 
        { 
            get => address; set
            {
                address = value;

                //4.5 call the (event handler) method to let us edit the property
                OnPropertyChanged();
            }
        }

        //4.3
        public event PropertyChangedEventHandler PropertyChanged;

        //4.4 The OnPropertyChanged Method. ** this method will be called by every property that wishes to be changed..
        protected void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
