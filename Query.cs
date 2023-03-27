namespace hc_bugs
{
    public class Query
    {
        public IThingUnion GetPerson() => new Person("Luke Skywalker");
        public IThingUnion GetAnimal() => new Animal("Dog");
    }
}
