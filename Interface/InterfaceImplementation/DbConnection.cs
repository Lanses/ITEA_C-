using InterfaceDescription;
using System;

namespace InterfaceImplementation
{
    internal abstract class DbConnection : IDbConnection
    {
        public DbConnection()
        {
        }

        public string CloseDbConnection { get; set }


        public string OpenDbConnection { get; set }


        public string UpdateDbConnection { get; set }

    }
}
