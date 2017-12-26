using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LibraryCard
    {
        public LibraryCard(int libraryCardID,int typeID,string name,String sex,String ID,DateTime regTime,DateTime dueTime)
        {
            _libraryCardID = libraryCardID;
            _typeID = typeID;
            _name = name;
            _sex = sex;
            _ID = ID;
            _regTime = regTime;
            _dueTime = dueTime;
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

        private string _name;
        public string _Name
        {
            get
            {
                return _name;
            }
        }


        private string _sex;
        public string Sex
        {
            get
            {
                return _sex;
            }
        }

        private string _ID;
        public string ID
        {
            get
            {
                return _ID;
            }
        }

        private DateTime _regTime;
        public DateTime RegTime
        {
            get
            {
                return _regTime;
            }
        }

        private DateTime _dueTime;
        public DateTime DueTime
        {
            get
            {
                return _dueTime;
            }
        }
    }
}
