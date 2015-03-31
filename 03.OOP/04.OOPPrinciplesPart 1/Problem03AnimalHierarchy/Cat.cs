namespace Problem03AnimalHierarchy
{
    using System;

    public class Cat : Animal
    {
        public Cat(string name, byte age, bool isMale)
            : base(name, age, isMale) { }

        #region Overrides of Animal

        public override void SaySomething()
        {
            Console.WriteLine("Miao, miao, miao...");
        }

        #endregion
    }
}