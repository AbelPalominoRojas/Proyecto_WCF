﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebEventos.SRefEventoParticipante {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EventoParticipante", Namespace="http://schemas.datacontract.org/2004/07/Sise.Entities")]
    [System.SerializableAttribute()]
    public partial class EventoParticipante : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodEventoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodParticipanteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaRegistroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ParticipanteAsistioField;
        
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
        public int CodEvento {
            get {
                return this.CodEventoField;
            }
            set {
                if ((this.CodEventoField.Equals(value) != true)) {
                    this.CodEventoField = value;
                    this.RaisePropertyChanged("CodEvento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CodParticipante {
            get {
                return this.CodParticipanteField;
            }
            set {
                if ((this.CodParticipanteField.Equals(value) != true)) {
                    this.CodParticipanteField = value;
                    this.RaisePropertyChanged("CodParticipante");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CodUsuario {
            get {
                return this.CodUsuarioField;
            }
            set {
                if ((this.CodUsuarioField.Equals(value) != true)) {
                    this.CodUsuarioField = value;
                    this.RaisePropertyChanged("CodUsuario");
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
        public System.DateTime FechaRegistro {
            get {
                return this.FechaRegistroField;
            }
            set {
                if ((this.FechaRegistroField.Equals(value) != true)) {
                    this.FechaRegistroField = value;
                    this.RaisePropertyChanged("FechaRegistro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool ParticipanteAsistio {
            get {
                return this.ParticipanteAsistioField;
            }
            set {
                if ((this.ParticipanteAsistioField.Equals(value) != true)) {
                    this.ParticipanteAsistioField = value;
                    this.RaisePropertyChanged("ParticipanteAsistio");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SRefEventoParticipante.IEventoParticipanteService")]
    public interface IEventoParticipanteService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventoParticipanteService/registrar", ReplyAction="http://tempuri.org/IEventoParticipanteService/registrarResponse")]
        WebEventos.SRefEventoParticipante.ServiceResponse registrar(WebEventos.SRefEventoParticipante.EventoParticipante eventoParticipante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventoParticipanteService/registrar", ReplyAction="http://tempuri.org/IEventoParticipanteService/registrarResponse")]
        System.Threading.Tasks.Task<WebEventos.SRefEventoParticipante.ServiceResponse> registrarAsync(WebEventos.SRefEventoParticipante.EventoParticipante eventoParticipante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventoParticipanteService/actualizar", ReplyAction="http://tempuri.org/IEventoParticipanteService/actualizarResponse")]
        WebEventos.SRefEventoParticipante.ServiceResponse actualizar(WebEventos.SRefEventoParticipante.EventoParticipante eventoParticipante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventoParticipanteService/actualizar", ReplyAction="http://tempuri.org/IEventoParticipanteService/actualizarResponse")]
        System.Threading.Tasks.Task<WebEventos.SRefEventoParticipante.ServiceResponse> actualizarAsync(WebEventos.SRefEventoParticipante.EventoParticipante eventoParticipante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventoParticipanteService/eliminar", ReplyAction="http://tempuri.org/IEventoParticipanteService/eliminarResponse")]
        WebEventos.SRefEventoParticipante.ServiceResponse eliminar(int CodEvento, int CodParticipante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventoParticipanteService/eliminar", ReplyAction="http://tempuri.org/IEventoParticipanteService/eliminarResponse")]
        System.Threading.Tasks.Task<WebEventos.SRefEventoParticipante.ServiceResponse> eliminarAsync(int CodEvento, int CodParticipante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventoParticipanteService/listar", ReplyAction="http://tempuri.org/IEventoParticipanteService/listarResponse")]
        WebEventos.SRefEventoParticipante.EventoParticipante[] listar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventoParticipanteService/listar", ReplyAction="http://tempuri.org/IEventoParticipanteService/listarResponse")]
        System.Threading.Tasks.Task<WebEventos.SRefEventoParticipante.EventoParticipante[]> listarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventoParticipanteService/buscar", ReplyAction="http://tempuri.org/IEventoParticipanteService/buscarResponse")]
        WebEventos.SRefEventoParticipante.EventoParticipante buscar(int CodEvento, int CodParticipante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventoParticipanteService/buscar", ReplyAction="http://tempuri.org/IEventoParticipanteService/buscarResponse")]
        System.Threading.Tasks.Task<WebEventos.SRefEventoParticipante.EventoParticipante> buscarAsync(int CodEvento, int CodParticipante);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEventoParticipanteServiceChannel : WebEventos.SRefEventoParticipante.IEventoParticipanteService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EventoParticipanteServiceClient : System.ServiceModel.ClientBase<WebEventos.SRefEventoParticipante.IEventoParticipanteService>, WebEventos.SRefEventoParticipante.IEventoParticipanteService {
        
        public EventoParticipanteServiceClient() {
        }
        
        public EventoParticipanteServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EventoParticipanteServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EventoParticipanteServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EventoParticipanteServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebEventos.SRefEventoParticipante.ServiceResponse registrar(WebEventos.SRefEventoParticipante.EventoParticipante eventoParticipante) {
            return base.Channel.registrar(eventoParticipante);
        }
        
        public System.Threading.Tasks.Task<WebEventos.SRefEventoParticipante.ServiceResponse> registrarAsync(WebEventos.SRefEventoParticipante.EventoParticipante eventoParticipante) {
            return base.Channel.registrarAsync(eventoParticipante);
        }
        
        public WebEventos.SRefEventoParticipante.ServiceResponse actualizar(WebEventos.SRefEventoParticipante.EventoParticipante eventoParticipante) {
            return base.Channel.actualizar(eventoParticipante);
        }
        
        public System.Threading.Tasks.Task<WebEventos.SRefEventoParticipante.ServiceResponse> actualizarAsync(WebEventos.SRefEventoParticipante.EventoParticipante eventoParticipante) {
            return base.Channel.actualizarAsync(eventoParticipante);
        }
        
        public WebEventos.SRefEventoParticipante.ServiceResponse eliminar(int CodEvento, int CodParticipante) {
            return base.Channel.eliminar(CodEvento, CodParticipante);
        }
        
        public System.Threading.Tasks.Task<WebEventos.SRefEventoParticipante.ServiceResponse> eliminarAsync(int CodEvento, int CodParticipante) {
            return base.Channel.eliminarAsync(CodEvento, CodParticipante);
        }
        
        public WebEventos.SRefEventoParticipante.EventoParticipante[] listar() {
            return base.Channel.listar();
        }
        
        public System.Threading.Tasks.Task<WebEventos.SRefEventoParticipante.EventoParticipante[]> listarAsync() {
            return base.Channel.listarAsync();
        }
        
        public WebEventos.SRefEventoParticipante.EventoParticipante buscar(int CodEvento, int CodParticipante) {
            return base.Channel.buscar(CodEvento, CodParticipante);
        }
        
        public System.Threading.Tasks.Task<WebEventos.SRefEventoParticipante.EventoParticipante> buscarAsync(int CodEvento, int CodParticipante) {
            return base.Channel.buscarAsync(CodEvento, CodParticipante);
        }
    }
}
