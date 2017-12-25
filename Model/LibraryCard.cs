﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LibraryCard
    {
        private int _libraryCardID;
        public int LibraryCardID
        {
            get
            {
                return _libraryCardID;
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
