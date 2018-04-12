using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Interfaces
{
    interface ILecteurMultimedia
    {
        bool LectureEnCours { get; }

        bool EstEnPause { get; }

        bool aDesSousTitres { get; }

        void Lire(string cheminFichier);

        void Pause();

        void ReprendreLecture();

        void Stop();
    }
}
