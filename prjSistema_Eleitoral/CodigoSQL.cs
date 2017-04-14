using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace prjSistema_Eleitoral
{
    public static class CodigoSQL
    {
        //Campos
        private static MySqlCommand _comando;

        //Propriedades
        public static MySqlConnection conexao { get; set; }
        
        public static MySqlCommand comando 
        { 
            get { return _comando; }
            set
            {
                _comando = value;
                if (comando.CommandText.ToLower().Substring(0, 6) == "select")
                {
                    Ler = comando.ExecuteReader();
                }
                if (comando.CommandText.ToLower().Substring(0, 6) == "insert" || comando.CommandText.ToLower().Substring(0, 6) == "delete")
                {
                    comando.ExecuteNonQuery();
                }
            }
        }

        public static MySqlDataReader Ler { get; set; }

        public static string usuario { get; set; }
    }
}
