using System;
using System.Collections.Generic;

namespace Library
{
	public class ENService
	{
		private int id;
		private int price;
		private string description;
		  
		public int Id
		{ //ID  of the service
			get
			{
				return id;
			}
			private set
			{
				id = value;
			}
		}

		public int Price
		{ //Price of the service
			get
			{
				return price;
			}
			private set
			{
				price = value;
			}
		}

		public string Descritpion
		{ //Description of the service
			get
			{
				return description;
			}
			private set
			{
				description = value;
			}
		}

		public ENService()
		{

		}

		public bool createService()
        {
			CADService service = new CADService();
			return service.createService(this);
		}

		public bool deleteService()
        {
			CADService service = new CADService();
			return service.deleteService(this);
		}

		public bool updateService()
        {
			CADService service = new CADService();
			return service.updateService(this);
		}

		public List<ENService> listAllServices()
		{
			CADService service = new CADService();
			return service.listAllServices();
		}

		/*public ENService searchService()
		{
			CADService service_ = new CADService();
			return service_.searchService();
		}*/

		public class Excursion : ENService
        {
			private string name;
			private int maxPeople;

        }

		public class Gym : ENService
        {
			//poder buscar empleados alomejor en esta y en todas
        }

		public class Spa : ENService
		{

		}
		
		public class Kingergarten : ENService
        {

        }

	}
}


