using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
	class Rectange:Shape
	{
		public Rectange(Point p1, Point p2, Point p3, Point p4)
		{
			points = new Point[4];
			points[0] = p1;
			points[1] = p2;
			points[2] = p3;
			points[3] = p4;
		}

		public Rectange(Point center, double wigth, double hetght)
		{
			points = new Point[4];
			double w = wigth * 0.5;
			double h = hetght * 0.5;
			points[0] = new Point(center.x - w, center.y + h);
			points[1] = new Point(center.x - w, center.y + h);
			points[2] = new Point(center.x - w, center.y - h);
			points[3] = new Point(center.x - w, center.y - h);
		}
	}
}
