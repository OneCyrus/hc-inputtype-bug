namespace hc_bugs
{
    public class Person : AbstractThing
    {
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
