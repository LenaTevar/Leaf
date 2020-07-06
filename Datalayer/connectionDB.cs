using System;
using System.Diagnostics;

namespace Leaf.Data
{
    public class ConnectionDB
    {
        private static string LEAF_PRE = "server=localhost;user=leaf;password=freD29BmEYEFcDNZ;database=leaf";

        public enum CENTER {
          LEAF_PRE
        }

        public static string ConnectionString(CENTER center) {
            switch (center) {
                case CENTER.LEAF_PRE:
                    return LEAF_PRE;
                default:
                    throw new Exception("Undefined center");
            }
        }
    }
}
