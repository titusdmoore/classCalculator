using System;
using System.Collections.Generic;
using System.Text;

namespace classCalculatorLibraryProject {
    public class Functions {

        public int Add(int total, int amount) {
            return total + amount;
        }
        public int Subtract(int t, int a) {
            return t - a;
        }
        public int Multiply (int t , int a) {
            return t * a;
        }
        public int Divide( int t, int a) {
            if (a == 0) {
                throw new Exception("Cannot Divide by Zero");
            }
            return t / a;
        }
        public int Clear() {
            return 0;
        }
        
    }
}
