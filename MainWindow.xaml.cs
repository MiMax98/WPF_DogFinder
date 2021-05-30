using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace RasyPsow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DogSize _sizes;
        private bool? _firstDog;
        private bool? _active;

        private readonly List<Dog> _dogs;

        public MainWindow()
        {
            _sizes = DogSize.Undefined;
            _dogs = Dog.GetDogs();
            InitializeComponent();
        }

        private void btn_filtruj_Click(object sender, RoutedEventArgs e)
        {
            WriteResult(txt_wyszukaj.Text);
        }

        private void chBox_mały_Checked(object sender, RoutedEventArgs e)
        {
            _sizes ^= DogSize.Small;
        }

        private void chBox_sredni_Checked(object sender, RoutedEventArgs e)
        {
            _sizes ^= DogSize.Medium;
        }

        private void chBox_duzy_Checked(object sender, RoutedEventArgs e)
        {
            _sizes ^= DogSize.Large;
        }

        private void rdoTak_Checked(object sender, RoutedEventArgs e)
        {
            _firstDog = true;
        }

        private void rdoNie_Checked(object sender, RoutedEventArgs e)
        {
            _firstDog = false;
        }

        private void rdoDuza_Checked(object sender, RoutedEventArgs e)
        {
            _active = true;
        }

        private void rdoMala_Checked(object sender, RoutedEventArgs e)
        {
            _active = false;
        }

        private void txt_wyszukaj_TextChanged(object sender, TextChangedEventArgs e)
        {
            WriteResult(txt_wyszukaj.Text);
        }

        private void WriteResult(string filter)
        {
            var result = _dogs
                .Where(d => _sizes == DogSize.Undefined || (d.Size & _sizes) > 0)
                .Where(d => !_firstDog.HasValue || !_firstDog.Value || d.FirstDog)
                .Where(d => !_active.HasValue || d.Active == _active.Value);

            if (!string.IsNullOrEmpty(filter))
            {
                result = result.Where(d => d.Name.Contains(filter, StringComparison.OrdinalIgnoreCase));
            }
            Result_list.Items.Clear();
            foreach (var item in result)
            {
                Result_list.Items.Add(new ListViewItem
                {
                    Content = item.Name
                });
            }
        }
    }
}
