using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPersonneLib
{
    public interface IAdresse
    {
        int Id { get; set; }
        string Id_etudiant { get; set; }
        int Id_adresse { get; set; }
        string Avenue { get; set; }
        int Numero_avenue { get; set; }
        string Adresse_complet { get; }
        int Nouveau();
        void Enregistrer(IAdresse adresse);
        void Supprimer(int id);
        List<IAdresse> Adresses();
        IAdresse OneAdresse(int id);
        List<IAdresse> AdressePersonnes(int id_etudiant);
    }
}
