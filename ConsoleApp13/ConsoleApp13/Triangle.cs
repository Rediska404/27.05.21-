using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
	class Triangle : Shape
	{
		Triangle(Point[] points)
		{
			if (points.Length != 3)
			{
				throw new Exception("Для создания треугольника необходимо указать 3 угла.");
			}
		}

		public Triangle(Point p1, Point p2, Point p3)
			{
			points = new Point[3];
			points[0] = p1;
			points[1] = p2;
			points[2] = p3;
			} 
		public void Result(double p1, double p2, double p3)
		{
			double P = Math.Sqrt(Math.Pow((points[0].x - points[1].x), 2)+ Math.Pow((points[0].y - points[1].y), 2) + 
				Math.Pow((points[1].x - points[2].x), 2) + Math.Pow((points[1].y - points[2].y), 2) +
				Math.Pow((points[2].x - points[3].x), 2) + Math.Pow((points[2].y - points[3].y), 2));
		}
		public void Result(double p1, double p2, double p3)
		{
			
			double S = 0.5 * Math.Abs();

		}
	}
}
