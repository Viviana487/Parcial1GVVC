using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1gvvc
{
    public abstract class FiguraGeometrica
    {
        public abstract double area();
        public abstract double perimetro();
    }
    public class Triangulo : FiguraGeometrica
    {
        private readonly double base_;
        private readonly double altura;

        public Triangulo(double base_, double altura)
        {
            this.base_ = base_;
            this.altura = altura;
        }

        public override double area()
        {
            return (base_ * altura) / 2;
        }

        public override double perimetro()
        {
            return base_ + altura + (Math.Sqrt(Math.Pow(base_, 2) + Math.Pow(altura, 2)));
        }
    }
    public class Circulo : FiguraGeometrica
    {
        private readonly double radio;
        public Circulo(double radio)
        {
            this.radio = radio;
        }
        public override double area()
        {
            return (double)Math.PI * Math.Pow((double)radio, 2);
        }
        public override double perimetro()
        {
            return 2 * Math.PI * radio;
        }

    }
}

