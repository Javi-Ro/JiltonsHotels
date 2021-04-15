using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ENRoom
    {
        private static int last_id = 0;

        private int _id; 
        
        public int id { 
            get { return _id; } 
            set { _id = value; } 
        }

        private string _title;

        public int title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _description; 
        
        public int description { 
            get { return _description; } 
            set { _description = value; } 
        }

        private float _price; 
        
        public float price { 
            get { return _price; } 
            set { _price = value; } 
        }

        private string _type;

        public string type          //type will be: single, double, triple, deluxe, executive or presidential
        {
            get { return _type; }
            set { _type = value; }
        }

        private bool _available;

        public bool available
        {
            get { return _available; }
            set { _available = value; }
        }
        private int _size;

        public int size
        {
            get { return _size; }
            set { _size = value; }
        }

        public EnRoom()
        {
            id = last_id++;
            title = "Confort room";
            description = "Comfort room suitable for all kinds of families";
            size = 15;
            available = true;
            price = 60;
            type = "Single";
        }

        public bool showAll()
        {
            CADRoom room = new CADRoom();
            bool show = user.readByType(this);
            return show;
        }

        public bool showByType()
        {
            CADRoom room = new CADRoom();
            bool show = user.readByType(this);
            return show;
        }

        public bool showByMinSize()
        {
            CADRoom room = new CADRoom();
            bool show = user.readByMinSize(this);
            return show;
        }

        public bool showAllOrderByPriceUp()
        {
            CADRoom room = new CADRoom();
            bool show = user.readOrderByPriceUp(this);
            return show;
        }

        public bool showAllOrderByPriceDown()
        {
            CADRoom room = new CADRoom();
            bool show = user.readOrderByPriceDown(this);
            return show;
        }

    }
}
