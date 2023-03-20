using bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        public static int totalDeContas { get; private set; }

        private int numeroAgencia;

        public int Numero_agencia
        {
            get { return numeroAgencia; }
            private set 
            { 
                if(value > 0)
                {
                    this.numeroAgencia = value;
                }                
            }
        }

        //private string conta;
        public string Conta { get; set; }

        private double saldoConta = 100;

        public Cliente Titular { get; set; }

        public void depositar(double valor)
        {
            saldoConta += valor;
        }

        public bool saque(double valor)
        {
            if (valor <= saldoConta)
            {
                saldoConta -= valor;
                return true;
            }

            else
            {
                return false;
            }

        }
        public bool transferir(double valor, ContaCorrente destino)
        {
            if (saldoConta < valor)
            {
                return false;
            }

            else
            {
                saque(valor);
                destino.depositar(valor);
                return true;
            }
        }

        public void setSaldo(double valor)
        {
            if(valor < 0)
            {
                return;
            }

            else
            {
                this.saldoConta = valor;
            }
        }

        public double getSaldo()
        {
            return this.saldoConta;
        }

        public ContaCorrente(Cliente titular, int numero_agencia, string numero_conta)
        {
            Titular = titular;
            this.Numero_agencia = numero_agencia;
            this.Conta = numero_conta;
            totalDeContas++;
        }

    }
}
