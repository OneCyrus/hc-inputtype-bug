using System.Diagnostics.Contracts;

namespace hc_bugs
{
    public class Animal : AbstractThing
    {
        public string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
        }
    }
}