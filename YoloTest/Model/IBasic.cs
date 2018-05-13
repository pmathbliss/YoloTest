using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoloTest.Model
{
    interface IBasic
    {
        string ImageLocation { get; set; }

        void Run();
    }
}
