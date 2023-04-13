using System;
using System.Collections.Generic;
using lojaroupas.Categoria;
using lojaroupas.Clientes;
using lojaroupas.Produto;
using lojaroupas.Classes;
using lojaroupas.Relatorio;
using lojaroupas.Venda;


static void Main(string[] args)
{
    bool continuar = true;
    do
    {
        Console.Clear();
        Console.WriteLine("1 - Gerenciar produtos");
        Console.WriteLine("2 - Gerenciar categorias");
        Console.WriteLine("3 - Gerenciar clientes");
        Console.WriteLine("4 - Realizar venda");
        Console.WriteLine("5 - Relatório de vendas");
        Console.WriteLine("0 - Sair");
        Console.Write("Escolha uma opção gurizada: ");
        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                GerenciarProdutos();
                break;
            case "2":
                GerenciarCategorias();
                break;
            case "3":
                GerenciarClientes();
                break;
            case "4":
                RealizarVenda();
                break;
            case "5":
                MostrarRelatorioVendas();
                break;
            case "0":
                continuar = false;
                break;
            default:
                Console.WriteLine("Opção incorreta ou inválida!");
                break;
        }
        Console.WriteLine();
        Console.WriteLine("Pressione uma tecla para continuar...");
        Console.ReadKey();
    } while (continuar);
}
