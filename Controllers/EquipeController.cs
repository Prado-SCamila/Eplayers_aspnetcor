using Eplayers_aspnetcor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
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

        public IActionResult Cadastrar(IFormCollection form){

            Equipe novaEquipe = new Equipe();
            novaEquipe.IdEquipe = int.Parse(form["IdEquipe"]);
            novaEquipe.Nome = form["Nome"];
            novaEquipe.Imagem = form["Imagem"];

            equipeModel.Create(novaEquipe);
            ViewBag.equipes = equipeModel.ReadAll();

            //Redirecionar para a mesma página onde estamos. ~ indica root, raiz.
            return LocalRedirect("~/Equipe");
        }


    }
}