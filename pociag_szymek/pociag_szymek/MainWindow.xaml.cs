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

namespace pociag_szymek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Pociag pociag = new Pociag();
        bool czy_wagon;
        public MainWindow()
        {
            InitializeComponent();
            masa1.Visibility = Visibility.Hidden;
            masa2.Visibility = Visibility.Hidden;
            model1.Visibility = Visibility.Hidden;
            model2.Visibility = Visibility.Hidden;
            typ1.Visibility = Visibility.Hidden;
            typ2.Visibility = Visibility.Hidden;
            rodzaj1.Visibility = Visibility.Hidden;
            rodzaj2.Visibility = Visibility.Hidden;
            dodaj.Visibility = Visibility.Hidden;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e) //dodaj lokomotyew
        {
            czy_wagon = false;
            masa1.Visibility = Visibility.Visible;
            masa2.Visibility = Visibility.Visible;
            model1.Visibility = Visibility.Visible;
            model2.Visibility = Visibility.Visible;
            typ1.Visibility = Visibility.Hidden;
            typ2.Visibility = Visibility.Hidden;
            rodzaj1.Visibility = Visibility.Hidden;
            rodzaj2.Visibility = Visibility.Hidden;
            dodaj.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //dodaj wagon
        {
            czy_wagon = true;
            masa1.Visibility = Visibility.Visible;
            masa2.Visibility = Visibility.Visible;
            model1.Visibility = Visibility.Visible;
            model2.Visibility = Visibility.Visible;
            typ1.Visibility = Visibility.Visible;
            typ2.Visibility = Visibility.Visible;
            rodzaj1.Visibility = Visibility.Visible;
            rodzaj2.Visibility = Visibility.Visible;
            dodaj.Visibility = Visibility.Visible;

        }


        private void dodaj_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (int.Parse(masa2.Text.ToString()) >= 0)
                {
                    if (czy_wagon && masa2.Text != "" && model2.Text != "" && typ2.Text != "" && rodzaj2.Text != "")
                    {
                        if (typ2.Text == "osobowy")
                        {
                            pociag.DodajOsobowy(int.Parse(masa2.Text.ToString()), model2.Text.ToString(), rodzaj2.Text.ToString());
                        }
                        else if (typ2.Text == "towarowy")
                        {
                            pociag.DodajTowarowy(int.Parse(masa2.Text.ToString()), model2.Text.ToString(), rodzaj2.Text.ToString());
                        }
                    }
                    else if (!czy_wagon && masa2.Text != "" && model2.Text != "")
                    {
                        pociag.DodajLokomotywe(int.Parse(masa2.Text.ToString()), model2.Text.ToString());
                    }
                    else
                    {
                        MessageBox.Show("wypelnij wszystkie pola");
                    }
                }
                else
                {
                    MessageBox.Show("masa nie moze byc ujemna");

                }
            }
            catch (Exception E) { MessageBox.Show("bledne dane"); }
            textBlock.Text = pociag.Informacje();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (pociag.Mozejechac())
            {
                MessageBox.Show("pociag ok");
            }
            else
            {
                MessageBox.Show("lokomotywa ma za ciezko");
            }
        }

    }
}
