using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labGui
{
    internal class Products
    {
		public int number { get; set; }
		public DateTime date { get; set; }
		public int inventory { get; set; }
		public string name { get; set; }
		public int count { get; set; }
		public int price { get; set; }
		public void save()
		{
			Console.WriteLine("Query saved ");
		}
	}
}
