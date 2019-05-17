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

        public static ComplexDigit operator +(ComplexDigit lhs, ComplexDigit rhs) {
            double r = lhs.real + rhs.real;
            double im = lhs.imagine + rhs.imagine;

            return new ComplexDigit(r, im);
        }

        public static ComplexDigit operator -(ComplexDigit lhs, ComplexDigit rhs) {
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
            double r = (rhs.real != 0 ? lhs.real / rhs.real : 0);
            double im = (rhs.imagine != 0 ? lhs.imagine / rhs.imagine : 0);

            return new ComplexDigit(r, im);
        }

        public static bool operator ==(ComplexDigit lhs, ComplexDigit rhs) {
            bool br = lhs.real == rhs.real;
            bool bim = lhs.imagine == rhs.imagine;

            return (br == true && bim == true);
        }

        public static bool operator !=(ComplexDigit lhs, ComplexDigit rhs) {
            return !(lhs == rhs);
        }

        public string str() {
            return String.Format("Целая часть: {0} Мнимая часть: {1}\n", this.real, this.imagine);
        }
    }


}
