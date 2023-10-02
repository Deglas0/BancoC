using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoC
{
    internal class Conta
    {
        private string _id;
        public string Nome { get; set; }
        public double Saldo { get; private set; }
        public double Deposito { get; set; }

        public Conta(string id, string nome, double deposito)
        {
            _id = id;
            Nome = nome;
            Deposito = deposito;
        }

        public string Id
        { get { return _id; } }
    }
}
