using System;

namespace InterfaceDescription
{
    public interface IDbConnection
    {
        string OpenDbConnection();
        string CloseDbConnection();
        string UpdateDbConnection();

    }
}
