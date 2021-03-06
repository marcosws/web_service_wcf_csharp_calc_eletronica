﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wcf_CalculoEletronica_Cliente_Win.ServiceReferenceCalc {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceCalc.ICalculoEletronica")]
    public interface ICalculoEletronica {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculoEletronica/Calcular", ReplyAction="http://tempuri.org/ICalculoEletronica/CalcularResponse")]
        double Calcular(double tensao, double resistencia, double corrente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculoEletronica/ConverteMiliParaUnidade", ReplyAction="http://tempuri.org/ICalculoEletronica/ConverteMiliParaUnidadeResponse")]
        double ConverteMiliParaUnidade(double mili);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculoEletronica/ConverteMicroParaUnidade", ReplyAction="http://tempuri.org/ICalculoEletronica/ConverteMicroParaUnidadeResponse")]
        double ConverteMicroParaUnidade(double micro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculoEletronica/ConverteKiloParaUnidade", ReplyAction="http://tempuri.org/ICalculoEletronica/ConverteKiloParaUnidadeResponse")]
        double ConverteKiloParaUnidade(double kilo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculoEletronica/ConverteMegaParaUnidade", ReplyAction="http://tempuri.org/ICalculoEletronica/ConverteMegaParaUnidadeResponse")]
        double ConverteMegaParaUnidade(double mega);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculoEletronica/FormataValorResistencia", ReplyAction="http://tempuri.org/ICalculoEletronica/FormataValorResistenciaResponse")]
        string FormataValorResistencia(double resistencia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculoEletronica/FormataValorTensao", ReplyAction="http://tempuri.org/ICalculoEletronica/FormataValorTensaoResponse")]
        string FormataValorTensao(double tensao);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculoEletronica/FormataValorCorrente", ReplyAction="http://tempuri.org/ICalculoEletronica/FormataValorCorrenteResponse")]
        string FormataValorCorrente(double corrente);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculoEletronicaChannel : Wcf_CalculoEletronica_Cliente_Win.ServiceReferenceCalc.ICalculoEletronica, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculoEletronicaClient : System.ServiceModel.ClientBase<Wcf_CalculoEletronica_Cliente_Win.ServiceReferenceCalc.ICalculoEletronica>, Wcf_CalculoEletronica_Cliente_Win.ServiceReferenceCalc.ICalculoEletronica {
        
        public CalculoEletronicaClient() {
        }
        
        public CalculoEletronicaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculoEletronicaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculoEletronicaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculoEletronicaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Calcular(double tensao, double resistencia, double corrente) {
            return base.Channel.Calcular(tensao, resistencia, corrente);
        }
        
        public double ConverteMiliParaUnidade(double mili) {
            return base.Channel.ConverteMiliParaUnidade(mili);
        }
        
        public double ConverteMicroParaUnidade(double micro) {
            return base.Channel.ConverteMicroParaUnidade(micro);
        }
        
        public double ConverteKiloParaUnidade(double kilo) {
            return base.Channel.ConverteKiloParaUnidade(kilo);
        }
        
        public double ConverteMegaParaUnidade(double mega) {
            return base.Channel.ConverteMegaParaUnidade(mega);
        }
        
        public string FormataValorResistencia(double resistencia) {
            return base.Channel.FormataValorResistencia(resistencia);
        }
        
        public string FormataValorTensao(double tensao) {
            return base.Channel.FormataValorTensao(tensao);
        }
        
        public string FormataValorCorrente(double corrente) {
            return base.Channel.FormataValorCorrente(corrente);
        }
    }
}
