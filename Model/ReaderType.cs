using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ReaderType
    {
        private int _typeID;
        public int TypeID
        {
            get
            {
                return _typeID;
            }
        }

        private string _typeName;
        public string TypeName
        {
            get
            {
                return _typeName;
            }
        }

        private int _borrowDuration;
        public int BorrowDuration
        {
            get
            {
                return _borrowDuration;
            }
        }

        private int _borrowNum;
        public int BorrowNum
        {
            get
            {
                return _borrowNum;
            }
        }
    }
}
