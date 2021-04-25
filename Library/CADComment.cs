using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;

namespace Library
{
    public class CADComment
    {
        // Connection string for the database

        private string constring;

        public CADComment()
        {
            constring = ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;
        }

        public bool createComment(ENComment comment)
        {
            // Code to check if that comment ID already exists on the database or not
            // Returns true if comment was created succesfully. False in other case

            return true;
        }

        public bool updateComment(ENComment comment)
        {
            // Code to update the text of the comment
            // Returns true if comment was updated succesfully. False in other case

            return true;
        }

        public bool deleteComment(ENComment comment)
        {
            // Code to delete the comment
            // Returns true if comment was deleted succesfully. False in other case

            return true;
        }

        public bool listComment(ENComment comment)
        {
            // Code to list comments
            // Returns true if comments were listed succesfully. False in other case

            return true;
        }
    }
}
