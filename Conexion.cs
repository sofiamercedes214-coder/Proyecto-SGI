using System;
using System.Configuration;
using System.Data.SqlClient;

public static class Conexion
{
    public static SqlConnection ObtenerConexion()
    {
        string cadena = ConfigurationManager.ConnectionStrings["ConexionSGI"].ConnectionString;
        return new SqlConnection(cadena);
    }
}