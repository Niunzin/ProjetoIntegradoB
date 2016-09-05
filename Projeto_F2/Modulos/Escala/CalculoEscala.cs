using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_F2.Modulos.Escala
{
    class CalculoEscala
    {
        internal enum Temperatura
        {
            CELSIUS,
            KELVIN,
            FAHRENHEIT
        }

        static public decimal Converter(Temperatura EntradaTipo, decimal EntradaValor, Temperatura SaidaTipo)
        {
            if (EntradaTipo == Temperatura.CELSIUS && SaidaTipo == Temperatura.KELVIN)
                return CelsiusParaKelvin(EntradaValor);
            else if (EntradaTipo == Temperatura.CELSIUS && SaidaTipo == Temperatura.FAHRENHEIT)
                return CelsiusParaFahrenheit(EntradaValor);
            else if (EntradaTipo == Temperatura.KELVIN && SaidaTipo == Temperatura.CELSIUS)
                return KelvinParaCelsius(EntradaValor);
            else if (EntradaTipo == Temperatura.KELVIN && SaidaTipo == Temperatura.FAHRENHEIT)
                return KelvinParaFahrenheit(EntradaValor);
            else if (EntradaTipo == Temperatura.FAHRENHEIT && SaidaTipo == Temperatura.CELSIUS)
                return FahrenheitParaCelsius(EntradaValor);
            else if (EntradaTipo == Temperatura.FAHRENHEIT && SaidaTipo == Temperatura.KELVIN)
                return FahrenheitParaKelvin(EntradaValor);
            else
                return EntradaValor;
        }

        static private decimal CelsiusParaKelvin(decimal Entrada)
        {

            return (Entrada + (decimal)273.15);
        }

        static private decimal CelsiusParaFahrenheit(decimal Entrada)
        {
            return (Entrada * (decimal)1.8) + 32;
        }

        static private decimal KelvinParaCelsius(decimal Entrada)
        {
            return (Entrada - (decimal)273.15);
        }

        static private decimal KelvinParaFahrenheit(decimal Entrada)
        {
            return (Entrada - (decimal)273.15) * (decimal)1.8 + 32;
        }

        static private decimal FahrenheitParaCelsius(decimal Entrada)
        {
            return (Entrada - 32) / (decimal)1.8;
        }

        static private decimal FahrenheitParaKelvin(decimal Entrada)
        {
            return ((Entrada - 32) / (decimal)1.8) + (decimal)273.15;
        }
    }
}
