using System;

namespace Library
{
    // This class is used to represent and manipulate dates on an easiest way.
	public class Date
	{
        private int _day;
        public int day
        {
            get { return _day; }
            private set { _day = value; }
        }

        private int _month;
        public int month
        {
            get { return _month; }
            private set { _month = value; }
        }

        private int _year;
        public int year
        {
            get { return _year; }
            private set { _year = value; }
        }

        public Date(int day, int month, int year)
		{
            this.day = day;
            this.month = month;
            this.year = year;
		}

        public override string ToString()
        {
            string date= day + "/" + month + "/" + year;
            if (day < 10)
            {
                date = date.Insert(0, "0");
            }
            if (month < 10)
            {
                date = date.Insert(3, "0");
            }
            return date;
        }
    }

    public class IntervalDate
    {
        private Date _startDate;
        public Date startDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        private Date _endDate;
        public Date endDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        public IntervalDate(Date start, Date end)
        {
            this.startDate = start;
            this.endDate = end;
        }
    }
}