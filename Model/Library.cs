using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
     public  class Library
    {
        public Library(int libraryID,string libraryName,string libraryLocation)
        {
            _libraryID = libraryID;
            _libraryName = libraryName;
            _libraryLocation = libraryLocation;
        }
        private int _libraryID;
        public int LibraryID
        {
            get
            {
                return _libraryID;
            }
        }

        private string _libraryName;
        public string LibraryName
        {
            get
            {
                return _libraryName;
            }
        }

        private string _libraryLocation;
        public string LibraryLocation
        {
            get
            {
                return _libraryLocation;
            }
        }

    }
}
