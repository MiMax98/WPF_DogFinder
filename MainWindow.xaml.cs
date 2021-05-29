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
            _dogs = new List<Dog>
            {
                new Dog { Name = "Aidi", Size=DogSize.Medium, FirstDog=false, Active=false},
                new Dog { Name = "Akita Inu", Size=DogSize.Large, FirstDog=false, Active=false},
                new Dog { Name = "Ariegeois", Size=DogSize.Medium, FirstDog=true, Active=false},
                new Dog { Name = "Barbet", Size=DogSize.Medium, FirstDog=true, Active=false},
                new Dog { Name = "Basenji", Size=DogSize.Small, FirstDog=true, Active=false},
                new Dog { Name = "Beagle", Size=DogSize.Medium, FirstDog=true, Active=false},
                new Dog { Name = "Bernardyn", Size=DogSize.Large, FirstDog=true, Active=false},
                new Dog { Name = "Billy", Size=DogSize.Large, FirstDog=true, Active=true},
                new Dog { Name = "Boerboel", Size=DogSize.Large, FirstDog=false, Active=false},
                new Dog { Name = "Bokser", Size=DogSize.Medium, FirstDog=true, Active=true},
                new Dog { Name = "Bolończyk", Size=DogSize.Small, FirstDog=true, Active=false},
                new Dog { Name = "Broholmer", Size=DogSize.Large, FirstDog=true, Active=false},
                new Dog { Name = "Bulterier", Size=DogSize.Medium, FirstDog=false, Active=true},
                new Dog { Name = "Chihuahua", Size=DogSize.Small, FirstDog=true, Active=false},
                new Dog { Name = "Chow chow", Size=DogSize.Medium, FirstDog=false, Active=false},
                new Dog { Name = "Cursinu", Size=DogSize.Large, FirstDog=true, Active=false},
                new Dog { Name = "Doberman", Size=DogSize.Large, FirstDog=true, Active=true},
                new Dog { Name = "Drever", Size=DogSize.Small, FirstDog=true, Active=true},
                new Dog { Name = "Dunker", Size=DogSize.Medium, FirstDog=true, Active=false},
                new Dog { Name = "Eurasier", Size=DogSize.Medium, FirstDog=true, Active=false},
                new Dog { Name = "Greyhound", Size=DogSize.Large, FirstDog=false, Active=false},
                new Dog { Name = "Harrier", Size=DogSize.Medium, FirstDog=true, Active=false},
                new Dog { Name = "Hawańczyk", Size=DogSize.Small, FirstDog=true, Active=false},
                new Dog { Name = "Hokkaido", Size=DogSize.Medium, FirstDog=false, Active=false},
                new Dog { Name = "Hovawart", Size=DogSize.Large, FirstDog=true, Active=false},
                new Dog { Name = "Hygenhund", Size=DogSize.Medium, FirstDog=true, Active=false},
                new Dog { Name = "Jamnik", Size=DogSize.Small, FirstDog=true, Active=false},
                new Dog { Name = "Jämthund", Size=DogSize.Large, FirstDog=false, Active=false},
                new Dog { Name = "Jindo", Size=DogSize.Medium, FirstDog=false, Active=false},
                new Dog { Name = "Kai", Size=DogSize.Medium, FirstDog=true, Active=false},
                new Dog { Name = "Kelpie", Size=DogSize.Medium, FirstDog=true, Active=true},
                new Dog { Name = "Kishu", Size=DogSize.Medium, FirstDog=true, Active=false},
                new Dog { Name = "Komondor", Size=DogSize.Large, FirstDog=false, Active=false},
                new Dog { Name = "Kuvasz", Size=DogSize.Large, FirstDog=false, Active=false},
                new Dog { Name = "Landseer", Size=DogSize.Large, FirstDog=false, Active=false},
                new Dog { Name = "Mops", Size=DogSize.Small, FirstDog=true, Active=false},
                new Dog { Name = "Mudi", Size=DogSize.Medium, FirstDog=true, Active=true},
                new Dog { Name = "Pekińczyk", Size=DogSize.Small, FirstDog=true, Active=false},
                new Dog { Name = "Pointer", Size=DogSize.Medium, FirstDog=true, Active=false},
                new Dog { Name = "Poitevin", Size=DogSize.Large, FirstDog=true, Active=false},
                new Dog { Name = "Pudel", Size=DogSize.Medium, FirstDog=true, Active=true},
                new Dog { Name = "Puli", Size=DogSize.Medium, FirstDog=true, Active=false},
                new Dog { Name = "Pumi", Size=DogSize.Medium, FirstDog=true, Active=true},
                new Dog { Name = "Shar pei", Size=DogSize.Medium, FirstDog=false, Active=false},
                new Dog { Name = "Shiba inu", Size=DogSize.Small, FirstDog=true, Active=true},
                new Dog { Name = "Shih tzu", Size=DogSize.Small, FirstDog=true, Active=false},
                new Dog { Name = "Shikoku", Size=DogSize.Medium, FirstDog=false, Active=false},
                new Dog { Name = "Tornjak", Size=DogSize.Large, FirstDog=true, Active=false},
                new Dog { Name = "Tosa", Size=DogSize.Large, FirstDog=false, Active=false},
                new Dog { Name = "Whippet", Size=DogSize.Medium, FirstDog=true, Active=false},

            };
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
                result = result.Where(d => d.Name.Contains(filter));
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
