using Eplayers_aspnetcor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Eplayers_aspnetcor.Controllers
{

    [Route("Equipe")]
    public class EquipeController: Controller
    {
        Equipe equipeModel = new Equipe();

      [Route("Listar")]

        public IActionResult Index(){

            //Listamos todas as equipes e enviamos para a view, através da viewbag
            ViewBag.equipes = equipeModel.ReadAll();
            return View();
        }

          [Route("Cadastrar")]

        public IActionResult Cadastrar(IFormCollection form){//objeto form do tipo IformCollection tem a propriedade File(lista)

            Equipe novaEquipe = new Equipe();
            novaEquipe.IdEquipe = int.Parse(form["IdEquipe"]);
            novaEquipe.Nome = form["Nome"];
          

          //upload início - se estiver vazio os Files, existem 0 arquivos dentro dele. o Count é 0.
            if(form.Files.Count > 0){//verifica se o usuário enviou um arquivo

            var file = form.Files[0];//pega o arquivo que a pessoa enviou e coloca na variável file na posição 0.
            var folder = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/img/Equipes");
            //dentro do diretório wwwroot eu crio uma pasta img e dentro terá Equipes.

            if(!Directory.Exists(folder)){

              Directory.CreateDirectory(folder);
            }
   //Directory.GetCurrentDirectory() é o domínio atual (hospedagem) folder=Equipes, file.FileNAme = imagem.jpg
              var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/img/",folder,file.FileName);
              using(var stream = new FileStream(path, FileMode.Create)){
                file.CopyTo(stream);
              }
              novaEquipe.Imagem = file.FileName;
            }
            else{
              novaEquipe.Imagem = "padrao.png";
            }

            equipeModel.Create(novaEquipe);
            ViewBag.equipes = equipeModel.ReadAll();

            //Redirecionar para a mesma página onde estamos. ~ indica root, raiz.
            return LocalRedirect("~/Equipe/Listar");
        }
    

            [Route("{id}")]
            public IActionResult Excluir(int id){

              equipeModel.Delete(id);
              //esse processo da viewBag serve pra atualizar a página depois da alteração.
              ViewBag.equipes = equipeModel.ReadAll();

            //Redirecionar para a mesma página onde estamos. ~ indica root, raiz.
            return LocalRedirect("~/Equipe/Listar");
            }
    }
}
