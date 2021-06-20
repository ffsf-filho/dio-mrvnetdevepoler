using curso.api.Bussines.Entities;
using curso.api.Bussines.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace curso.api.Infraestrutura.Data.Repositories
{
    public class CursoRespository : ICursoRespository
    {
        private readonly CursoDbContext _contexto;

        public CursoRespository(CursoDbContext contexto)
        {
            _contexto = contexto;
        }

        public void Adiconar(Curso curso)
        {
            _contexto.Curso.Add(curso);
        }

        public void Commit()
        {
            _contexto.SaveChanges();
        }

        public IList<Curso> ObterPorUsuario(int codigoUsuario)
        {
            return _contexto.Curso.Include(i => i.Usuario).Where(w => w.CodigoUsuario == codigoUsuario).ToList();
        }
    }
}
