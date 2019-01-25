using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Scenes {

    public interface ICalculator {

        int Calc(int a, int b);
    }

    public class CalculatorA : ICalculator {
        public int Calc(int a, int b) {
            return a + b;
        }
    }

    public class CalculatorB : ICalculator {
        public int Calc(int a, int b) {
            return a * b;
        }
    }
}
