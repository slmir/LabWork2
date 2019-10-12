using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
	abstract class Figures//абстрактный класс "геометрическая фигура"
	{
		public abstract double Area();//виртуальный метод вычисления площади, предполагающий переопределние в классах-наследниках
	}
}