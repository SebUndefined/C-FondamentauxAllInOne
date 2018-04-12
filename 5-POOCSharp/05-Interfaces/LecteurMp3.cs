using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Interfaces
{
    //Implémentation implicite
    class LecteurMp3 : ILecteurAudio
    {
        public bool LectureEnCours => throw new NotImplementedException();

        public bool EstEnPause => throw new NotImplementedException();

        public void Lire(string cheminFichier)
        {
            throw new NotImplementedException();
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void ReprendreLecture()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
