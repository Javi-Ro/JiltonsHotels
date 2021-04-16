using System;

namespace Library
{
	public class ENService
	{
		private int id;
		private int price;
		private string description;

		private int Id
		{
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
		{
			get
			{
				return price;
			}
			private set
			{
				price = value;
			}
		}

		private string Descritpion
		{
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

		private bool createService()
        {

        }

		private bool deleteService()
        {

        }

		private bool updateService()
        {

        }

		public class Excursion : ENService
        {
			private string name;
			private int maxPeople;

        }

		public class Gym : ENService
        {

        }

		public class Spa : ENService
		{

		}
		
		public class Kingergarten : ENService
        {

        }

	}
}


