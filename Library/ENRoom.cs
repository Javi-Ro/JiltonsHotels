using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    /// Class to represent business entitity room
    /// </summary>
    public class ENRoom
    {
        /// <summary>
        /// integer value that will be auto-incremented in the database
        /// </summary>
        private int _id;

        public int id {
            get { return _id; }
            set { _id = value; }
        }

        private string _title;

        public string title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _description;

        public string description {
            get { return _description; }
            set { _description = value; }
        }

        private float _price;

        public float price {
            get { return _price; }
            set { _price = value; }
        }
        //number of king size beds
        private int _adultBed;

        public int adultBed
        {
            get { return _adultBed; }
            set { _adultBed = value; }
        }

        private int _childBed;
        public int childBed
        {
            get { return _childBed; }
            set { _childBed = value; }
        }

        private string _type;

        public string type          //type will be: single, double, triple, deluxe, executive or presidential
        {
            get { return _type; }
            set { _type = value; }
        }

        private ENBooking _booking;

        public ENBooking booking
        {
            get { return _booking; }
            set { _booking = value; }
        }

        //string that is the path to the image
        private string _imageLink;

        public string imageLink
        {
            get { return _imageLink; }
            set { _imageLink = value; }
        }
        /// <summary>
        /// default constructor
        /// </summary>
        public ENRoom()
        {
            id = 0;
            title = "Confort room";
            description = "Comfort room suitable for all kinds of families";
            booking = null;
            price = 390;
            type = "Single";
            imageLink = "assets/room1.jpg";
        }

        /// <summary>
        /// copy constructor 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="price"></param>
        /// <param name="childBed"></param>
        /// <param name="adultBed"></param>
        /// <param name="type"></param>
        /// <param name="booking"></param>
        /// <param name="imagen"></param>
        public ENRoom(int id,string title,string description, float price, int childBed,  int adultBed, string type,ENBooking booking, string imagen)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.price = price;
            this.childBed = childBed;
            this.adultBed = adultBed;
            this.type = type;
            this.booking = booking;
            this.imageLink = imagen;
        }

        /// <summary>
        /// Function to show all available rooms
        /// </summary>
        /// <returns>DataSet with all the rooms</returns>
        public DataSet showAll()
        {
            CADRoom room = new CADRoom();
            return room.showAll(this);
        }

        /// <summary>
        /// Function to insert a room
        /// </summary>
        /// <returns>returns wether it was created or not </returns>
        public bool insertRoom()
        {
            CADRoom room = new CADRoom();
            bool create = room.Insert(this);
            return create;
        }

        /// <summary>
        /// Function to update a room
        /// </summary>
        /// <returns>returns wether it was updated or not </returns>
        public bool update()
        {
            CADRoom room = new CADRoom();
            ENRoom nuevo = new ENRoom(this.id, this.title, this.description, this.price, this.childBed, this.adultBed, this.type, this.booking, this.imageLink);
            bool existe = room.searchRoom(this);
            if (existe)
            {
                this.id = nuevo.id;
                this.title = nuevo.title;
                this.description = nuevo.description;
                this.price = nuevo.price;
                this.childBed = nuevo.childBed;
                this.adultBed = nuevo.adultBed;
                this.type = nuevo.type;
                this.booking = nuevo.booking;
                this.imageLink = nuevo.imageLink;
                bool update = room.update(this);
                return update;

            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Function to delete a room
        /// </summary>
        /// <returns>returns wether it was delete or not </returns>
        public bool delete()
        {
            CADRoom room = new CADRoom();

            bool existe = room.searchRoom(this);
            if (existe)
            {
                bool borrado = room.delete(this);
                return borrado;

            }
            else
            {
                return false;
            }
        }

    }
}
