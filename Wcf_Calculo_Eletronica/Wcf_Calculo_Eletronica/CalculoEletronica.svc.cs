using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Wcf_Calculo_Eletronica
{

    public class CalculoEletronica : ICalculoEletronica
    {
        public double Calcular(double tensao = 0, double resistencia = 0, double corrente = 0)
        {
            double resultado = 0;
            if (tensao == 0)
            {
                resultado = resistencia * corrente;
            }
            else if (resistencia == 0)
            {
                try
                {
                    resultado = tensao / corrente;
                }
                catch (DivideByZeroException)
                {
                    return 0;
                }
            }
            else if (corrente == 0)
            {
                try
                {
                    resultado = tensao / resistencia;
                }
                catch (DivideByZeroException)
                {
                    return 0;
                }
            }

            return resultado;
        }

        public double ConverteMiliParaUnidade(double mili)
        {
            double unidade = 0;
            try
            {
                unidade = mili / 1000;
            }
            catch(DivideByZeroException)
            {
                return 0;
            }
            return unidade;
        }

        public double ConverteMicroParaUnidade(double micro)
        {
            double unidade = 0;
            try
            {
                unidade = micro / 1000000;
            }
            catch (DivideByZeroException)
            {
                return 0;
            }
            return unidade;
        }

        public double ConverteKiloParaUnidade(double kilo)
        {
            double unidade = 0;
            try
            {
                unidade = kilo * 1000;
            }
            catch (DivideByZeroException)
            {
                return 0;
            }
            return unidade;
        }

        public double ConverteMegaParaUnidade(double mega)
        {
            double unidade = 0;
            try
            {
                unidade = mega * 1000000;
            }
            catch (DivideByZeroException)
            {
                return 0;
            }
            return unidade;
        }

        public string FormataValorResistencia(double resistencia) 
        {
            string valorOhm = "";

            if (resistencia < 0.000999)
            {
                valorOhm = "µΩ " + String.Format("{0:#.#,##}", (resistencia * 1000000));
            }
            else if (resistencia < 0.999)
            {
                valorOhm = "mΩ " + String.Format("{0:#.#,##}", (resistencia * 1000));
            }
            else if (resistencia > 999999) 
            {
                valorOhm = "MΩ " + String.Format( "{0:#.#,##}",(resistencia / 1000000));
            }
            else if (resistencia > 999)
            {
                valorOhm = "kΩ " + String.Format( "{0:#.#,##}",(resistencia / 1000));
            }
            else 
            {
                valorOhm = "Ω " + String.Format("{0:#.#,#}", resistencia);
            }
            return valorOhm;
        }

        public string FormataValorTensao(double tensao) 
        {
            string valorVolt = "";
            if (tensao < 0.000999)
            {
                valorVolt = "µV " + String.Format("{0:#.#,##}", (tensao * 1000000));
            }
            else if (tensao < 0.999)
            {
                valorVolt = "mV " + String.Format("{0:#.#,##}", (tensao * 1000));
            }
            else
            {
                valorVolt = "V " + String.Format("{0:#.#,#}", tensao);
            }
            return valorVolt;
        }

        public string FormataValorCorrente(double corrente) 
        {
            string valorAmpere = "";
            if (corrente < 0.000999)
            {
                valorAmpere = "µA " + String.Format("{0:#.#,##}", (corrente * 1000000));
                
            }
            else if (corrente < 0.999)
            {
                valorAmpere = "mA " + String.Format("{0:#.#,##}", (corrente * 1000));
            }
            else
            {
                valorAmpere = "A " + String.Format("{0:#.#,#}", corrente);
            }
            return valorAmpere;
        }

    }
}
