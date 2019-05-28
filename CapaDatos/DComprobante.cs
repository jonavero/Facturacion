using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos
{
    public class DComprobante
    {
        public Comprobante getComprobante( string tipo)
        {
            Comprobante comprobante = new Comprobante();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
               
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand cmd = new SqlCommand("sp_ncf", SqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tipo", tipo);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        comprobante.NFC = dr["NCF"].ToString();
                    }
                }

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        
            return comprobante;
          
        }
    }
}
