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
			}
			public override double Area()//переопределнный метод вычисления площади
			{
				double S = Math.Round(this.wdth * this.high,4);//переопределение функции нахождения площади круга с точностью до 4-ого знака после запятой
				return S;
			}
			public override string ToString()//переопределение виртуального метода вывода данных об объекте
			{
				return "Прямоугольник площадью " + this.Area().ToString();
			}
		public void Print()//метод печати данных об объекте
			{
				Console.WriteLine(this.ToString());
			}
		}
	}
