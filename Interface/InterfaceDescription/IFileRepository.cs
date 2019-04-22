using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDescription
{
    public interface IFileRepository
    {
        string GetFile(string File);
        string SaveFileToRepo(string File);
    }
}
