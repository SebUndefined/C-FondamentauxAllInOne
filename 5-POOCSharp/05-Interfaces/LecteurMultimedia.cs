using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Interfaces
{
    class LecteurMultimedia : ILecteurAudio, ILecteurMultimedia
    {
        bool ILecteurAudio.LectureEnCours => throw new NotImplementedException();

        bool ILecteurMultimedia.LectureEnCours => throw new NotImplementedException();

        bool ILecteurAudio.EstEnPause => throw new NotImplementedException();

        bool ILecteurMultimedia.EstEnPause => throw new NotImplementedException();

        bool ILecteurMultimedia.aDesSousTitres => throw new NotImplementedException();

        void ILecteurAudio.Lire(string cheminFichier)
        {
            throw new NotImplementedException();
        }

        void ILecteurMultimedia.Lire(string cheminFichier)
        {
            throw new NotImplementedException();
        }

        void ILecteurAudio.Pause()
        {
            throw new NotImplementedException();
        }

        void ILecteurMultimedia.Pause()
        {
            throw new NotImplementedException();
        }

        void ILecteurAudio.ReprendreLecture()
        {
            throw new NotImplementedException();
        }

        void ILecteurMultimedia.ReprendreLecture()
        {
            throw new NotImplementedException();
        }

        void ILecteurAudio.Stop()
        {
            throw new NotImplementedException();
        }

        void ILecteurMultimedia.Stop()
        {
            throw new NotImplementedException();
        }
    }
}
