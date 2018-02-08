/*Couper Ebbs-Picken
 *Feb 8, 2018
 *Output
 *User inputs name and age, and we say Hi name, you are this many years old
 */ 
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

namespace u1_02_CouperEbbsOutput
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnShowGreeting_Click(object sender, RoutedEventArgs e)
        {
            lblOutput.Content = "Hello, " + entryFirstName.Text + " " +
                entryLastName.Text + "! \n" + "So, I see you are " + sliderAge.Value.ToString() + " years old.";
        }

        private void sliderAge_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
    }
