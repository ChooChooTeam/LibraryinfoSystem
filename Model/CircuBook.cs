using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CircuBook
    {
        CircuBook(int circuBookNo,int libraryID,string ISBN)
        {
            _circuBookNo = circuBookNo;
            _libraryID = libraryID;
            _ISBN = ISBN;
        }
        private int _circuBookNo;
        public int CircuBookNo
        {
            get
            {
                return _circuBookNo;
            }
        }

        private int _libraryID;
        public int LibraryID
        {
            get
            {
                return _libraryID;
            }
        }

        private string _ISBN;
        public string ISBN
        {
            get
            {
                return _ISBN;
            }
        }
    }
}
