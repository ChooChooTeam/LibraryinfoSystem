using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CircuBookClass
    {
        CircuBookClass(string ISBN,string bookName,string mainAuthor,string otherAuthor,DateTime publicationYear,string CDName,decimal price,int bookNum)
        {
            _ISBN = ISBN;
            _bookName = bookName;
            _mainAuthor = mainAuthor;
            _otherAuthor = otherAuthor;
            _publicationYear = publicationYear;
            _CDName = CDName;
            _price = price;
            _bookNum = bookNum;
        }
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
