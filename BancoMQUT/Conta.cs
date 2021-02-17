using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMQUT
{
    class Conta

    {
        public int Agencia { get; set; }
        public int Numero { get; set; }
        //public double Saldo { get; }
        private double saldo;

        public Cliente cliente;

        public double getSaldo()
        {
            return saldo;
        }

        public string deposito(double value)
        {
            saldo = saldo + value;
            return "Deposito efetuado com sucesso!!!";
        }

        public string saque(double value)
        {
            if (saldo >= value)
            {
                saldo = saldo - value;
                return "Saldo efetuado com sucesso!!!";
            }
            return "Saldo insuficitente!!!";
        }


        public override string ToString()
        {
            return "\n--Dados Conta Corrente--" +
                   "\nAgencia: " + Agencia +
                    "\nConta N°: " + Numero +
                    "\nSaldo: " + saldo;
        }


    }
}
