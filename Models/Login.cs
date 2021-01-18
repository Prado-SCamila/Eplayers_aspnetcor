using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace Eplayers_aspnetcor.Models
{
    public class Login:Controller
    {
        [TempData]
         public string Mensagem { get; set; }

         public IActionResult Logar(IFormCollection form)
{
    
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
    }

    Mensagem = "Dados incorretos, tente novamente...";
    return LocalRedirect("~/Login");
}

     
    }
}