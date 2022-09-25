using StoreAppProjectÜPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StoreAppProjectÜPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged

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


        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            Products = new ObservableCollection<Product>
            {
                new Product
                {
                    Name="Dual Suspension",
                     Price=2022,
                     Path="Images/cycle.png"
                },

                new Product
                {
                    Name="Tennis Handle",
                     Price=100,
                     Path="Images/handle.png"
                },

                new Product
                {
                    Name="Samsung SSD",
                     Price=350,
                     Path="Images/SSD.png"
                },

                new Product
                {
                    Name="Messi T-Shirt",
                     Price=200,
                     Path="Images/T-Shirt.png"
                },

                 new Product
                {
                    Name="Iphone- 11 ",
                     Price=899,
                     Path="Images/Iphone11.png"
                },

                new Product
                {
                    Name="Car-Parts",
                     Price=4700,
                     Path="Images/CarParts.png"
                },

                  new Product
                {
                    Name="HP-LapTop",
                     Price=5499,
                     Path="Images/HPLaptop.png"
                },

                      new Product
                {
                    Name="microphone",
                     Price=349,
                     Path="Images/microphone.png"
                },
            };

            foreach (var item in Products)
            {
                var productUC = new ProductUC(item);
                wrappanel.Children.Add(productUC);

            }
        }

        public ObservableCollection<Product> Products { get; set; }
        public ObservableCollection<ProductUC> ProductsUC { get; set; }



    }
}
