﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceAutoWpfApp.SRMaterial {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SRMaterial.ISAMaterial")]
    public interface ISAMaterial {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenericServiceOf_Material/GetById", ReplyAction="http://tempuri.org/IGenericServiceOf_Material/GetByIdResponse")]
        ServiceAutoClassLibrary.Material GetById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenericServiceOf_Material/GetAll", ReplyAction="http://tempuri.org/IGenericServiceOf_Material/GetAllResponse")]
        System.Collections.ObjectModel.ObservableCollection<ServiceAutoClassLibrary.Material> GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenericServiceOf_Material/Add", ReplyAction="http://tempuri.org/IGenericServiceOf_Material/AddResponse")]
        void Add(ServiceAutoClassLibrary.Material entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenericServiceOf_Material/AddRange", ReplyAction="http://tempuri.org/IGenericServiceOf_Material/AddRangeResponse")]
        void AddRange(System.Collections.ObjectModel.ObservableCollection<ServiceAutoClassLibrary.Material> entities);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenericServiceOf_Material/Modify", ReplyAction="http://tempuri.org/IGenericServiceOf_Material/ModifyResponse")]
        void Modify(ServiceAutoClassLibrary.Material entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenericServiceOf_Material/Remove", ReplyAction="http://tempuri.org/IGenericServiceOf_Material/RemoveResponse")]
        void Remove(ServiceAutoClassLibrary.Material entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenericServiceOf_Material/RemoveRange", ReplyAction="http://tempuri.org/IGenericServiceOf_Material/RemoveRangeResponse")]
        void RemoveRange(System.Collections.ObjectModel.ObservableCollection<ServiceAutoClassLibrary.Material> entities);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISAMaterialChannel : ServiceAutoWpfApp.SRMaterial.ISAMaterial, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SAMaterialClient : System.ServiceModel.ClientBase<ServiceAutoWpfApp.SRMaterial.ISAMaterial>, ServiceAutoWpfApp.SRMaterial.ISAMaterial {
        
        public SAMaterialClient() {
        }
        
        public SAMaterialClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SAMaterialClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SAMaterialClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SAMaterialClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ServiceAutoClassLibrary.Material GetById(int id) {
            return base.Channel.GetById(id);
        }
        
        public System.Collections.ObjectModel.ObservableCollection<ServiceAutoClassLibrary.Material> GetAll() {
            return base.Channel.GetAll();
        }
        
        public void Add(ServiceAutoClassLibrary.Material entity) {
            base.Channel.Add(entity);
        }
        
        public void AddRange(System.Collections.ObjectModel.ObservableCollection<ServiceAutoClassLibrary.Material> entities) {
            base.Channel.AddRange(entities);
        }
        
        public void Modify(ServiceAutoClassLibrary.Material entity) {
            base.Channel.Modify(entity);
        }
        
        public void Remove(ServiceAutoClassLibrary.Material entity) {
            base.Channel.Remove(entity);
        }
        
        public void RemoveRange(System.Collections.ObjectModel.ObservableCollection<ServiceAutoClassLibrary.Material> entities) {
            base.Channel.RemoveRange(entities);
        }
    }
}