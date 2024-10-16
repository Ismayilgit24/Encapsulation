using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
	internal class NoteBook : Product
	{
		public string _opsystem;
		public string _processor;
		public bool _hasgraphiccard;

		public string OpSystem
		{

			get
			{
				return _opsystem;
			}
			set
			{
				_opsystem = value;
			}
		}
		public string Processor
		{

			get
			{
				return _processor;
			}
			set
			{
				_processor = value;
			}
		}
		public bool HasGraphicCard
		{

			get
			{
				return _hasgraphiccard;
			}
			set
			{
				_hasgraphiccard = value;
			}
		}










		public NoteBook(string brandname, string model, decimal price, decimal cost, int count, string opsystem, string processor) : base(brandname, model, price, cost, count)
		{
			OpSystem = opsystem;
			Processor = processor;
			HasGraphicCard = false;
            
		}
		public NoteBook(string brandname, string model, decimal price, decimal cost, int count, string opsystem, string processor, bool hasgraphiccard) : base(brandname, model, price, cost, count)
		{
			OpSystem = opsystem;
			Processor = processor;
			HasGraphicCard = hasgraphiccard;
            
		}
		public void Sale(int _soldcount)
		{
			if (_count > 0 && _soldcount <= _count)
			{
				_income += (_price - _cost) * _soldcount;
				_count -= _soldcount;
				Console.WriteLine($"After - sales count : {_count}");
			}
			else
			{
				Console.WriteLine($"Count is 0");
			}
		}

		public void GetInfo()
		{
            Console.WriteLine($"ID : {ID}\nBrand Name : {_brandname}\nModel : {_model}\nPrice : {Price}\nCost : {Cost}\nIncome : {Income}\nBefore - sales count : {Count}");
		    Console.WriteLine($"Operating System: {OpSystem}");
			Console.WriteLine($"Processor: {Processor}");
			if(HasGraphicCard = true)
			{
                Console.WriteLine("Have Graphic card");
			}
			else
			{
                Console.WriteLine("Not Graphic card");
			}
		}
		
	}
}
