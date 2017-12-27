using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    
    public class ReaderType
    {
        public ReaderType(int typeID,string typeName, DateTime borrowDuration,int reBorrowNum,int maxBorrowNum)
        {
            _typeID = typeID;
            _typeName = typeName;
            _borrowDuration = borrowDuration;
            _reBorrowNum = reBorrowNum;
            _maxBorrowNum = maxBorrowNum;
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

        private DateTime _borrowDuration;
        public DateTime BorrowDuration
        {
            get
            {
                return _borrowDuration;
            }
        }

        private int _reBorrowNum;
        public int ReBorrowNum
        {
            get
            {
                return _reBorrowNum;
            }
        }
        private int _maxBorrowNum;
        public int MaxBorrowNum
        {
            get
            {
                return _maxBorrowNum;
            }
        }
    }
}
