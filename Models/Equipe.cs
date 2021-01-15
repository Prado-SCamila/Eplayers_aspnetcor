using System;
using System.Collections.Generic;
using System.IO;
using Eplayers_aspnetcor.Models.Interfaces;

namespace Eplayers_aspnetcor.Models
{
    public class Equipe : EplayersBase,IEquipe
    {
        public int IdEquipe {get;set;}

        public string Nome {get;set;}

        public string Imagem {get;set;}
        
        private const string PATH = "Database/Equipe.csv";

        public Equipe()

        {   //chamou este método dentro do método construtor Equipe
            CreateFolderAndFile(PATH);
            
        }
        //criamos o método para preparar a linha de csv
        public string Prepare(Equipe e)
        {
            return $"{e.IdEquipe};{e.Nome};{e.Imagem}";
        }
        public void Create (Equipe e){
            string[]linhas = {Prepare(e)};
            File.AppendAllLines(PATH,linhas);//mostra as linhas

            
        }

        public List<Equipe> ReadAll()
        {
            List<Equipe> equipes = new List<Equipe>();
            string[] linhas = File.ReadAllLines(PATH);

            foreach(string item in linhas){
                string[] linha = item.Split(";");

            Equipe novaEquipe  = new Equipe();
            novaEquipe.IdEquipe = int.Parse(linha[0]);
            novaEquipe.Nome = linha[1];
            novaEquipe.Imagem = linha[2];

            equipes.Add(novaEquipe);
            }
            return equipes;
        }

        public void Update(Equipe e)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            //Remove a linha que possui o mesmo código que foi comparado
            linhas.RemoveAll(x => x.Split(";")[0] == e.IdEquipe.ToString());
            //Adicionamos na lista a equipe alterada
            linhas.Add( Prepare(e) );
            //Reescreve o csv com a linha alterada
            RewriteCSV(PATH, linhas);
        }

        public void Delete(int id)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[0] == id.ToString());
            RewriteCSV(PATH, linhas);
        }
    }
}