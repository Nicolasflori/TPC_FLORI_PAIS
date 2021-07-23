﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NegocioUsuarios
    {
        public void agregar(Usuarios nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores = "values(" + "'" + nuevo.Usuario + "'" + ", '" + nuevo.Contraseña + "'" + ", '" + nuevo.Nombre + "'" + ", '" + nuevo.Apellido + "'" + ", '" + nuevo.Email + "')";
                datos.setearConsulta("insert into Usuarios (Usuario, Contraseña, Nombre, Apellido, Email)" + valores);
                datos.ejectutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Usuarios usuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE Usuarios SET Nombre = @nombre, Apellido = @apellido, Email = @email, DNI = @dni, Telefono = @telefono WHERE ID = @id");
                datos.agregarParametro("@nombre", usuario.Nombre);
                datos.agregarParametro("@apellido", usuario.Apellido);
                datos.agregarParametro("@email", usuario.Email);
                datos.agregarParametro("@dni", usuario.DNI);
                datos.agregarParametro("@telefono", usuario.Telefono);
                datos.agregarParametro("@id", usuario.ID);
                datos.ejectutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool loguear(Usuarios usuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, IDPermiso FROM Usuarios WHERE Usuario = @Usuario AND Contraseña = @Contraseña");
                datos.agregarParametro("@Usuario", usuario.Usuario);
                datos.agregarParametro("@Contraseña", usuario.Contraseña);

                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    usuario.ID = (int)datos.Lector["ID"];
                    usuario.IDPermiso = (int)datos.Lector["IDPermiso"];
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public bool chequearDireccion(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            int? direccion = null;
            try
            {
                datos.setearConsulta("SELECT IDDireccion FROM Usuarios WHERE ID = @id");
                datos.agregarParametro("@id", id);
                datos.ejecutarLectura();

                datos.Lector.Read();
                direccion = (int?)datos.Lector["IDDireccion"];

                if(direccion == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int getIDDireccion(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            int IDDireccion;
            try
            {
                datos.setearConsulta("SELECT IDDireccion FROM Usuarios WHERE ID = @id");
                datos.agregarParametro("@id", id);
                datos.ejecutarLectura();

                datos.Lector.Read();
                IDDireccion = (int)datos.Lector["IDDireccion"];

                return IDDireccion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
