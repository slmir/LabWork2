using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
	class Circle : Figures, IPrint//наследуется от абстрактного класса Figures и реализует интерфес IPtint
	{
		const double PI = 3.1415;//число Пи, для нахождения площади круга
		double radius;//радиус фигуры
		public Circle(double rad)//конструктор
		{
			this.radius = rad;
			this.Type = "Круг";
		}
		public override double Area()//переопределяем метод вычисления площади
		{
			double S = Math.Pow(this.radius, 2) * PI;
			return S;
		}
		public void Print()//вывод данных об объекте
		{
			Console.WriteLine(this.ToString());
		}
	}
}

