using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Datos
{
    public static class CategoriaDatos
    {
        public static CategoriaEntidades Nuevo(CategoriaEntidades categoria)
        {
            try
            {
                Categorias categoriaLQ = new Categorias();
                categoriaLQ.id = categoria.Id;
                categoriaLQ.nombre = categoria.Nombre;
                categoriaLQ.descripcion = categoria.Descripcion;

                using (var ctx = new DataClasses1DataContext())
                {
                    ctx.Categorias.InsertOnSubmit(categoriaLQ);
                    ctx.SubmitChanges();
                }

                categoria.Id = categoriaLQ.id;
                return categoria;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static CategoriaEntidades Actualizar(CategoriaEntidades categoria)
        {
            try
            {
                using (var ctx = new DataClasses1DataContext())
                {
                    var categoriasLQ = ctx.Categorias.FirstOrDefault(p => p.id == categoria.Id);
                    categoriasLQ.id = categoria.Id;
                    categoriasLQ.nombre = categoria.Nombre;
                    categoriasLQ.descripcion = categoria.Descripcion;

                    ctx.SubmitChanges();
                }
                return categoria;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<CategoriaEntidades> DevolverListaCategoria()
        {
            List<CategoriaEntidades> listaCategoriasEntidad = new List<CategoriaEntidades>();
            List<Categorias> listaCategoriasLQ = new List<Categorias>();

            using (var ctx = new DataClasses1DataContext())
            {
                var resultado = from p in ctx.Categorias
                                select p;

                listaCategoriasLQ = resultado.ToList();
            }

            foreach (var item in listaCategoriasLQ)
            {
                listaCategoriasEntidad.Add(new CategoriaEntidades(
                    item.id,
                    item.nombre,
                    item.descripcion
                    ));
            }

            return listaCategoriasEntidad;
        }

        public static bool EliminarCategoriaPorId(int identificador)
        {
            try
            {
                using (var ctx = new DataClasses1DataContext())
                {
                    var categoriaLQ = ctx.Categorias.FirstOrDefault(p => p.id == identificador);
                    ctx.Categorias.DeleteOnSubmit(categoriaLQ);
                    ctx.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        public static CategoriaEntidades DevolverCategoriaPorNombre(string nombreCategoria) 
        {
                try
                {
                    CategoriaEntidades categoria = new CategoriaEntidades();
                    using (var ctx = new DataClasses1DataContext())
                    {
                        var categoriaLQ = ctx.Categorias.FirstOrDefault(c => c.nombre.Equals(nombreCategoria));

                        if (categoriaLQ != null)
                        {
                            categoria.Id = categoriaLQ.id;
                            categoria.Nombre = categoriaLQ.nombre;
                            categoria.Descripcion = categoriaLQ.descripcion;
                            return categoria;
                        }
                        return null;

                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            
        }
    }
}
