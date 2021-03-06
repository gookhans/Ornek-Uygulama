﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrnekUygulama.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:serviceConnection", ConfigurationName="ServiceReference1.serviceConnectionPortType")]
    public interface serviceConnectionPortType {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:serviceConnection#dbConnect", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        bool dbConnect();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:serviceConnection#dbConnect", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<bool> dbConnectAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:serviceConnection#memberRegistration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string memberRegistration(string firstName, string lastName, string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:serviceConnection#memberRegistration", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> memberRegistrationAsync(string firstName, string lastName, string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:serviceConnection#memberLogin", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string memberLogin(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:serviceConnection#memberLogin", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> memberLoginAsync(string email, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface serviceConnectionPortTypeChannel : OrnekUygulama.ServiceReference1.serviceConnectionPortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class serviceConnectionPortTypeClient : System.ServiceModel.ClientBase<OrnekUygulama.ServiceReference1.serviceConnectionPortType>, OrnekUygulama.ServiceReference1.serviceConnectionPortType {
        
        public serviceConnectionPortTypeClient() {
        }
        
        public serviceConnectionPortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public serviceConnectionPortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public serviceConnectionPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public serviceConnectionPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool dbConnect() {
            return base.Channel.dbConnect();
        }
        
        public System.Threading.Tasks.Task<bool> dbConnectAsync() {
            return base.Channel.dbConnectAsync();
        }
        
        public string memberRegistration(string firstName, string lastName, string email, string password) {
            return base.Channel.memberRegistration(firstName, lastName, email, password);
        }
        
        public System.Threading.Tasks.Task<string> memberRegistrationAsync(string firstName, string lastName, string email, string password) {
            return base.Channel.memberRegistrationAsync(firstName, lastName, email, password);
        }
        
        public string memberLogin(string email, string password) {
            return base.Channel.memberLogin(email, password);
        }
        
        public System.Threading.Tasks.Task<string> memberLoginAsync(string email, string password) {
            return base.Channel.memberLoginAsync(email, password);
        }
    }
}
