﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebEventos.SRefAreaTematica {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AreaTematica", Namespace="http://schemas.datacontract.org/2004/07/Sise.Entities")]
    [System.SerializableAttribute()]
    public partial class AreaTematica : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodAreaTematicaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreAreaTematicaField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CodAreaTematica {
            get {
                return this.CodAreaTematicaField;
            }
            set {
                if ((this.CodAreaTematicaField.Equals(value) != true)) {
                    this.CodAreaTematicaField = value;
                    this.RaisePropertyChanged("CodAreaTematica");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreAreaTematica {
            get {
                return this.NombreAreaTematicaField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreAreaTematicaField, value) != true)) {
                    this.NombreAreaTematicaField = value;
                    this.RaisePropertyChanged("NombreAreaTematica");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceResponse", Namespace="http://schemas.datacontract.org/2004/07/Sise.WcfService.Entity")]
    [System.SerializableAttribute()]
    public partial class ServiceResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsSuccessField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageDevField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsSuccess {
            get {
                return this.IsSuccessField;
            }
            set {
                if ((this.IsSuccessField.Equals(value) != true)) {
                    this.IsSuccessField = value;
                    this.RaisePropertyChanged("IsSuccess");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MessageDev {
            get {
                return this.MessageDevField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageDevField, value) != true)) {
                    this.MessageDevField = value;
                    this.RaisePropertyChanged("MessageDev");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SRefAreaTematica.IAreaTematicaService")]
    public interface IAreaTematicaService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAreaTematicaService/registrar", ReplyAction="http://tempuri.org/IAreaTematicaService/registrarResponse")]
        WebEventos.SRefAreaTematica.ServiceResponse registrar(WebEventos.SRefAreaTematica.AreaTematica areaTematica);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAreaTematicaService/registrar", ReplyAction="http://tempuri.org/IAreaTematicaService/registrarResponse")]
        System.Threading.Tasks.Task<WebEventos.SRefAreaTematica.ServiceResponse> registrarAsync(WebEventos.SRefAreaTematica.AreaTematica areaTematica);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAreaTematicaService/actualizar", ReplyAction="http://tempuri.org/IAreaTematicaService/actualizarResponse")]
        WebEventos.SRefAreaTematica.ServiceResponse actualizar(WebEventos.SRefAreaTematica.AreaTematica areaTematica);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAreaTematicaService/actualizar", ReplyAction="http://tempuri.org/IAreaTematicaService/actualizarResponse")]
        System.Threading.Tasks.Task<WebEventos.SRefAreaTematica.ServiceResponse> actualizarAsync(WebEventos.SRefAreaTematica.AreaTematica areaTematica);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAreaTematicaService/eliminar", ReplyAction="http://tempuri.org/IAreaTematicaService/eliminarResponse")]
        WebEventos.SRefAreaTematica.ServiceResponse eliminar(int CodAreaTematica);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAreaTematicaService/eliminar", ReplyAction="http://tempuri.org/IAreaTematicaService/eliminarResponse")]
        System.Threading.Tasks.Task<WebEventos.SRefAreaTematica.ServiceResponse> eliminarAsync(int CodAreaTematica);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAreaTematicaService/listar", ReplyAction="http://tempuri.org/IAreaTematicaService/listarResponse")]
        WebEventos.SRefAreaTematica.AreaTematica[] listar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAreaTematicaService/listar", ReplyAction="http://tempuri.org/IAreaTematicaService/listarResponse")]
        System.Threading.Tasks.Task<WebEventos.SRefAreaTematica.AreaTematica[]> listarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAreaTematicaService/buscar", ReplyAction="http://tempuri.org/IAreaTematicaService/buscarResponse")]
        WebEventos.SRefAreaTematica.AreaTematica buscar(int CodAreaTematica);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAreaTematicaService/buscar", ReplyAction="http://tempuri.org/IAreaTematicaService/buscarResponse")]
        System.Threading.Tasks.Task<WebEventos.SRefAreaTematica.AreaTematica> buscarAsync(int CodAreaTematica);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAreaTematicaServiceChannel : WebEventos.SRefAreaTematica.IAreaTematicaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AreaTematicaServiceClient : System.ServiceModel.ClientBase<WebEventos.SRefAreaTematica.IAreaTematicaService>, WebEventos.SRefAreaTematica.IAreaTematicaService {
        
        public AreaTematicaServiceClient() {
        }
        
        public AreaTematicaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AreaTematicaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AreaTematicaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AreaTematicaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebEventos.SRefAreaTematica.ServiceResponse registrar(WebEventos.SRefAreaTematica.AreaTematica areaTematica) {
            return base.Channel.registrar(areaTematica);
        }
        
        public System.Threading.Tasks.Task<WebEventos.SRefAreaTematica.ServiceResponse> registrarAsync(WebEventos.SRefAreaTematica.AreaTematica areaTematica) {
            return base.Channel.registrarAsync(areaTematica);
        }
        
        public WebEventos.SRefAreaTematica.ServiceResponse actualizar(WebEventos.SRefAreaTematica.AreaTematica areaTematica) {
            return base.Channel.actualizar(areaTematica);
        }
        
        public System.Threading.Tasks.Task<WebEventos.SRefAreaTematica.ServiceResponse> actualizarAsync(WebEventos.SRefAreaTematica.AreaTematica areaTematica) {
            return base.Channel.actualizarAsync(areaTematica);
        }
        
        public WebEventos.SRefAreaTematica.ServiceResponse eliminar(int CodAreaTematica) {
            return base.Channel.eliminar(CodAreaTematica);
        }
        
        public System.Threading.Tasks.Task<WebEventos.SRefAreaTematica.ServiceResponse> eliminarAsync(int CodAreaTematica) {
            return base.Channel.eliminarAsync(CodAreaTematica);
        }
        
        public WebEventos.SRefAreaTematica.AreaTematica[] listar() {
            return base.Channel.listar();
        }
        
        public System.Threading.Tasks.Task<WebEventos.SRefAreaTematica.AreaTematica[]> listarAsync() {
            return base.Channel.listarAsync();
        }
        
        public WebEventos.SRefAreaTematica.AreaTematica buscar(int CodAreaTematica) {
            return base.Channel.buscar(CodAreaTematica);
        }
        
        public System.Threading.Tasks.Task<WebEventos.SRefAreaTematica.AreaTematica> buscarAsync(int CodAreaTematica) {
            return base.Channel.buscarAsync(CodAreaTematica);
        }
    }
}