﻿using ManageSingleConnexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Connexion connection = new Connexion();

                connection.Serveur = @"DESKTOP-SA1U7NB";
                connection.Database = "gestion_etudiant";
                connection.User = "sa";
                connection.Password = "styve7";

                ImplementeConnexion.Instance.Initialise(connection, ConnexionType.SQLServer);

                if (ImplementeConnexion.Instance.Conn.State == System.Data.ConnectionState.Closed)
                    ImplementeConnexion.Instance.Conn.Open();

                Console.WriteLine("Connection Successfuly !!!");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Connection error, " + ex.Message);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("Connection error, " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection error, " + ex.Message);
            }
            finally
            {
                if (ImplementeConnexion.Instance.Conn != null)
                {
                    if (ImplementeConnexion.Instance.Conn.State == System.Data.ConnectionState.Open)
                        ImplementeConnexion.Instance.Conn.Close();
                }
            }

            Console.ReadLine();
        }
    }
}
