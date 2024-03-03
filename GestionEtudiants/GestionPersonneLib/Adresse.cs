using GestionEtudiantUtilitiesLib;
using ManageSingleConnexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPersonneLib
{
    public class Adresse : IAdresse
    {
        public Adresse()
        {
        }

        private int _id;
        private string _id_etudiant;
        private int _id_adresse;
        private string _avenue;
        private int _numero_avenue;

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Id_etudiant
        {
            get
            {
                return _id_etudiant;
            }

            set
            {
                _id_etudiant = value;
            }
        }

        public int Id_adresse
        {
            get
            {
                return _id_adresse;
            }

            set
            {
                _id_adresse = value;
            }
        }

        public string Avenue
        {
            get
            {
                return _avenue;
            }

            set
            {
                _avenue = value;
            }
        }

        public int Numero_avenue
        {
            get
            {
                return _numero_avenue;
            }

            set
            {
                _numero_avenue = value;
            }
        }

        public string Adresse_complet
        {
            get
            {
                return this._avenue + this._numero_avenue;
            }
        }

        public int Nouveau()
        {
            int id = 0;

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                cmd.CommandText = "select max(id) as lastId from domicile";

                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    if (rd["lastId"] == DBNull.Value)
                        id = 1;
                    else
                        id = Convert.ToInt32(rd["lastId"].ToString()) + 1;
                }

                rd.Dispose();
            }

            return id;
        }

        public void Enregistrer(IAdresse adresse)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                /*
                cmd.CommandText = "sp_insert_domicile";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, _id));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@id_etudiant", 4, DbType.String, _id_etudiant));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@id_adresse", 4, DbType.Int32, _id_adresse));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@avenue", 9, DbType.String, _avenue));
                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@numero_avenue", 9, DbType.String, _numero_avenue));

                cmd.ExecuteNonQuery();*/
            }
        }

        public void Supprimer(int id)
        {
            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                /* cmd.CommandText = "sp_delete_domicile";
                 cmd.CommandType = CommandType.StoredProcedure;

                 cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, _id));

                 int record = cmd.ExecuteNonQuery();

                 if (record == 0)
                     throw new InvalidOperationException("That id does not exist !!!");*/
            }
        }

        private IAdresse GetPhone(IDataReader rd)
        {
            IAdresse adresse = new Adresse();/*

            adresse.Id = int.Parse(rd["id"].ToString());
            adresse.Id_etudiant = rd["id_etudiant"].ToString();
            adresse.Id_adresse = Convert.ToInt32(rd["id_adresse"].ToString());
            adresse.Avenue = rd["avenue"].ToString();
            adresse.Numero_avenue = int.Parse(rd["numero_avenue"].ToString());
            */
            return adresse;
        }

        public List<IAdresse> Adresses()
        {
            List<IAdresse> lst = new List<IAdresse>();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                /*cmd.CommandText = "sp_select_domiciles";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    lst.Add(GetPhone(rd));
                }

                rd.Dispose();*/
            }

            return lst;
        }

        public IAdresse OneAdresse(int id)
        {
            IAdresse adresse = new Adresse();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
                /*cmd.CommandText = "sp_select_domicile";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@id", 4, DbType.Int32, id));

                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    telephone = GetPhone(rd);
                }

                rd.Dispose();*/
            }

            return adresse;
        }

        public List<IAdresse> AdressePersonnes(int id_etudiant)
        {
            List<IAdresse> lst = new List<IAdresse>();

            if (ImplementeConnexion.Instance.Conn.State == ConnectionState.Closed)
                ImplementeConnexion.Instance.Conn.Open();

            using (IDbCommand cmd = ImplementeConnexion.Instance.Conn.CreateCommand())
            {
               /* cmd.CommandText = "sp_select_domiciles_etudiant";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametres.Instance.AjouterParametre(cmd, "@id_etudiant", 4, DbType.String, id_etudiant));

                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    lst.Add(GetPhone(rd));
                }

                rd.Dispose();*/
            }

            return lst;
        }
    }
}
