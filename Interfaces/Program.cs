﻿namespace Interfaces
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//InterfacesIntro();

			//Demo();

			ICustomerDal[] customerDals = new ICustomerDal[2]
			{
				new SqlServerCustomerDal(),
				new OracleCustomerDal()
			};
			foreach (var customerdal in customerDals)
			{
				customerdal.Add();
			}



			Console.ReadLine();
		}

		private static void Demo()
		{
			CustomerManager customerManager = new CustomerManager();
			customerManager.Add(new SqlServerCustomerDal());
		}

		private static void InterfacesIntro()
		{
			PersonManager manager = new PersonManager();
			Customer customer = new Customer
			{
				Id = 1,
				FirstName = "Ömer",
				LastName = "Atik",
				Address = "Bursa"
			};
			Student student = new Student()
			{
				Id = 1,
				FirstName = "Ahmet",
				LastName = "Atik",
				Departmant = "Computer Engineering"
			};
			Worker worker = new Worker()
			{
				Id = 1,
				FirstName = "Ahmet",
				LastName = "Atik",
				Departmant = "Computer Engineering"
			};
			manager.Add(worker);
		}

		interface IPerson
		{
             int Id { get; set; }
			 string FirstName { get; set; }
			 string LastName { get; set; }
		}
		class Customer : IPerson
		{
			public int Id { get; set; }
			public string FirstName { get; set; }
			public string LastName { get; set; }
            
			public string Address { get; set; }
        }
			
		class Student: IPerson
		{
			public int Id { get; set; }
			public string FirstName { get; set; }
			public string LastName { get; set; }
           
			public string Departmant { get; set; }
        }
		class Worker : IPerson
		{
			public int Id { get; set; }
			public string FirstName { get; set; }
			public string LastName { get; set; }

			public string Departmant { get; set; }

		}
		class PersonManager
		{
			public void Add(IPerson person)
			{
                Console.WriteLine(person.FirstName);
            }
		}
	}
}