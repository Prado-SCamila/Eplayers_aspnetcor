using System.IO;
using System.Collections.Generic;

namespace Eplayers_aspnetcor.Models
{
    public class EplayersBase
    {
        //declaro o método e passo o path como parÂmetro. E quebro 
        //a parte mais externa do path para transformar em folder e a parte interna vira file.
        // Esse método que foi definido aqui vai ser chamado na classe Equipe no construtor.
        public void CreateFolderAndFile(string _path)
        {
            //Database/Equipe.csv
        string folder = _path.Split("/")[0];//Database
        string file = _path.Split("/")[1]; //Equipe.csv

        if(!Directory.Exists(folder)){

            Directory.CreateDirectory(folder);
        }
        if(!File.Exists(_path)){
            
            File.Create(_path);

        }
      
        }

        public List<string> ReadAllLinesCSV(string path)
        {
            List<string> linhas = new List<string>();
            //using- responsável por abrir e fechar o arquivo automaticamente
             using(StreamReader file = new StreamReader(path))
            {
                string linha;
                while((linha = file.ReadLine()) != null)
                {
                    linhas.Add(linha);
                }
            }
            return linhas;
        }

        public void RewriteCSV(string PATH, List<string> linhas)
        {
            using(StreamWriter output = new StreamWriter(PATH))
            {
                foreach (var item in linhas)
                {
                    output.Write(item + "\n");
                }
            }
        }
        }
    }