using InterfaceDescription;
using System;
using System.Data.Common;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            DbConnection connection = new IDbConnection();
            IDbConnection updateConnection = new IDbConnection();
            IFile myFile = new File();
            IFileRepository repoFile = new FileRepository();

            connection.OpenDbConnection();
            Console.ReadLine();
            myFile.CreateFile("File");
            repoFile.SaveFileToRepo("File");
            connection.CloseDbConnection();
            updateConnection.UpdateDbConnection();

        }
    }
}
