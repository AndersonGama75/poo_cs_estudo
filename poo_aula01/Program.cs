using System;
using System.Linq;

namespace poo_aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Loja.Classes.Cliente cli3 = new Loja.Classes.Cliente(1))
            {
                cli3.Nome = "Georgia";
            }

            try
            {
                Loja.Classes.Cliente cli = new Loja.Classes.Cliente();
                //cli.Codigo = 1;
                //cli.Nome = "João";
                //cli.Tipo = 1;
                //cli.DataCadastro = new DateTime(2020, 07, 16);
                cli.Codigo = 2;
                cli.Nome = "Camila";
                cli.Tipo = 2;
                cli.DataCadastro = new DateTime(2020, 07, 19);
                cli.Dispose();
            }
            catch (Loja.Excecoes.ValidacaoException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //double metodoCliente = MetodoExtensao.metade(cli.Codigo.Value);
            //double juros = MetodoExtensao.juros(cli.Codigo.Value);
            //string palavra = MetodoExtensao.primeiraMaiuscula("jABUTI");
            //Console.WriteLine($"Método divisão: {MetodoExtensao.metade(3)} e {metodoCliente} e juros de 10%: {juros}");
            //Console.WriteLine($"Primeira maiúscula: {palavra}");


            using (Loja.Classes.Cliente cli2 = new Loja.Classes.Cliente(5))
            {
                cli2.Nome = "ABCD";
            }
            

            Loja.Classes.Contato contato = new Loja.Classes.Contato();
            contato.Codigo = 1;
            contato.DadosContato = "12345-6780";
            contato.Tipo = "Telefone";

            //cli.Contato = new System.Collections.Generic.List<Classes.Contato>();
            //cli.Contato.Add(contato);

            contato = new Loja.Classes.Contato();
            contato.Codigo = 2;
            contato.DadosContato = "Camila@modelo.com";
            contato.Tipo = "e-mail";

            //cli.Contato.Add(contato);

            //cli.gravar();

            // a vantagem do 'foreach' é que ele lida diretamente com objetos e não com enumeração
            /*foreach (Classes.Contato cont in cli.Contato)
            {
                Console.WriteLine(cont.DadosContato);
            }*/

            // 'foreach' com expressão lâmbida
            //cli.Contato.ForEach(cont => Console.WriteLine(cont.DadosContato));

            // Expressão lâmbida
            //Console.WriteLine($"Telefone da cliente: {cli.Contato.FirstOrDefault(x => x.Tipo == "Telefone").DadosContato}");
            
        }
    }
}
