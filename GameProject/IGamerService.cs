using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    // operasyonlar interface ile yazılır. Operasyon interfaceleri "Service" anahtar kelimesi ile yazılır. 
    interface IGamerService
    {
        void Add(Gamer gamer); // Operasyonların interfaceleri.
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
