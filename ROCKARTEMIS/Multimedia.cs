using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROCKARTEMIS
{
    abstract class Multimedia
    {
        string name;
        string artistname;
        TimeSpan duration;

        string referencia;
    }

    class Video : Multimedia
    {

    }

    class Audio : Multimedia
    {

    }
}
