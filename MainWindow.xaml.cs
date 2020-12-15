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

namespace Lab_17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Human> Humans = new List<Human> { };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            Human one = new Human(TextBoxName.Text, TextBoxLastName.Text, TextBoxPhone.Text,
                BoxCountry.Text, BoxAge.SelectedDate.ToString());
            if (GenderJ.IsChecked == true)
            {
                one.Gender = "M";
            }
            else
            {
                one.Gender = "J";
            }
            Humans.Add(one);
        }
    }
}
