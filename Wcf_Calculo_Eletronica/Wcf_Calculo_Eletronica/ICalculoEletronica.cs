using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Wcf_Calculo_Eletronica
{
    
    [ServiceContract]
    public interface ICalculoEletronica
    {
        [OperationContract]
        double Calcular(double tensao = 0, double resistencia = 0, double corrente = 0);

        [OperationContract]
        double ConverteMiliParaUnidade(double mili);

        [OperationContract]
        double ConverteMicroParaUnidade(double micro);

        [OperationContract]
        double ConverteKiloParaUnidade(double kilo);

        [OperationContract]
        double ConverteMegaParaUnidade(double mega);

        [OperationContract]
        string FormataValorResistencia(double resistencia);

        [OperationContract]
        string FormataValorTensao(double tensao);

        [OperationContract]
        string FormataValorCorrente(double corrente);
        
    }

}
