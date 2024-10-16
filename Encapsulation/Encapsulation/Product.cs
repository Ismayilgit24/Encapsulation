using System;

namespace Encapsulation
{
	internal class Product
	{
		public string _id;
		public string _brandname;
		public string _model;
		public decimal _price;
		public decimal _cost;
		public decimal _income;
		public int _count;


		public Product(string brandname, string model, decimal price, decimal cost, int count)
		{
			_brandname = brandname;
			_model = model;
			_price = price;
			_cost = cost;
			_count = count < 0 ? 0 : count;
		}


		public string BrandName
		{
			get
			{
				return _brandname;
			}
			set
			{
				_brandname = value;
			}
		}

		
		public string Model
		{
			get
			{
				return _model;
			}
			set
			{
				_model = value;
			}
		}

		
		public string ID
		{
			get
			{
				return _brandname.Substring(0, 2) + _model.Substring(0, 2);
			}
		}

		public decimal Price
		{
			get
			{
				return _price;
			}
			set
			{
				_price = value;
			}
		}

		public decimal Cost
		{
			get
			{
				return _cost;
			}
			set
			{
				_cost = value;
			}
		}

		
		public decimal Income
		{
			get
			{
				return _count < 0 ? 0 : _price - _cost;
			}
		}

		
		public int Count
		{
			get
			{
				return _count < 0 ? 0 : _count;
			}
		}

		
		public void GetInfo()
		{
			Console.WriteLine($"ID : {ID}\nBrand Name : {_brandname}\nModel : {_model}\nPrice : {Price}\nCost : {Cost}\nIncome : {Income}\nBefore - sales count : {Count}");
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
	}

}