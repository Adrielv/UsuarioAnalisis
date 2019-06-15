using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions; 
using System.Data.Entity;
using UsuarioAnalisis.DAL;
using UsuarioAnalisis.Entidades;

namespace UsuarioAnalisis.BLL
{
    public class CargoBLL
    {
        public static bool Guardar(Cargos cargos)
        {
            bool paso = false;
            ContextoC db = new ContextoC();
            try
            {
                if (db.Cargos.Add(cargos) != null)

                    paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;

        }
        public static bool Modificar(Cargos cargos)
        {
            bool paso = false;
            ContextoC db = new ContextoC();
            try
            {
                db.Entry(cargos).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;


        }
        public static bool Eliminar(int id)
        {
            bool paso = false;
            ContextoC db = new ContextoC();
            try
            {
                var eliminar = db.Cargos.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;

                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }
        public static Cargos Buscar(int id)
        {

            ContextoC db = new ContextoC();
            Cargos cargos = new Cargos();

            try
            {
                cargos = db.Cargos.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return cargos;

        }
        public static List<Cargos> GetList(Expression<Func<Cargos, bool>> cargos)
        {
            List<Cargos> Lista = new List<Cargos>();
            ContextoC db = new ContextoC();
            try
            {
                Lista = db.Cargos.Where(cargos).ToList();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }
    }
}
