using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Eplayers_aspnetcor.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eplayers_aspnetcor.Controllers
{
        [Route("Jogador")]
    public class JogadorController:Controller
    {
    
        Jogador jogadorModel = new Jogador();
        Equipe equipeModel = new Equipe();

        public IActionResult Index(){
            
            ViewBag.Equipes = equipeModel.ReadAll();
            ViewBag.Jogadores = jogadorModel.ReadAll();
            return View();
        }
        [Route("Cadastrar")] // inseri a rota cadastrar
        public IActionResult Cadastrar(IFormCollection form){

            Jogador novoJogador = new Jogador();
            novoJogador.IdJogador = Int32.Parse(form["IdJogador"]);
            novoJogador.Nome = form["Nome"];
            novoJogador.Email = form["Email"];
            novoJogador.Senha = form["Senha"];

            jogadorModel.Create(novoJogador);//o novojogador foi criado e está sendo passado para o jogadorModel.
            ViewBag.Jogadores = jogadorModel.ReadAll();//pois é p jogadorModel que está retornando para a view.

            return LocalRedirect("~/Jogador");
        }
    }
}