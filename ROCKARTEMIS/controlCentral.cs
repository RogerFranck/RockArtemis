using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROCKARTEMIS
{
    class controlCentral
    {
        public List<Multimedia> Queue => throw new NotImplementedException();
        Reproductor reproductor;
        DisplayControl displaycontrol;

        public void Play(Multimedia song)
        {
            reproductor.Play(song);
            displaycontrol.CurrentSong(song);
        }

        public controlCentral()
        {
            DisplayControl displaycontrol = new DisplayControl();
            Reproductor reproductor = new Reproductor();
        }

    }
}
