using curso.api.Bussines.Entities;
using System.Collections.Generic;

namespace curso.api.Bussines.Repositories
{
    public interface ICursoRespository
    {
        void Adiconar(Curso curso);
        void Commit();
        IList<Curso> ObterPorUsuario(int codigoUsuario);
    }
}
