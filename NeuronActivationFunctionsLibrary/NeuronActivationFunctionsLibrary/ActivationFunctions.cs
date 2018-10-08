using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuronActivationFunctionsLibrary
{
    public class ActivationFunctions
    {
        public static double Binary(double signal, double threshold)
        {
            return signal > threshold ? 1 : 0;
        }
        public static double Binary(double signal)
        {
            return Binary(signal, 0);
        }
        public static double Bipolar(double signal, double threshold)
        {
            return signal > threshold ? 1 : -1;
        }
        public static double Bipolar(double signal)
        {
            return Bipolar(signal, 0);
        }

    }
}
