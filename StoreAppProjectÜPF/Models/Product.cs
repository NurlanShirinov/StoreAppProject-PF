using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StoreAppProjectÜPF.Models
{
    public class Product:INotifyPropertyChanged
    {

       

        public event PropertyChangedEventHandler PropertyChanged;
         
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }

        private string path;

        public string Path
        {
            get { return path; }
            set { path = value; OnPropertyChanged(); }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; OnPropertyChanged(); }
        }

        private string star;

        public string Star
        {
            get { return star; }
            set { star = value; OnPropertyChanged(); }
        }

        private string plus;

        public string Plus
        {
            get { return plus; }
            set { plus = value; OnPropertyChanged(); }
        }



    }
}
