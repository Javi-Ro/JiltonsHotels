﻿using System;
using System.Collections.Generic;
using System.Data;

namespace Library
{
	public class ENService
	{
		private int id;
		private int price;
		private string description;
		private string name;
		private int maxPeople;
		private string type;
		private string imgURL;

		public string Type
        {
            get
            {
				return type;
            }
			set
            {
				type = value;
            }
        }

		public string ImgURL
        {
            get
            {
				return imgURL;
            }
			set
            {
				imgURL = value;
            }
        }

		public string Name
        {
            get
            {
				return name;
            }
			set
            {
				name = value;
            }
        }

		public int MaxPeople
        {
            get
            {
				return maxPeople;
            }
			set
            {
				maxPeople = value;
            }
        }

		public int Id
		{ //ID  of the service
			get
			{
				return id;
			}
			set
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
			set
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
			set
			{
				description = value;
			}
		}

		public ENService()
		{

		}

		public ENService(int id, string description, int price, string name, int maxp, string img, string type)
        {
			this.id = id;
			this.description = description;
			this.price = price;
			this.name = name;
			this.maxPeople = maxp;
			this.imgURL = img;
			this.type = type;
        }

		public ENService(int id, string description, int price, string img, string type)
		{
			this.id = id;
			this.description = description;
			this.price = price;
			this.imgURL = img;
			this.type = type;
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

		public DataSet listAllServices()
		{
			CADService service = new CADService();
			return service.listAllServices();
		}

		public DataSet listMoreServices()
		{
			CADService service = new CADService();
			return service.listMoreServices();
		}

		public DataSet listAllSpa()
        {
			CADService service = new CADService();
			return service.listAllSpa();
		}

		public DataSet listAllGym()
        {
			CADService service = new CADService();
			return service.listAllGym();
		}

		public ENService searchService()
		{
			CADService service = new CADService();
			return service.searchService(this.Id);
		}


	}
}


