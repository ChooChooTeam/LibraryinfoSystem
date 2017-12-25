using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    
    public class ReaderType
    {
        ReaderType(int typeID,string typeName,int borrowDuration,int borrowNum)
        {
            _typeID = typeID;
            _typeName = typeName;
            _borrowDuration = borrowDuration;
            _borrowNum = borrowNum;
        }
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
