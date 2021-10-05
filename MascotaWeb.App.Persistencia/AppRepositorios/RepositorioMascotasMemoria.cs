using System.Collections.Generic;
using MascotaWeb.App.Dominio;

namespace MascotaWeb.App.Persistencia.AppRepositorios
{
    public class RepositoriosMascotasMemoria : IRepositorioMascotas
    {
        List<Datos> dato;

        public RepositoriosMascotasMemoria()
        {
            dato=new List<Datos>()
            {
                new Datos{Id=1, Nombre="Tony", Especie="Perro", Raza="Criollo", Edad=10},
                new Datos{Id=2, Nombre="Lala", Especie="Gato", Raza="Tigrillo", Edad=7},
                new Datos{Id=3, Nombre="Goliath", Especie="Perro", Raza="Labrador", Edad=12}
            };
        }
        public IEnumerable<Datos> GetAll()
        {
            return dato;
        }
    }
}