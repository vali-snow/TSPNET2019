﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceAutoWpfApp.SRSasiu {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SRSasiu.ISASasiu")]
    public interface ISASasiu {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenericServiceOf_Sasiu/GetById", ReplyAction="http://tempuri.org/IGenericServiceOf_Sasiu/GetByIdResponse")]
        ServiceAutoClassLibrary.Sasiu GetById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenericServiceOf_Sasiu/GetAll", ReplyAction="http://tempuri.org/IGenericServiceOf_Sasiu/GetAllResponse")]
        System.Collections.ObjectModel.ObservableCollection<ServiceAutoClassLibrary.Sasiu> GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenericServiceOf_Sasiu/Add", ReplyAction="http://tempuri.org/IGenericServiceOf_Sasiu/AddResponse")]
        void Add(ServiceAutoClassLibrary.Sasiu entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenericServiceOf_Sasiu/AddRange", ReplyAction="http://tempuri.org/IGenericServiceOf_Sasiu/AddRangeResponse")]
        void AddRange(System.Collections.ObjectModel.ObservableCollection<ServiceAutoClassLibrary.Sasiu> entities);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenericServiceOf_Sasiu/Remove", ReplyAction="http://tempuri.org/IGenericServiceOf_Sasiu/RemoveResponse")]
        void Remove(ServiceAutoClassLibrary.Sasiu entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenericServiceOf_Sasiu/RemoveRange", ReplyAction="http://tempuri.org/IGenericServiceOf_Sasiu/RemoveRangeResponse")]
        void RemoveRange(System.Collections.ObjectModel.ObservableCollection<ServiceAutoClassLibrary.Sasiu> entities);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISASasiuChannel : ServiceAutoWpfApp.SRSasiu.ISASasiu, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SASasiuClient : System.ServiceModel.ClientBase<ServiceAutoWpfApp.SRSasiu.ISASasiu>, ServiceAutoWpfApp.SRSasiu.ISASasiu {
        
        public SASasiuClient() {
        }
        
        public SASasiuClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SASasiuClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SASasiuClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SASasiuClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ServiceAutoClassLibrary.Sasiu GetById(int id) {
            return base.Channel.GetById(id);
        }
        
        public System.Collections.ObjectModel.ObservableCollection<ServiceAutoClassLibrary.Sasiu> GetAll() {
            return base.Channel.GetAll();
        }
        
        public void Add(ServiceAutoClassLibrary.Sasiu entity) {
            base.Channel.Add(entity);
        }
        
        public void AddRange(System.Collections.ObjectModel.ObservableCollection<ServiceAutoClassLibrary.Sasiu> entities) {
            base.Channel.AddRange(entities);
        }
        
        public void Remove(ServiceAutoClassLibrary.Sasiu entity) {
            base.Channel.Remove(entity);
        }
        
        public void RemoveRange(System.Collections.ObjectModel.ObservableCollection<ServiceAutoClassLibrary.Sasiu> entities) {
            base.Channel.RemoveRange(entities);
        }
    }
}
