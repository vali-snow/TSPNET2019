﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceAutoWpfApp.SROperatie {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SROperatie.ISAOperatie")]
    public interface ISAOperatie {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenericServiceOf_Operatie/GetById", ReplyAction="http://tempuri.org/IGenericServiceOf_Operatie/GetByIdResponse")]
        ServiceAutoClassLibrary.Operatie GetById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenericServiceOf_Operatie/GetAll", ReplyAction="http://tempuri.org/IGenericServiceOf_Operatie/GetAllResponse")]
        System.Collections.ObjectModel.ObservableCollection<ServiceAutoClassLibrary.Operatie> GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenericServiceOf_Operatie/Add", ReplyAction="http://tempuri.org/IGenericServiceOf_Operatie/AddResponse")]
        void Add(ServiceAutoClassLibrary.Operatie entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenericServiceOf_Operatie/AddRange", ReplyAction="http://tempuri.org/IGenericServiceOf_Operatie/AddRangeResponse")]
        void AddRange(System.Collections.ObjectModel.ObservableCollection<ServiceAutoClassLibrary.Operatie> entities);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenericServiceOf_Operatie/Remove", ReplyAction="http://tempuri.org/IGenericServiceOf_Operatie/RemoveResponse")]
        void Remove(ServiceAutoClassLibrary.Operatie entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenericServiceOf_Operatie/RemoveRange", ReplyAction="http://tempuri.org/IGenericServiceOf_Operatie/RemoveRangeResponse")]
        void RemoveRange(System.Collections.ObjectModel.ObservableCollection<ServiceAutoClassLibrary.Operatie> entities);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISAOperatieChannel : ServiceAutoWpfApp.SROperatie.ISAOperatie, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SAOperatieClient : System.ServiceModel.ClientBase<ServiceAutoWpfApp.SROperatie.ISAOperatie>, ServiceAutoWpfApp.SROperatie.ISAOperatie {
        
        public SAOperatieClient() {
        }
        
        public SAOperatieClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SAOperatieClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SAOperatieClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SAOperatieClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ServiceAutoClassLibrary.Operatie GetById(int id) {
            return base.Channel.GetById(id);
        }
        
        public System.Collections.ObjectModel.ObservableCollection<ServiceAutoClassLibrary.Operatie> GetAll() {
            return base.Channel.GetAll();
        }
        
        public void Add(ServiceAutoClassLibrary.Operatie entity) {
            base.Channel.Add(entity);
        }
        
        public void AddRange(System.Collections.ObjectModel.ObservableCollection<ServiceAutoClassLibrary.Operatie> entities) {
            base.Channel.AddRange(entities);
        }
        
        public void Remove(ServiceAutoClassLibrary.Operatie entity) {
            base.Channel.Remove(entity);
        }
        
        public void RemoveRange(System.Collections.ObjectModel.ObservableCollection<ServiceAutoClassLibrary.Operatie> entities) {
            base.Channel.RemoveRange(entities);
        }
    }
}
