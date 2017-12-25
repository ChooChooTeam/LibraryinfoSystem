using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Reader
    {
        Reader(string ID,int libraryCardID,int typeID,string sex)
        {
            _ID = ID;
            _libraryCardID = libraryCardID;
            _typeID = typeID;
            _sex = sex;
        }
        private string _ID;
        public string ID
        {
            get
            {
                return _ID;
            }
        }

        private int _libraryCardID;
        public int LibraryCardID
        {
            get
            {
                return _libraryCardID;
            }
        }

        private int _typeID;
        public int TypeID
        {
            get
            {
                return _typeID;
            }
        }

        private string _sex;
        public  string Sex
        {
            get
            {
                return _sex;
            }
        }
    }
}
