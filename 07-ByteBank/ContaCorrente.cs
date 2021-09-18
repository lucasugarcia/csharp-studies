﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }

        public int Numero { get; set; }
        public Cliente Titular { get; set; }

        private int _agencia;
        private double _saldo = 100;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value >= 0)
                    _agencia = value;
            }
        }

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value >= 0)
                    _saldo = value;
            }
        }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
                return false;

            _saldo -= valor;

            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
                return false;

            _saldo -= valor;

            contaDestino.Depositar(valor);

            return true;
        }
    }
}