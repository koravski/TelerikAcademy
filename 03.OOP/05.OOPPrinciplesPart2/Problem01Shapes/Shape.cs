namespace Problem01Shapes
{
    using System;

    public abstract class Shape
    {
        private double width;
        private double height;

        protected Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The width of the figure must be a positive number bigger than zero !");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The width of the figure must be a positive number bigger than zero !");
                }

                this.height = value;
            }
        }

        public abstract double CalculateSurface();
    }
}