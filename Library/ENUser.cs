using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	public class ENUser
	{
		// Properties

		public string ID { set; get; }

		public string Name { set; get; }

		public string Email { set; get; }

		public string Birthday { set; get; }

		public string Address { set; get; }

		public string Password { set; get; }

		public string LoginData { set; get; }

		// ENUser constructor with parameters. (We need to fullfill all the information in the registration form in order to create the user, otherwise -> error)
		// ID == NIE/NIF/DNI -> string type
		// We will check in the CADUser if there is already a User with that ID or email
		// Phone number can be used to create multiple accounts. Store phone as string because we can use hyphens, spaces or '+' sign to indicate country
		// Address will be stored as a single string. On the registration form we will have multiple TextBox to indicate country, province, city, postal code, etc...
		// but on the Registrate button's handler we will concatenate all the information
		// We will require a date of birth, not age directly. Doing it this way we can calculate the age and update every year

		public ENUser(string ID, string name, string email, string birthday, string address, string password)
		{
			this.ID = ID;
			this.Name = name;
			this.Email = email;
			this.Birthday = birthday;
			this.Address = address;
			this.Password = password;
			this.LoginData = "";
		}

		public ENUser(string loginData, string password)
        {
			this.LoginData = loginData;
			this.Password = password;
        }

		// Create, update, and delete user will return a boolean to confirm or decline the operation that was executed on the database

		public bool CreateUser()
        {
			CADUser cad = new CADUser();

			return cad.CreateUser(this);
        }

		// Update information of the User (phone, mail or address. ID, name or age cannot be changed by obvious reasons)

		public bool UpdateUser()
        {
			CADUser cad = new CADUser();

			return cad.UpdateUser(this);
		}

		// If we want to delete the user to create another one with the same ID for example

		public bool DeleteUser()
        {
			CADUser cad = new CADUser();

			return cad.DeleteUser(this);
		}

		public int LoginUser()
        {
			CADUser cad = new CADUser();

			return cad.LoginUser(this);
        }
	}
}
