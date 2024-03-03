using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPersonneLib
{
    public interface IPersonne
    {
        int Id { get; set; }
        string Matricule { get; set; }
        string Nom { get; set; }
        string Postnom { get; set; }
        string Prenom { get; set; }
        Sexe Sex { get; set; }
        string NomComplet { get; }
        List<ITelephone> TelephonePersonnes { get; }
        int Nouveau();
        void Enregistrer(IPersonne personne);
        void Supprimer(string matricule);
        List<IPersonne> Personnes();
        IPersonne OnePersonne(string matricule);
    }
}
