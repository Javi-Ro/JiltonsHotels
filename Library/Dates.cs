using System;

namespace Library
{
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

        public Date(int day, int month, int year) // Here will be controlled that the date is correct
		{

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

        }
    }
}