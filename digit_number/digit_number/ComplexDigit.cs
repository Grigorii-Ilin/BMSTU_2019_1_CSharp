using System;
using System.Collections.Generic;
using System.Text;

namespace digit_number {
    public struct ComplexDigit {
        private double real;
        private double imagine;

        public ComplexDigit(double r, double im) {
            this.real = r;
            this.imagine = im;
        }

        public static ComplexDigit operator + (ComplexDigit lhs, ComplexDigit rhs) {
            double r = lhs.real + rhs.real;
            double im= lhs.imagine + rhs.imagine;

            return new ComplexDigit(r, im);
        }

        public static ComplexDigit operator - (ComplexDigit lhs, ComplexDigit rhs) {
            double r = lhs.real - rhs.real;
            double im = lhs.imagine - rhs.imagine;

            return new ComplexDigit(r, im);
        }

        public static ComplexDigit operator *(ComplexDigit lhs, ComplexDigit rhs) {
            double r = lhs.real * rhs.real;
            double im = lhs.imagine * rhs.imagine;

            return new ComplexDigit(r, im);
        }

        public static ComplexDigit operator /(ComplexDigit lhs, ComplexDigit rhs) {
            double r = lhs.real / rhs.real;
            double im = lhs.imagine / rhs.imagine;

            return new ComplexDigit(r, im);
        }

        public static bool operator == (ComplexDigit lhs, ComplexDigit rhs) {
            bool br = lhs.real == rhs.real;
            bool bim = lhs.imagine == rhs.imagine;

            return (br== true && bim==true);
        }

        public static bool operator !=(ComplexDigit lhs, ComplexDigit rhs) {
            //bool br = lhs.real == rhs.real;
            //bool bim = lhs.imagine == rhs.imagine;

            //return (br != true || bim != true);
            return !(lhs == rhs);
        }

        public string print() {
            return "Целая часть: {real} Мнимая часть: {imagine}";
        }
    }


}
