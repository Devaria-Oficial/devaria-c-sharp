using System;
using EfetuarPagamento.Classes;
using EfetuarPagamento.Enums;

namespace EfetuarPagamento
{
    class Program
    {
        /*
            Escrever um programa - OK
            que recebe os produtos a serem comprados - OK 
            e a forma de pagamentos escolhida e, - OK
            de acordo com a forma de pagamento, - OK
            efetua a compra utilizando o correto meio de pagamento. - OK
         */

        //Escrever um programa  - OK
        static void Main(string[] produtos)
        {
            //que recebe os produtos a serem comprados - OK 
            if (produtos.Length == 0)
            {
                Console.WriteLine("Nenhum produto foi listado para compra");
                return;
            }

            Console.WriteLine("Favor informar a forma de pagamento (Boleto, Pix, CartaoCredito,Transferencia)");
            var formaPagamentoDesejada = Console.ReadLine();

            if (string.IsNullOrEmpty(formaPagamentoDesejada) || string.IsNullOrWhiteSpace(formaPagamentoDesejada)
                    || (TipoPagamentoEnum.Boleto.ToString() != formaPagamentoDesejada 
                        && TipoPagamentoEnum.Pix.ToString() != formaPagamentoDesejada
                        && TipoPagamentoEnum.CartaoCredito.ToString() != formaPagamentoDesejada
                        && TipoPagamentoEnum.Transferencia.ToString() != formaPagamentoDesejada))
            {
                Console.WriteLine($"A forma de pagamento: {formaPagamentoDesejada} não é válida!");
                return;
            }

            //e a forma de pagamentos escolhida e, - OK
            // de acordo com a forma de pagamento, -OK
            FormaDePagamento formaDePagamento;
            if(TipoPagamentoEnum.Boleto.ToString() == formaPagamentoDesejada)
            {
                formaDePagamento = new FormaDePagamentoBoleto();
            }else if (TipoPagamentoEnum.Pix.ToString() == formaPagamentoDesejada)
            {
                formaDePagamento = new FormaDePagamentoPix();
            }
            else if (TipoPagamentoEnum.CartaoCredito.ToString() == formaPagamentoDesejada)
            {
                formaDePagamento = new FormaDePagamentoCartaoCredito();
            }
            else if (TipoPagamentoEnum.Transferencia.ToString() == formaPagamentoDesejada)
            {
                formaDePagamento = new FormaDePagamentoTranferencia();
            }
            else
            {
                Console.WriteLine($"A forma de pagamento: {formaPagamentoDesejada} não é válida!");
                return;
            }

            // efetua a compra utilizando o correto meio de pagamento. - OK
            if (formaDePagamento != null)
            {
                formaDePagamento.EfetuarPagamento();
            }
        }
    }
}
