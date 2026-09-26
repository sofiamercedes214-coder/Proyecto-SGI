using Menu_principal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class MovimientoDAL
{
  
    public List<Movimiento> ConsultarTodos()
    {
        List<Movimiento> lista = new List<Movimiento>();

        using (SqlConnection con = Conexion.ObtenerConexion())
        {
            string query = "SELECT IdMovimiento, IdTipoMovimiento, Fecha, Motivo, IdProveedor FROM Movimiento";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Movimiento
                        {
                            IdMovimiento = Convert.ToInt32(reader["IdMovimiento"]),
                            IdTipoMovimiento = Convert.ToInt32(reader["IdTipoMovimiento"]),
                            fecha = Convert.ToDateTime(reader["Fecha"]),
                            Motivo = reader["Motivo"].ToString(),
                            Idproveedor = Convert.ToInt32(reader["IdProveedor"])
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar movimientos: " + ex.Message);
            }
        }
        return lista;
    }

    // Método para insertar un movimiento
    public bool Insertar(Movimiento mov)
    {
        using (SqlConnection con = Conexion.ObtenerConexion())
        {
            string query = "INSERT INTO Movimiento (IdTipoMovimiento, Fecha, Motivo, IdProveedor) VALUES (@idTipo, @fecha, @motivo, @idProv)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@idTipo", mov.IdTipoMovimiento);
            cmd.Parameters.AddWithValue("@fecha", mov.fecha);
            cmd.Parameters.AddWithValue("@motivo", mov.Motivo);
            cmd.Parameters.AddWithValue("@idProv", mov.Idproveedor);

            try
            {
                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar movimiento: " + ex.Message);
            }
        }
    }
    // Método para obtener los tipos de movimiento
    public DataTable ConsultarTipos()
    {
        DataTable dt = new DataTable();
        using (SqlConnection con = Conexion.ObtenerConexion())
        {
            // Cambiado 'Nombre' por 'Descripcion'
            string query = "SELECT IdTipoMovimiento, Descripcion FROM TipoMovimiento";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
        }
        return dt;
    }

    public DataTable ConsultarMovimientos()
    {
        DataTable dt = new DataTable();
        using (SqlConnection con = Conexion.ObtenerConexion())
        {
            // Usamos LEFT JOIN para evitar errores si algún proveedor o tipo viene nulo
            string query = @"SELECT 
                            m.IdMovimiento AS Id,
                            ISNULL(t.Descripcion, 'Sin definir') AS [Tipo de movimiento],
                            m.Fecha,
                            ISNULL(p.Empresa, 'Sin proveedor') AS [Id Proveedor],
                            ISNULL(m.Motivo, '') AS Motivo
                         FROM Movimiento m
                         LEFT JOIN TipoMovimiento t ON m.IdTipoMovimiento = t.IdTipoMovimiento
                         LEFT JOIN Proveedor p ON m.IdProveedor = p.IdProveedor";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
        }
        return dt;
    }
    public DataTable ConsultarProveedores()
    {
        DataTable dt = new DataTable();
        using (SqlConnection con = Conexion.ObtenerConexion())
        {
            string query = "SELECT IdProveedor, Empresa FROM Proveedor";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
        }
        return dt;
    }
    public bool EditarMovimiento(int idMovimiento, int idTipoMovimiento, DateTime fecha, string motivo, int idProveedor)
    {
        using (SqlConnection con = Conexion.ObtenerConexion())
        {
            string query = @"UPDATE Movimiento 
                         SET IdTipoMovimiento = @idTipo, 
                             Fecha = @fecha, 
                             Motivo = @motivo, 
                             IdProveedor = @idProveedor 
                         WHERE IdMovimiento = @id";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@idTipo", idTipoMovimiento);
            cmd.Parameters.AddWithValue("@fecha", fecha);
            cmd.Parameters.AddWithValue("@motivo", motivo);
            cmd.Parameters.AddWithValue("@idProveedor", idProveedor);
            cmd.Parameters.AddWithValue("@id", idMovimiento);

            return cmd.ExecuteNonQuery() > 0;
        }
    }

    public bool EliminarMovimiento(int idMovimiento)
    {
        using (SqlConnection con = Conexion.ObtenerConexion())
        {
          
            string queryDetalle = "DELETE FROM Detalle_Movimiento WHERE IdMovimiento = @id";
            SqlCommand cmdDetalle = new SqlCommand(queryDetalle, con);
            cmdDetalle.Parameters.AddWithValue("@id", idMovimiento);
            cmdDetalle.ExecuteNonQuery();

            // Luego eliminamos el movimiento
            string query = "DELETE FROM Movimiento WHERE IdMovimiento = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", idMovimiento);

            return cmd.ExecuteNonQuery() > 0;
        }
    }
}