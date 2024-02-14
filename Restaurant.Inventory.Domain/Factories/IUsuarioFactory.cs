using Restaurant.Inventory.Domain.Model.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Inventory.Domain.Factories
{
    public interface IUsuarioFactory
    {
        Usuario CreateUsuario(string nombre, string correo, string contrasenha);
    }
}
