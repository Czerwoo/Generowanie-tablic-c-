using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace test_z_generowaniem
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int[,] tab1 = new int[3, 3];
        int[,] tab2 = new int[3, 3];
        int[,] tab3 = new int[3, 3];
        bool bmin = true;
        bool bmax = true;
        bool badd = true;
        int mini = int.MaxValue;
        int maxi = int.MinValue;
        int mini2 = int.MaxValue;
        int maxi2 = int.MinValue;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random generator = new Random();
            mini = int.MaxValue;
            maxi = int.MinValue;
            mini2 = int.MaxValue;
            maxi2 = int.MinValue;
            ekran.Text = "Wartości dla pierwszej tablicy:\n";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tab1[i, j] = generator.Next(1, 21);
                    ekran.Text += tab1[i, j] + "     ";
                    if (tab1[i, j] < mini)
                    {
                        mini = tab1[i, j];
                    } else if (tab1[i,j] > maxi)
                    {
                        maxi = tab1[i, j];
                    }
                }
                ekran.Text += "\n";
            }
            ekran.Text += "Wartości dla drugiej tablicy:\n";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tab2[i, j] = generator.Next(1, 21);
                    ekran.Text += tab2[i, j] + "     ";
                    if (tab2[i, j] < mini2)
                    {
                        mini2 = tab2[i, j];
                    }
                    else if (tab2[i, j] > maxi2)
                    {
                        maxi2 = tab2[i, j];
                    }
                }
                ekran.Text += "\n";
                
            }
            ekran.Text += "\n";
            badd = false;
            bmin = false;
            bmax = false;

        }

        private void min_Click(object sender, RoutedEventArgs e)
        {
            if (bmin == false)
            {
                ekran.Text += "Min dla pierwszej tablicy wynosi: " + mini + "\n";
                ekran.Text += "Min dla drugiej tablicy wynosi: " + mini2 + "\n";
                bmin = true;
            }
        }

        private void max_Click(object sender, RoutedEventArgs e)
        {
            if (bmax == false)
            {
                ekran.Text += "Max dla pierwszej tablicy wynosi: " + maxi + "\n";
                ekran.Text += "Max dla drugiej tablicy wynosi: " + maxi2 + "\n";
                bmax = true;
            }
        }

        private void ekran_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void add_Click_1(object sender, RoutedEventArgs e)
        {
            if (badd == false)
            {
                ekran.Text += "Wynik dodawania dwóch tablic\n";
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        ekran.Text += (tab1[i, j] + tab2[i, j]) + "     ";
                    }
                    ekran.Text += "\n";

                }
                badd = true;
            }
        }
    }
}
