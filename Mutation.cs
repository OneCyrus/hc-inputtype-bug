namespace hc_bugs
{
    public class Mutation 
    {
        // public Animal GetAddAnimal(Animal p) => p;

        public Test Setup { get; } = Test.DEFAULT;
    }

    public class Test : Addition<Animal, Person>
    {
        public static readonly Test DEFAULT
            = new Test();
    }

    public class Addition<T, TParam>
        where T : Animal
        where TParam : IThingUnion
    {
        public T GetAddPerson(TParam p) {
            return (T)new Animal("test");
        }
    }
}
