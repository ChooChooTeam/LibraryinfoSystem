using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CircuBook
    {
        private int _circuBookNo;
        public int CircuBookNo
        {
            get
            {
                return _circuBookNo;
            }
        }

        private int _libaryID;
        public int LibraryID
        {
            get
            {
                return _libaryID;
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
