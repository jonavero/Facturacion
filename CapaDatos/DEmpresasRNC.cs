using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace CapaDatos
{
    public class DEmpresasRNC
    {
        private int _IdEmpresa;
        private string _NombreEmpresa;
        private string _RNC;

        public int IdEmpresa
        {
            get { return _IdEmpresa; }
            set { _IdEmpresa = value; }
        }
        public string NombreEmpresa
        {
            get { return _NombreEmpresa; }
            set { _NombreEmpresa = value; }
        }
        public string RNC
        {
            get { return _RNC; }
            set { _RNC = value; }
        }

        //Constructores 
        public DEmpresasRNC()
        {

        }

        public DEmpresasRNC(int idEmpresa, string nombreEmpresa 
            ,string RNC)
        {
            this.IdEmpresa = idEmpresa;
            this.NombreEmpresa = nombreEmpresa;
            this.RNC = RNC;
        }

        public void Insertar(DEmpresasRNC empresa)
        {
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand cmd = new SqlCommand("spInsertar_empresaRNC", SqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", empresa.NombreEmpresa);
                cmd.Parameters.AddWithValue("@RNC", empresa.RNC);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("empresasRNC");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spMostrar_RNC";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);

                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }


        public DataTable BuscarPorRNC(string RNC)
        {
            DataTable DtResultado = new DataTable("cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spBuscarPorRNC";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@RNC";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 25;
                ParTextoBuscar.Value = RNC;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }
    }
}
