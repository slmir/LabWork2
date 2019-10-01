﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
		class Rectangle : Figures, IPrint //наследуется от абстрактного класса Figures и реализует интерфес IPtint
		{
			double high;//высота прямоугольника
			double wdth;//ширина прямоугольника
			public Rectangle(double hg, double wd)//конструктор
			{
				this.high = hg;
				this.wdth = wd;
				this.Type = "Прямоугольник";
			}
			public override double Area()//переопределнный метод вычисления площади
			{
				double S = this.wdth * this.high;
				return S;
			}
			public void Print()//метод печати данных об объекте
			{
				Console.WriteLine(this.ToString());
			}
		}
	}
