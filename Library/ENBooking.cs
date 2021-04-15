﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ENBooking
    {
        // Attributes and properties
        private int id;

        private ENUser _user;
        public ENUser user
        {
            get { return _user; }
            private set { _user = value; }
        }

        private ENDate _date;
        public ENDate date
        {
            get { return _date; }
            private set { _date = value; }
        }

        private string _board; // Here we can control the types of board
        public string board
        {
            get { return _board; }
            set { _board = value; }
        }

        private int _discount;  // We only are interested on keeping the percentage of the discount
        public int discount
        {
            get { return _discount;; }
            set { _discount; = value; }
        }


        // Booking methods
        public Booking(ENUser user, ENDate date, ENRoom rooms[], bool board, ENDiscount discount)
        {

        }

        public bool createBooking()
        {

        }

        public bool deleteBooking()
        {

        }

        public bool searchBooking()  // Looks for a booking on the db with the same user and date that the caller
        {

        }

        // Rooms methods
        const public ENRoom[] getRooms()
        {

        }

        public bool addRoom(ENRoom room)
        {

        }

        public bool deleteRoom(ENRoom room)
        {

        }

        public bool isOnTheBooking(ENRoom room)
        {

        }
        
        // Services methods
        const public ENService[] getServices()
        {

        }

        public bool addService(ENService service)
        {

        }

        public bool cancelService(ENService service)
        {

        }


        public bool isOnTheBooking(ENService service)
        {

        }

        // Packages methods
        public bool addPackage(ENPackage package)
        {

        }

        public bool cancelPackage(ENPackage package)
        {

        }

        public bool isOnTheBooking(ENPackage package)
        {

        }

        // Discounts
        public bool applyDiscount(ENDiscount discount)
        {

        }

        public bool quitDiscount(ENDiscount discount)
        {

        }

        public bool isDiscounted()
        {

        }

        // Car leasing
        public bool addCar(ENCar car)
        {

        }

        public bool deleteCar(ENDiscount discount)
        {

        }

        public ENCar[] getCars()
        {

        }

        // Auxiliary methods
        const public int calculatePrice()
        {

        }
    }
}