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

namespace RatonYTeclado
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void TextBoxes_GotFocus(object sender, RoutedEventArgs e)
        {
            FocoTextBox.Text = ((TextBox)sender).Name;
            
        }

        private void TextBoxes_LostFocus(object sender, RoutedEventArgs e)
        {
            FocoTextBox.Text = "";
        }

        private void TextBoxes_MouseEnter(object sender, MouseEventArgs e)
        {
            RatonSobreTextBox.Text = ((TextBox)sender).Name;
        }

        private void TextBoxes_MouseLeave(object sender, MouseEventArgs e)
        {
            RatonSobreTextBox.Text = "";
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ClickIzquierdoTextBox.Background = Brushes.Green;
        }

        private void Window_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ClickIzquierdoTextBox.Background = Brushes.White;
        }

        private void Window_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            ClickDerechoTextBox.Background = Brushes.Green;
        }

        private void Window_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            ClickDerechoTextBox.Background = Brushes.White;
        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
                TextBox2.Text = "Ayuda";
        }

        private void TextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.A || e.Key == Key.E || e.Key == Key.I || e.Key == Key.O || e.Key == Key.U)
                TextBox3.IsReadOnly = true;
            else
                TextBox3.IsReadOnly = false;
        }
    }
}
