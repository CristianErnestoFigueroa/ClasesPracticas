using CristianPracticas.DAO;
using CristianPracticas.DOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CristianPracticas.NEGOCIO
{
    class ClsLogin
    {
        public int Acceso(Login log)
        {
            ClsListaUsuarios cls = new ClsListaUsuarios();

            int estado = 0;
            for (int i = 0; i < cls.Users.Length; i++)
            {
                if (log.Usuario.Equals(cls.Users[i]) && log.Password.Equals(cls.Passwords[i]))
                {
                    estado = 1;
                }
            }
            return estado;


