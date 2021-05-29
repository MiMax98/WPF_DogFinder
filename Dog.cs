using System;

namespace RasyPsow
{
    public class Dog
    {
        public string Name { get; set; }
        public DogSize Size { get; set; }
        public bool FirstDog { get; set; }
        public bool Active { get; set; }
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
