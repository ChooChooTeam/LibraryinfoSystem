using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BorrowRecord
    {
        public BorrowRecord(int borrowIndex,int libraryCardID,int circuBookNo,int borrowDuration,DateTime returnTime,DateTime dateToReturn,int reNewNum)
        {
            _borrowIndex = borrowIndex;
            _libraryCardID = libraryCardID;
            _circuBookNo = circuBookNo;
            _borrowDuration = borrowDuration;
            _returnTime = returnTime;
            _dateToReturn = dateToReturn;
            _reNewNum = ReNewNum;
        }
        private int _borrowIndex;
        public int Index
        {
            get
            {
                return _borrowIndex;
            }
        }

        private int _libraryCardID;
        public int CardID
        {
            get
            {
                return _libraryCardID;
            }
        }

        private int _circuBookNo;
        public int BookNo
        {
            get
            {
                return _circuBookNo;
            }
        }

        private int _borrowDuration;
        public int Duration
        {
            get
            {
                return _borrowDuration;
            }
        }

        private DateTime _returnTime;
        public DateTime ReturnTime
        {
            get
            {
                return _returnTime;
            }
        }

        private DateTime _dateToReturn;
        private DateTime DateToReturn
        {
            get
            {
                return _dateToReturn;
            }
        }

        private int _reNewNum;
        private int ReNewNum
        {
            get
            {
                return _reNewNum;
            }
        }

    }
}
