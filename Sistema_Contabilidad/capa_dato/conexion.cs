﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace capa_dato
{
    public class conexion
    {

        // Atributos necesarios para establecer la conexión.
        string servidor;
        public string usuario;
        public string contraseña;
        string nombreBD;
        SqlCommand cmd;

        // Constructor de la clase   Final
        public conexion()
        {//UsuarioBD
           
            servidor = "KL";//nombre de su motor de base de datos si su motor 
            //de base de datos es asi ejenplo(USUARIO -PC\SQLEXPRESS) i les sale error aumentarle una barra(USUARIO-PC\\SQLEXPRESS)
            usuario = "mariac";//el nombre de usuario que crean en su base de datos
            contraseña = "mariac";//la cotrasenadel usuario
            nombreBD = "Sistema_Maria";//nombre de la base de datos
            cmd = new SqlCommand();
        }

        // Métodos propios de la clase
        // Método para conectar
        public SqlConnection conectar()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "server=" + servidor + ";user ID=" + usuario + ";password=" + contraseña + ";database=" + nombreBD;
            conexion.Open();
            return conexion;
        }

        // Setters y Getters propios para conectarse al servidor
        public string Usuario
        {
            set { usuario = value; }
            get { return usuario; }
        }
        public string Contraseña
        {
            set { contraseña = value; }
            get { return contraseña; }
        }



        // Método para desconectar
        public void desconectar()
        {
            SqlConnection conexion = this.conectar();
            conexion.Close();
        }

        public void prepararProcedimientos(string nombre)
        {
            cmd.Connection = this.conectar();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombre;
        }

        public void agregarParametros(string nombre, string valor)
        {
            SqlParameter parametros = new SqlParameter();
            parametros.ParameterName = nombre;
            parametros.Value = valor;
            cmd.Parameters.Add(parametros);
           // cmd.Parameters.Clear();
        }

        public void ejecutarProcedimientos()
        {
            SqlDataReader dr;
            cmd.Prepare();
            dr = cmd.ExecuteReader();
            this.desconectar();
            cmd.Parameters.Clear();
        }

        public void ejecutarConsultas(string nomTable, string consulta, DataSet ds)
        {
            SqlDataAdapter adaptador;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;
            cmd.Connection = this.conectar();
            adaptador = new SqlDataAdapter(cmd);
            adaptador.Fill(ds, nomTable);
            this.desconectar();
            cmd.Parameters.Clear();
        }

        public void ejecutarconsultaparamostrardatos(DataSet nombre1, string ntable)
        {
            SqlDataAdapter sq = new SqlDataAdapter(cmd);
            sq.Fill(nombre1, ntable);

        }

        public static DataSet EjecutarComan(string cmd)
        {/////////////////////////////////////////////////////USUARIO-PC\\SQLEXPRESS
            SqlConnection Con = new SqlConnection("Data Source=KL;Initial Catalog=Sistema_Maria;Integrated Security=True");
            Con.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter dp = new SqlDataAdapter(cmd, Con);

            dp.Fill(ds);
            Con.Close();
            return ds;
        }


    }
}
