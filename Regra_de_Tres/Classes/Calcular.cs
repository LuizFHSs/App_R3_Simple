using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regra_de_Tres.Classes
{
    internal class Calcular
    {
        int R3;
        int Dado1;
        int Dado2;
        int Dado3;
        int Dado4;
        string Retorno = "";
        public string regraDefinida = "";

        public void DefinirRegra(string regra, string V1, string V2, string V3, string V4)
        {
            if (regra == "Regra de Três Direta")
            {
                regraDefinida = RegraDeTresSimplesDireta(V1, V2, V3, V4);
            }
            else
            {
                if (regra == "Regra de Três Inversa")
                {
                    regraDefinida = RegraDeTresSimplesInversa(V1, V2, V3, V4);
                }
            }
        }

        public string RegraDeTresSimplesDireta(string D1, string D2, string D3, string D4)
        {
            if (D3 == "x")
            {
                this.Dado1 = Int32.Parse(D1);
                this.Dado2 = Int32.Parse(D2);
                this.Dado3 = 1;
                this.Dado4 = Int32.Parse(D4);

                this.R3 = (this.Dado1 * this.Dado4) / (this.Dado2 * this.Dado3);
            }
            else
            {
                if (D4 == "x")
                {
                    this.Dado1 = Int32.Parse(D1);
                    this.Dado2 = Int32.Parse(D2);
                    this.Dado3 = Int32.Parse(D3);
                    this.Dado4 = 1;

                    this.R3 = (this.Dado2 * this.Dado3) / (this.Dado1 * this.Dado4);
                }
            }

            this.Retorno = this.R3.ToString();
            return this.Retorno;
        }

        public string RegraDeTresSimplesInversa(string D1, string D2, string D3, string D4)
        {
            if (D3 == "x")
            {
                this.Dado1 = Int32.Parse(D1);
                this.Dado2 = Int32.Parse(D2);
                this.Dado3 = 1;
                this.Dado4 = Int32.Parse(D4);

                this.R3 = (this.Dado1 * this.Dado2) / (this.Dado4 * this.Dado3);
            }
            else
            {
                if (D4 == "x")
                {
                    this.Dado1 = Int32.Parse(D1);
                    this.Dado2 = Int32.Parse(D2);
                    this.Dado3 = Int32.Parse(D3);
                    this.Dado4 = 1;

                    this.R3 = (this.Dado2 * this.Dado1) / (this.Dado3 * this.Dado4);
                }
            }

            this.Retorno = this.R3.ToString();
            return this.Retorno;
        }
    }
}

