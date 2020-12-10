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

        void Pause();

        void Play(Multimedia song);

        void Next();

        void Stop();
    
    }
}
