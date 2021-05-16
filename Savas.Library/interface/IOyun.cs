using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Savas.Library.Enum;

namespace Savas.Library.internalinterface
{
  internal  interface IOyun
{
        bool DevamEdiyorMu { get;  }
        TimeSpan Gecensure { get; }
        void baslat();
        void ateset();
       void ucaksavarihareketettir(Yon yon);
}
}
