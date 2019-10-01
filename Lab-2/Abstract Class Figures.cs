using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
	abstract class Figures//абстрактный класс "геометрическая фигура"
	{
		string _Type;//тип объекта - какой фигурой он является	
		public string Type { get; protected set; }//свойство, содержащее строковое именование фигуры, объявлено как автоопределяемое относительно get(получить данные) и set(установить данные)
		public abstract double Area();//виртуальный метод вычисления площади, предполагающий переопределние в классах-наследниках
		public override string ToString()//переопределение виртуального метода вывода данных об объекте
		{
			return this.Type + " площадью " + this.Area().ToString();
		}
	}
}