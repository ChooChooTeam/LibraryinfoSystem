using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DamageReason
    {
        public DamageReason(int damageReasonIndex,string damageExplain)
        {
            _damageReasonIndex = damageReasonIndex;
            _damageExplain = damageExplain;
        }
        private int _damageReasonIndex;
        public int DamageReasonIndex
        {
            get
            {
                return _damageReasonIndex;
            }
        }

        private string _damageExplain;
        public string DamageExplain
        {
            get
            {
                return _damageExplain;
            }
        }


    }
}
