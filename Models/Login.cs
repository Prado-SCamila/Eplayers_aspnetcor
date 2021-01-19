using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using Eplayers_aspnetcor.Models;
using Eplayers_aspnetcor.Controllers;

namespace Eplayers_aspnetcor.Models
{
    public class Login:Controller
    {
        [TempData]
         public string Mensagem { get; set; }

         public IActionResult Logar(IFormCollection form)
{
    Jogador jogadorModel = new Jogador();
    // Lemos todos os arquivos do CSV
    List<string> csv = jogadorModel.ReadAllLinesCSV("Database/Jogador.csv");

    // Verificamos se as informações passadas existe na lista de string
    var logado = 
    csv.Find(
        x => 
        x.Split(";")[2] == form["Email"] && 
        x.Split(";")[3] == form["Senha"]
    );


    // Redirecionamos o usuário logado caso encontrado
    if(logado != null)
    {
        return LocalRedirect("~/");
    }else{

    Mensagem = "Dados incorretos, tente novamente...";
    return LocalRedirect("~/Login");
    }

}
    }
}
