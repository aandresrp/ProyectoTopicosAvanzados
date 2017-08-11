using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Ulatina.Topicos.GenericRepository;

namespace Model.Dominio.Repositorio
{
    internal class Articulo
    {
        private static DbContext miContexto;

        private readonly EntityFrameworkRepository<DbContext> _Repository;

        private readonly string _includeTables = "Articulo, EstadoArticulo, Permiso, Persona";
        private readonly string _noIncludeTables = string.Empty;

        public Articulo()
        {
            miContexto = new ProyectoFinalEntities();
            _Repository = NewMethod();
        }

        private static EntityFrameworkRepository<DbContext> NewMethod()
        {
            return new EntityFrameworkRepository<DbContext>(miContexto);
        }

        public Articulo(DbContext elContexto)
        {
            miContexto = elContexto;
            _Repository = new EntityFrameworkRepository<DbContext>(miContexto);
        }

        internal IList<Articulo> ConsultaPorNombreDeProducto(string elNombreDelProducto)
        {
            // para usar el .ToList(), se requiere haber incluido el System.Linq;
            var losProductos = _Repository.Get<Articulo>(p => p.Name.Contains(elNombreDelProducto), null, _includeTables, null, null).ToList();
            return losProductos;
        }

        internal Articulo ConsultaProductosPorNumero(string miNumeroDeProducto)
        {
            var elArticulo = _Repository.GetOne<Articulo>(p => p.ProductNumber.Equals(miNumeroDeProducto), _includeTables);
            return elArticulo;
        }

        internal IList<Product> ListarProductos()
        {
            // para usar el .ToList(), se requiere haber incluido el System.Linq;
            var losProductos = _Repository.GetAll<Product>(null, _includeTables, null, null).ToList();
            return losProductos;
        }
    }
}
