using Restaurant.Inventory.Domain.Model.Lugar;
using Restaurant.Inventory.Domain.Model.Reunion;
using Restaurant.Inventory.Domain.Model.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurtant.Inventory.Infrastructure.MemoryPersistence
{
    internal class MemoryDatabase
    {
        private readonly List<Reunion> reuniones;
        private readonly List<Usuario> usuarios;
        private readonly List<Lugar> lugares;

        public List<Reunion> Reuniones { get { return reuniones; } }
        public List<Usuario> Usuarios { get { return usuarios; } }
        public List<Lugar> Lugares { get { return lugares; } }


        public MemoryDatabase()
        {
            // Inicializar las listas con algunos datos predeterminados
           

            usuarios = new List<Usuario>
            {
                new Usuario("a3cf721f-efc1-4ee3-b2b1-5a16b54727c5", "marco", "Marco@gmail.com", "Marco123"),
                new Usuario("4abcf182-5ef0-4d9e-a07a-8d9d3a874812", "lucas", "Lucas@gmail.com", "Lucas123"),
                new Usuario("cf6f005d-b570-47bb-b8a0-d07a9d5cf9d2", "isabel", "Isabel@gmail.com", "Isabel123")
            };

            lugares = new List<Lugar>
            {
                new Lugar("8f6d514d-0c95-4a61-b9e5-2b0973c82e69", "sala1", "esta es sala 1", "sala1.com"),
                new Lugar("b6e34679-10c5-4e50-af72-0d5840a17ed3", "sala2", "esta es sala 2", "sala2.com"),
                new Lugar("97b18eef-7459-4b4b-91de-20946a12b2f6", "sala3", "esta es sala 3", "sala3.com")
            };
            reuniones = new List<Reunion>();
        }
    }
}
