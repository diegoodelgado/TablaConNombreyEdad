using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablaconNomyEdad_DADR.Modelo;

namespace TablaconNomyEdad_DADR.Dato
{
    public class Usuario
    {
        List<UsuarioModel> lista = new List<UsuarioModel>();
        /// <summary>
        /// Guarda los usuarios
        /// </summary>
        /// <param name="modelo">datos del usuario</param>
        public void Guardar(UsuarioModel modelo)
        {
            lista.Add(modelo);
        }
        /// <summary>
        /// Consulta todos los usuarios
        /// </summary>
        /// <returns>datos de usuarios</returns>
        public List<UsuarioModel> Consultar()
        {
            return lista;
        }
    }
}
