using Savas.Library.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Savas.Library.Interface
{
    interface IHareketEden
{
        Size HareketAlaniBoyutlari { get; }
       int HareketMesafesi { get; }
        /// <summary>
        /// cismi istenilen yonde hareket ettir.
        /// </summary>
        /// <param name="yon">hangi yone hareket edilecegi</param>
        /// <returns>cisim duvara carparsa true dondurur</returns>
        bool HarekEtttir(Yon yon);
        
}
}
