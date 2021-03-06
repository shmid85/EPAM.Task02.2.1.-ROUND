﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task02._2._2.TRIANGLE
{
    class Triangle
    {
        private double a;
        private double b;
        private double c;
        public double A {
            get => a;
            set {
                if (value <= 0)
                {
                    throw new ArgumentException("Сторона должна быть больше нуля", nameof(a));
                }
                a = value;

            }
        }
        public double B
        {
            get => b;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Сторона должна быть больше нуля", nameof(b));
                }
                b = value;
            }
        }
        public double C
        {
            get => c;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Сторона должна быть больше нуля", nameof(c));
                }
                c = value;
            }
        }

        public Triangle(double a, double b, double c) {
            if (!triangleExist(a, b, c))
            {
                throw new ArgumentException("Треугольник с указанными сторонами не существует");
            }
            this.a = a;
            this.b = b;
            this.c = c;
        } 

        public double CalculaterSquare(){
            return Math.Sqrt(CalculateHalfPerimeter()
                *(CalculateHalfPerimeter()-a)
                *(CalculateHalfPerimeter()-b)
                *(CalculateHalfPerimeter()-c)
                );
        }
        public double CalculateHalfPerimeter() {
            return (a + b + c)/2;
        }

        public static bool triangleExist(double a, double b, double c) {
            return ((a < (b + c)) & (b < (a + c)) & (c < (a + b)));
        }
    }
}
