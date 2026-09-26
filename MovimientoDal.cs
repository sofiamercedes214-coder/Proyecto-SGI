using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Menu_principal
{
    public class MovimientoDal
    {
        
        public List<Movimiento> Listar()
        {
            List<Movimiento> lista = new List<Movimiento>();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ListarMovimientos", con);
                cmd.CommandType = CommandType.StoredProcedure;

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
                                Motivo = reader["TipoMovimiento"].ToString() ?? "",
                                fecha = Convert.ToDateTime(reader["Fecha"]),
                                Idproveedor = Convert.ToInt32(reader["IdProveedor"]),
                               
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar movimientos: " + ex.Message);
                }
            }
            return lista;
        }

        // 2. Insertar movimiento usando el Procedimiento Almacenado
        public bool Insertar(Movimiento mov)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarMovimiento", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdTipoMovimiento", mov.IdTipoMovimiento);
                cmd.Parameters.AddWithValue("@Fecha", mov.fecha);
                cmd.Parameters.AddWithValue("@Motivo", mov.Motivo);
                cmd.Parameters.AddWithValue("@IdProveedor", mov.Idproveedor);

                try
                {
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al insertar movimiento: " + ex.Message);
                }
            }
        }

        // 3. Actualizar movimiento usando el Procedimiento Almacenado
        public bool Actualizar(Movimiento mov)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarMovimiento", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdMovimiento", mov.IdMovimiento);
                cmd.Parameters.AddWithValue("@IdTipoMovimiento", mov.IdTipoMovimiento);
                cmd.Parameters.AddWithValue("@Fecha", mov.fecha);
                cmd.Parameters.AddWithValue("@Motivo", mov.Motivo);
                cmd.Parameters.AddWithValue("@IdProveedor", mov.Idproveedor);

                try
                {
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar movimiento: " + ex.Message);
                }
            }
        }

        // 4. Eliminar movimiento usando el Procedimiento Almacenado
        public bool Eliminar(int idMovimiento)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarMovimiento", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdMovimiento", idMovimiento);

                try
                {
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar movimiento: " + ex.Message);
                }
            }
        }

        // 5. Buscar o filtrar movimientos usando el Procedimiento Almacenado
        public List<Movimiento> Buscar(string criterio)
        {
            List<Movimiento> lista = new List<Movimiento>();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_BuscarMovimiento", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Criterio", criterio);

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
                                Motivo = reader["TipoMovimiento"].ToString() ?? "",
                                fecha = Convert.ToDateTime(reader["Fecha"]),
                                Idproveedor = Convert.ToInt32(reader["IdProveedor"]),
                                
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al buscar movimiento: " + ex.Message);
                }
            }
            return lista;
        }
        // Método para llenar el ComboBox de Tipos de Movimiento
        public DataTable ConsultarTipos()
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT IdTipoMovimiento, Descripcion FROM TipoMovimiento", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Método para llenar el ComboBox de Proveedores
        public DataTable ConsultarProveedores()
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT IdProveedor, Empresa FROM Proveedor", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}