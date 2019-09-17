﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Carreras
    {
        CDConexion conexion = new CDConexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public void AgregarCarrera(string nombre, int coordinador)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando = new SqlCommand("insert into carreras(nombre,coordinador) values(@nombre,@coordinador);");
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@coordinador", coordinador);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }

        public void EditarCarrera(int idCarrera, string nombre, int coordinador)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando = new SqlCommand("update calles set nombre=@nombre, coordinador=@coordinador where idCarrera=@idCarrera");
            comando.Parameters.AddWithValue("@idCarrera", idCarrera);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@coordinador", coordinador);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }

        public void ElimnarCarrera(int idCarrera)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.Parameters.Clear();
            comando = new SqlCommand("DELETE FROM carreras WHERE idCarrera=@idCarrera");
            comando.Parameters.AddWithValue("@idCarrera", idCarrera);
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }
    }
}