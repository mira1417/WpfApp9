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
using System.Windows.Shapes;

namespace WpfApp9
{
    /// <summary>
    /// Interaction logic for RecipeTwo.xaml
    /// </summary>
    public partial class RecipeTwo : Window
    {
        public RecipeTwo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TypeOfRecipes typeOfRecipes = new TypeOfRecipes();
            typeOfRecipes.Show();
            this.Close();
        }
    }
}
