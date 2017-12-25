using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DamageRecord
    {
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

        private int _cicuBookNo;
        public int CicuBookNo
        {
            get
            {
                return _cicuBookNo;
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
