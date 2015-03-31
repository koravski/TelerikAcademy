namespace Problem03AnimalHierarchy
{
    using System;

    public class Dog : Animal
    {
        public Dog(string name, byte age, bool isMale)
            : base(name, age, isMale) { }

        #region Overrides of Animal

        public override void SaySomething()
        {
            Console.WriteLine("Bau, bau, bau...");
        }

        #endregion
    }
}