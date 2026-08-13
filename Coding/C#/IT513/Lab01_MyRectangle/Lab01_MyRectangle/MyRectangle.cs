using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_MyRectangle
{
    internal class MyRectangle
    {
		private double width;

		public double Width
		{
			get { return width; }
			set { width = value; }
		}

		private double height;

		public double Height
		{
			get { return height; }
			set { height = value; }
		}

        public MyRectangle(double width, double height)
        {
			Height = height;
			Width = width;
        }

		public double CalcArea()
		{
			return height * width;
		}

		public double CalcPerimeter()
		{
			return 2 * (height + width);
		}

        public override string ToString()
        {
			return $"{width:0.0} x {height:0.0} Rectangle";
        }
    }

}
