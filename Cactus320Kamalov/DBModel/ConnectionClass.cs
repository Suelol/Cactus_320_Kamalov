using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cactus320Kamalov.DBModel
{
    public static class ConnectionClass
    {
        public static PractikaProggEntities db = new PractikaProggEntities();
        public static int IsOnlineUserId = 0;
    }
}
