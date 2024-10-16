using Encapsulation;

internal class Phone : Product
{
	private int _ram;
	private string _color;
	private decimal _balance;
	public int RAM
	{

		get
		{
			return _ram;
		}
		set
		{
			_ram = value;
		}
	}
	public string Color
	{

		get
		{
			return _color;
		}
		set
		{
			_color = value;
		}
	}
	public decimal Balance
	{

		get
		{
			return _balance;
		}
		set
		{
			_balance = value;
		}
	}

	public Phone(string brandname, string model, decimal price, decimal cost, int count, int ram, string color = "Black", decimal balance = 0) : base(brandname, model, price, cost, count)
	{
		RAM = ram;
		Color = color;
		Balance = balance;

	}


	public void Call(decimal seconds)
	{
		if (_balance >= seconds * 0.1m)
		{
			
				_balance -= seconds * 0.1m;
                
            Console.WriteLine("Zeng edildi");
			Console.WriteLine($"Zengden sonraki yekun balans {_balance}");
		}
		else
		{
			Console.WriteLine("Balansinizda kifayet qeder mebleg yoxdur");
		}

	}


	public void Pay(decimal money)
	{
		_balance += money;
		Console.WriteLine($"Balansiniza elave olundu +{money} manat\nYekun balans {_balance}");
	}

	public void GetInfo()
	{
		Console.WriteLine($"ID : {ID}\nBrand Name : {_brandname}\nModel : {_model}\nPrice : {Price}\nCost : {Cost}\nIncome : {Income}\nBefore - sales count : {Count}\nRAM : {_ram}\nColor : {_color}\nBalance : {_balance}");
	}
	
}



