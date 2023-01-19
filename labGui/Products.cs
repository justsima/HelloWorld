using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // this will help us import the sql connection Class 
using System.Windows.Forms;
namespace labGui
{


    class Products : Form
    {
		
		static private List<Products> products = new List<Products>();
		public int number { get; set; }
		public String date { get; set; }
		public int inventory { get; set; }
		public string name { get; set; }
		public int count { get; set; }
		public int price { get; set; }
        public bool isavailable  { get; set; }
        public bool radiobtn { get; set; }
        public string search { get; set; }
        
        public void save()
		{
			Console.WriteLine("Query saved!");
			products.Add(this);
			
		}
		public static List <Products> GetAllProducts()
        {
            SqlConnect service = new SqlConnect();
            List<Products> temp = new List<Products>();
            string query = "SELECT * FROM Products";

            SqlDataReader data = service.executeReader(query);
            while (data.Read())
            {
                Products product = new Products();
                product.number = (int)data["Numbers"];
                product.date = (string)data["ProdDate"].ToString();
                product.inventory = (int)data["InventoryNumber"];
                product.name = (string)data["ObjectName"];
                product.price = (int)data["Price"];
                product.count = (int)data["Quantity"];
               /* product.productType = (Convert.ToBoolean(data["ProductType"])) ? "Variable" : "Simple";*/
                temp.Add(product);
            }
            return temp;
        }
		public static Products findone (string name)
		{
            List<Products> temps = new List<Products>();
            try
            {
                String connection = @"Data source = SIMON\SQLEXPRESS;initial catalog = LABGUI;integrated security = true";
                SqlConnection Con = new SqlConnection(connection);
                Con.Open();
                string query = "select * from LabGui";
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataReader result = cmd.ExecuteReader();

                while (result.Read())
                {
                    Products p = new Products();
                    p.number = (int)result["numb"];
                    p.date = (String)result["mydate"];
                    p.inventory = (int)result["inv_num"];
                    p.name = (String)result["obj_name"];
                    p.count = (int)result["count"];
                    p.price = (int)result["price"];
                    temps.Add(p);
                }
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return temps.Find(a => a.name == name);

        }
		
		 public int Save()
        {
            SqlConnect service = new SqlConnect();
            /* int productType = (this.productType == "Variable") ? 1 : 0;*/
            string query = $"INSERT INTO Products VALUES({this.number}," +
                $"{this.inventory}," +
                $"'{this.name}'," +
                $"'{this.date}'," +
                $"{this.count}," +
                $"{this.price},";
               /* $"{productType})";*/

            int numberOfRowAffercted = service.executeNonQuery(query);

            if (numberOfRowAffercted > 0)
            {
                MessageBox.Show("Product has been added!");
            }

            return numberOfRowAffercted;

        }
		/*public static List<Products> GetProducts(string name)
		{
			return products;
		}*/
	}
}
