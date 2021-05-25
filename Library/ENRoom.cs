using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ENRoom
    {
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

        private float _ratings;

        public float ratings{
            get { return _ratings;}
            set {
                if (value > 5.0)
                    _ratings = 5;
                else
                    _ratings = ratings;
            }
        }

        private string _imageLink;

        public string imageLink
        {
            get { return _imageLink; }
            set { _imageLink = value; }
        }
        public ENRoom()
        {
            id = 0;
            title = "Confort room";
            description = "Comfort room suitable for all kinds of families";
            booking = null;
            price = 60;
            type = "Single";
            ratings = 5;
            imageLink = "assets/room1.jpg";
        }

        public ENRoom(int id,string title,string description, float price, int childBed,  int adultBed, string type, float ratings, ENBooking booking, string imagen)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.price = price;
            this.childBed = childBed;
            this.adultBed = adultBed;
            this.type = type;
            this.ratings = ratings;
            this.booking = booking;
            this.imageLink = imagen;
        }

        public DataSet showAll()
        {
            CADRoom room = new CADRoom();
            return room.showAll(this);
        }

        public bool insertRoom()
        {
            CADRoom room = new CADRoom();
            bool create = room.Insert(this);
            return create;
        }

        public bool updateRoom()
        {
            CADRoom room = new CADRoom();
            ENRoom nuevo = new ENRoom(this.id, this.title, this.description, this.price, this.childBed, this.adultBed, this.type, this.ratings, this.booking, this.imageLink);
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
                this.ratings = nuevo.ratings;
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

        //public bool showByType()
        //{
        //    CADRoom room = new CADRoom();
        //    bool show = room.selectByType(this);
        //    return show;
        //}

        //public bool showByMinSize()
        //{
        //    CADRoom room = new CADRoom();
        //    bool show = room.selectByMinSize(this);
        //    return show;
        //}

        public bool showAllOrderByPriceUp()
        {
            CADRoom room = new CADRoom();
            bool show = room.selectOrderByPriceUp(this);
            return show;
        }

        public bool showAllOrderByPriceDown()
        {
            CADRoom room = new CADRoom();
            bool show = room.selectOrderByPriceDown(this);
            return show;
        }

        //public bool setNotAvailable()
        //{
        //    this.available = false;
        //    CADRoom room = new CADRoom();
        //    bool show = room.UpdateNotAvailable(this);
        //    return show;
        //}

        //public bool setAvailableAgain()
        //{
        //    this.available = true;
        //    CADRoom room = new CADRoom();
        //    bool show = room.UpdateAvailable(this);
        //    return show;
        //}

    }
}
