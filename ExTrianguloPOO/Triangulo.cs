using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ExTrianguloPOO
{
    internal class Triangulo
    {
        public double ladoA, ladoB, ladoC;

        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB; 
            this.ladoC = ladoC;
        }

        public string verificaLado()
        {
            if (this.ladoA == this.ladoB && this.ladoA == this.ladoC)
            {
                return "Triângulo Equilátero";
            } 
            else {
                if (this.ladoA == this.ladoB || this.ladoA == this.ladoC || this.ladoB == this.ladoC)
                {
                   return "Triângulo Isósceles";
                }
                else
                {
                    return "Triângulo Escaleno";
                }

            }
        }
    }
}
