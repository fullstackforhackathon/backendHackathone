using backendHackathone.PresentLayer.Models;
using System.IO;

namespace backendHackathone.PresentLayer.Excel
{
    public interface IExcelParser
    {
        UserTable Parse(Stream stream);
    }
}
