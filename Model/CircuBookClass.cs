using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CircuBookClass
    {
        private string _ISBN;
        public string ISBN
        {
            get
            {
                return _ISBN;
            }
        }

        private string _bookName;
        public string BookName
        {
            get
            {
                return _bookName;
            }
        }

        private string _mainAuthor;
        public string MainAuthor
        {
            get
            {
                return _mainAuthor;
            }
        }

        private string _otherAuthor;
        public string OtherAthor
        {
            get
            {
                return _otherAuthor;
            }
        }

        private DateTime _publicationYear;
        public DateTime PublicationYear
        {
            get
            {
                return _publicationYear;
            }
        }

        private string _CDName;
        public string CDName
        {
            get
            {
                return _CDName;
            }
        }

        private Decimal _price;
        public Decimal Price
        {
            get
            {
                return _price;
            }
        }

        private int _bookNum;
        public int BookNum
        {
            get
            {
                return _bookNum;
            }
        }
    }
}
