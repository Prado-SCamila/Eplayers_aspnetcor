using System;
using System.Collections.Generic;
using Eplayers_aspnetcor.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Eplayers_aspnetcor.Controllers
{

    [Route("Login")]

    public class LoginController: Controller
    {
        [TempData]
        public string Mensagem {get;set;}
        Jogador jogadorModel = new Jogador();

        public IActionResult Index()
        {
            return View();
        }

        [Route("Logar")]
        public IActionResult Logar(IFormCollection form)
        {
            List<string> csv = jogadorModel.ReadAllLinesCSV(jogadorModel.PATH);
           var logado = 
        csv.Find(
        x => 
        x.Split(";")[2] == form["Email"] && 
        x.Split(";")[3] == form["Senha"]
        );

        //redirecionamos o usuário logado, caso encontrado
        if(logado!=null){
            //criamos a sessão com os dados do usuário
            HttpContext.Session.SetString("_Username",logado.Split(";")[1]);//nno índice 1 está o nome
            return LocalRedirect("~/");
        }

        Mensagem = "dados incorretos, tentar novamente...";
            return LocalRedirect("~/");// volta para a Home
        }
        [Route("Logout")]
        public IActionResult Logout(){
            HttpContext.Session.Remove("_UserName");
            return LocalRedirect("~/");

        }
    }
}