using System.Collections.Generic;
using MascotaWeb.App.Dominio;

namespace MascotaWeb.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMascotas
    {
        IEnumerable<Datos> GetAll();
    }
}