namespace Problem03AnimalHierarchy
{
    using System;

    public class Kitten : Cat
    {
        public Kitten(string name, byte age)
            : base(name, age, false) { }

        #region Overrides of Cat

        public override void SaySomething()
        {
            Console.WriteLine("Kitty miao, miao, miao...");
        }

        #endregion
    }
}