using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	public class ENComment
	{
		// Attributes

		private static int UniqueID = 0;

		private int _id;

		// Properties

		// Comment ID will be calculated automatically

		private int ID 
		{
			set 
			{
				_id = value;
			}
			get
            {
				return _id;
            }
		}

		private string Text { set; get; }

		public ENComment(string text)
        {
			this.Text = text;

			this.ID = System.Threading.Interlocked.Increment(ref UniqueID); // Interlocked makes sure that if we create more than one comment at the same time, they won't have the same ID
			// since we are using a static value and it can be modified by another instance at the same time. Increment increments the value of UniqueID because we called the function 
			// with a reference to UniqueID
        }

		// Create comment with the specified text

		public bool createComment()
        {
			CADComment cad = new CADComment();

			return cad.createComment(this);
        }

		// Update the text of the comment

		public bool updateComment()
		{
			CADComment cad = new CADComment();

			return cad.updateComment(this);
		}

		// Delete the comment

		public bool deleteComment()
		{
			CADComment cad = new CADComment();

			return cad.deleteComment(this);
		}
	}
}
