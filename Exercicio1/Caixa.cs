using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Caixa
    {
        /*
         * Caixa means cash register.
         * Let me introduce you the trouble.
         * When the cash register we do not have coins and just banknotes
         * Nota means banknotes
         */

        //inicialized part
        private int Nota20 = 50;
        private int Nota10 = 50;
        private int Nota5 = 50;
        private int Nota2 = 50;
        private int Nota1 = 50;

        private float saldoCaixa;//this instance variable means cash balance; Saldo = balance

        public void CalculaSaldo()
        {
            /*
             * This method calculate de balance of the cash register
             */
            float centsPart = 0;
            saldoCaixa = Nota10 * 10 + Nota2 * 2 + Nota20 * 20 + Nota5 * 5 + Nota1;
            
        }

        public float SaldoCaixa
        {
            get
            {
                CalculaSaldo();
                return saldoCaixa; 
            }
            set { saldoCaixa = value; }
        }

        public Caixa()
        {
            CalculaSaldo();
        }
    }
}
