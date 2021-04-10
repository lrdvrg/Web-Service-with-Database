using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;

namespace WSDB
{
    /// <summary>
    /// Descripción breve de BD
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class BD : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public DataSet GetData()
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "data source=AYYDEE/SQLEXPRESS;initial catalog=Notas;integrated security=True;";

            SqlDataAdapter da = new SqlDataAdapter("select * from EstudianteSet", conn);

            DataSet ds = new DataSet();

            da.Fill(ds);

            return ds;
        }
    }
}
