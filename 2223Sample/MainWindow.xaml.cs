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

namespace _2223Sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Dont remove this
        /// </summary>
        public MainWindow()
        {
            // Dont remove this
            InitializeComponent();

            lblMessage.Content = "Please write your name in the text box!";
        }

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Hello!");
            string something = txtbSampleInput.Text;

            if(something.Length > 0)
            {
                //MessageBox.Show("Hello there " + something);
                lblMessage.Content = "Hello there " + something;
            }
            else
            {
                //MessageBox.Show("Please write your name in the text box!");
                lblMessage.Content = "Please write your name in the text box!";
            }

        }
    }
}
