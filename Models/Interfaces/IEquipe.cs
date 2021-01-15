using System.Collections.Generic;

namespace Eplayers_aspnetcor.Models.Interfaces
{
    public interface IEquipe
    {
         
         //métodos de crud
         void Create (Equipe e);

         List<Equipe> ReadAll();
         
         void Update (Equipe e);

         void Delete(int id);
    }
}
    