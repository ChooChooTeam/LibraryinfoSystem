using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DamageRecord
    {
        DamageRecord(int damageIndex,int damageReasonIndex,int libraryID,int circuBookNo,DateTime damageTime,decimal damageMoney,string damageRemark)
        {
            _damageIndex = damageIndex;
            _damageReasonIndex = damageReasonIndex;
            _libraryID = libraryID;
            _circuBookNo = circuBookNo;
            _damageTime = damageTime;
            _damageMoney = damageMoney;
            _damageRemark = damageRemark;
        }
        private int _damageIndex;
        public int DamageIndex
        {
            get
            {
                return _damageIndex;
            }
        }

        private int _damageReasonIndex;
        public int DamageReasonIndex
        {
            get
            {
                return _damageReasonIndex;
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

        private int _circuBookNo;
        public int CircuBookNo
        {
            get
            {
                return _circuBookNo;
            }
        }

        private DateTime _damageTime;
        public DateTime DamageTime
        {
            get
            {
                return _damageTime;
            }
        }

        private decimal _damageMoney;
        public decimal DamageMoney
        {
            get
            {
                return _damageMoney;
            }
        }

        private string _damageRemark;
        public string DamageRemark
        {
            get
            {
                return _damageRemark;
            }
        }
    }
}
