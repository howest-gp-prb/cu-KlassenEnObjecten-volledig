using System;
using System.Collections.Generic;
using System.Linq;
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
using Prb.ClassesAndObjects.CORE;

namespace Prb.ClassesAndObjects.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Car> cars;
        public MainWindow()
        {
            InitializeComponent();
            cars = new List<Car>();
        }

        private void btnAddNewCar_Click(object sender, RoutedEventArgs e)
        {
            string color = txtColor.Text;
            string carbrand = txtCarBrand.Text;
            decimal price = Convert.ToDecimal(txtPrice.Text);

            Car car = new Car();
            car.color = color;
            car.brand = carbrand;
            car.price = price;

            // OF via constructor:
            //Car car = new Car(carbrand, color, price);

            cars.Add(car);
            UpdateAutoLijst();
        }
        private void UpdateAutoLijst()
        {
            lstCars.Items.Clear();
            foreach (Car car in cars)
            {
                lstCars.Items.Add(car);
            }
        }

        private void lstCars_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Car selectedCar = (Car)lstCars.SelectedItem;

            txtCarBrand.Text = selectedCar.brand;
            txtColor.Text = selectedCar.color;
            txtPrice.Text = selectedCar.price.ToString();
        }
    }
}
