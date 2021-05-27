using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
	class Shape
	{
		protected Point[] points; // вершины фигуры
		protected Point center; // центр фигуры

		public Shape()
		{
			points = null;
		}

		public Shape (Point center, Point [] points)
		{
			this.center = center;
			this.points = points;
		}

		public Shape(Point[] points)
		{
			this.points = points;
		}

		public void Draw()
		{
			if (points==null)
			{
				return;
			}
		}
	}
}
