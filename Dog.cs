using System;
using System.Collections.Generic;

namespace RasyPsow
{
    public class Dog
    {
        public string Name { get; set; }
        public DogSize Size { get; set; }
        public bool FirstDog { get; set; }
        public bool Active { get; set; }

        public static List<Dog> GetDogs()
        {
            return new List<Dog>
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
        }
    }

    [Flags]
    public enum DogSize
    {
        Undefined = 0,
        Small = 1,
        Medium = 2,
        Large = 4
    }
}
