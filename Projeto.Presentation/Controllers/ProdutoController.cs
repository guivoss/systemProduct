using Microsoft.AspNetCore.Mvc;
using Projeto.Data.Contracts;
using Projeto.Data.Entities;
using Projeto.Presentation.Models; //importando a camada de modelo
using System;
using System.Collections.Generic;


//recebe os dados da página 
namespace Projeto.Presentation.Controllers
{
    public class ProdutoController : Controller
    {
        //atributo para o repositório
        private IProdutoRepository repository;

        //construtor para inicializar o atributo repository
        public ProdutoController(IProdutoRepository repository)
        {
            this.repository = repository;
        }

        //tem que ter sempre 2 ActionResult: um que abre a view w outro que recebe os dados
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost] //recebe os dados do formulário pelo controller
        public IActionResult Cadastro(ProdutoCadastroModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Produto produto = new Produto();
                    produto.Nome = model.Nome;
                    produto.Preco = model.Preco;
                    produto.Quantidade = model.Quantidade;

                    //insere os dados do produto na base de dados
                    repository.Inserir(produto);

                    //mensagem enviada com sucesso
                    TempData["Mensagem"] = $"Produto {produto.Nome}, cadastrado com sucesso.";
                    ModelState.Clear(); //limpa os campos do formulário
                }
                catch (Exception e)
                {
                    TempData["Mensagem"] = e.Message;
                }
            }

            return View();
        }

        //default é GET por isso não precisa colocar
        public IActionResult Consulta()
        {

            //criando uma lista da classe de modelo
            List<ProdutoConsultaModel> lista = new List<ProdutoConsultaModel>();
            try
            {
                //varrer os produtos obtidos na consulta ao banco de dados
                foreach (var item in repository.ObterTodos())
                {
                    //adicionar o produto na lista
                    //para isso tem criar uma model
                    ProdutoConsultaModel model = new ProdutoConsultaModel();
                    model.IdProduto = item.IdProduto;
                    model.Nome = item.Nome;
                    model.Preco = item.Preco;
                    model.Quantidade = item.Quantidade;
                    model.Total = item.Preco * item.Quantidade;
                    model.DataCadastro = item.DataCadastro;

                    //pode ter varias models por causa do foreach e ser uma lista
                    lista.Add(model);

                }
            }
            catch (Exception e)
            {

                TempData["Mensagem"] = e.Message;
            }
            //enviar lista para a página
            //quando passa a lista como parametro, a página abre e já exibe a página de consulta
            return View(lista);
        }

        public ActionResult Exclusao(int id)
        {
            try
            {
                repository.Excluir(id);

                TempData["Mensagem"] = "Produto excluído com sucesso.";
            }
            catch (Exception e)
            {

                TempData["Mensagem"] = e.Message;
            }

            //redireciona para a Consulta
            return RedirectToAction("Consulta");
        }

        public ActionResult Edicao(int id)
        {
            //criando um objeto da classe de modelo
            ProdutoEdicaoModel model = new ProdutoEdicaoModel();

            try
            {
                //buscar o produto no banco de dados pelo id
                Produto produto = repository.ObterPorId(id);

                //para exibir os dados na tela
                model.IdProduto = produto.IdProduto;
                model.Nome = produto.Nome;
                model.Preco = produto.Preco;
                model.Quantidade = produto.Quantidade;
            }
            catch (Exception e)
            {
                TempData["Mensagem"] = e.Message;
            }

            //redireciona para a Consulta
            return View(model);
        }

        [HttpPost] //recebe os dados do formulário pelo controller
        public IActionResult Edicao(ProdutoEdicaoModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Produto produto = new Produto();
                    //precisa do id do Prpduto para a edição
                    produto.IdProduto = model.IdProduto;
                    produto.Nome = model.Nome;
                    produto.Preco = model.Preco;
                    produto.Quantidade = model.Quantidade;

                    //insere os dados do produto na base de dados
                    repository.Atualizar(produto);

                    //mensagem enviada com sucesso
                    TempData["Mensagem"] = $"Produto {produto.Nome}, alterado com sucesso.";

                    //excluido ModelState.Clear(); //limpa os campos do formulário
                    return RedirectToAction("Consulta"); //redirecionamento
                }
                catch (Exception e)
                {
                    TempData["Mensagem"] = e.Message;
                }
            }

            return View();
        }
    }
}