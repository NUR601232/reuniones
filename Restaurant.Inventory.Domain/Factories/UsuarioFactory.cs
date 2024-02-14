using Restaurant.Inventory.Domain.Model.Lugar;
using Restaurant.Inventory.Domain.Model.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Restaurant.Inventory.Domain.Factories
{
    public class UsuarioFactory : IUsuarioFactory
    {
      

        public Usuario CreateUsuario(string nombre, string correo, string contrasenha)
        {
            return new Usuario(nombre, correo, contrasenha);
        }
    }
}
