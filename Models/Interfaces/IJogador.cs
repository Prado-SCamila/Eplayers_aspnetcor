using System.Collections.Generic;
using Eplayers_aspnetcor.Models;


namespace Eplayers_aspnetcor.Models.Interfaces
{
    public interface IJogador
    {
         //chama métodos CRUD

        //CRIAR
         void Create(Jogador j);
         //LER
         List<Jogador> ReadAll();
        //Alterar
        void Update(Jogador j);
        //Excluir
        void Delete(int id);


    }
}