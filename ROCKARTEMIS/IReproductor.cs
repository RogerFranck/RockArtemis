using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROCKARTEMIS
{
    interface IReproductor
    {

        Multimedia currentMusic { get; }
        List<Multimedia> Queue { get; }

        void Pause();

        void Play();

        void Next();
    
    }
}
