using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class Zoo
    {
        public Zoo()
        {
            Animals = new List<Animal>();
            InitZoo();
        }

        public List<Animal> Animals { get; set; }

        private void InitZoo()
        {
            Animals.Add(new Animal("Elephant", Gender.Female));
            Animals.Add(new Animal("Tiger", Gender.Male));
            Animals.Add(new Animal("Fox", Gender.Female));
        }
    }
}
