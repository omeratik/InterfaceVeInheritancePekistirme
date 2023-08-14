using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	internal interface ICustomerDal
	{
		void Add();
		void Update();
		void Delete();
	}

	class SqlServerCustomerDal : ICustomerDal
	{
		public void Add()
		{
            Console.WriteLine("SQL added!");
        }

		public void Delete()
		{
            Console.WriteLine("SQL deleted !");
        }

		public void Update()
		{
            Console.WriteLine("SQL updated");
        }
	}
	class OracleCustomerDal : ICustomerDal
	{
		public void Add()
		{
            Console.WriteLine("Oracle Added "); ;
		}

		public void Delete()
		{
            Console.WriteLine("Oracle deleted"); 
		}

		public void Update()
		{
            Console.WriteLine("Oracle updated");
		}
	}
	class CustomerManager
	{
		public void Add(ICustomerDal customerDal)
		{
			customerDal.Add();  
		}
	}
}
