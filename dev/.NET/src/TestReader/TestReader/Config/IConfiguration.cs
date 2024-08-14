using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReader.Config
{
    internal interface IConfiguration
    {
        (string name, int rowOffset, int colOffset, int rowSize, int colSize) GetConfig();
    }
}
