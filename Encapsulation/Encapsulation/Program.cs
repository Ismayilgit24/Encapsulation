using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Encapsulation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Product product = new Product("Apple", "iPhone 16", 3500, 1000, 150);
			product.GetInfo();
			product.Sale(7);

			Phone phone = new Phone("Apple", "iPhone 16", 3500, 1000, 150, 8, "Red", 1m);
			phone.GetInfo();
			phone.Call(0.55m);
			phone.Pay(2);

			NoteBook notebook = new NoteBook("Apple", "iPhone 16", 3500, 1000, 150, "Windows 11", "Intel Core 3.0", true);
			notebook.GetInfo();
			notebook.Sale(7);
		}
	}
}



