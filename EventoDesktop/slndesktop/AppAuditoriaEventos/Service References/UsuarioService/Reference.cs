﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppAuditoriaEventos.UsuarioService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Usuario", Namespace="http://schemas.datacontract.org/2004/07/Sise.Entities")]
    [System.SerializableAttribute()]
    public partial class Usuario : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombresField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
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
        public string Apellidos {
            get {
                return this.ApellidosField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidosField, value) != true)) {
                    this.ApellidosField = value;
                    this.RaisePropertyChanged("Apellidos");
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
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
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
        public string Nombres {
            get {
                return this.NombresField;
            }
            set {
                if ((object.ReferenceEquals(this.NombresField, value) != true)) {
                    this.NombresField = value;
                    this.RaisePropertyChanged("Nombres");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UsuarioService.IUsuarioService")]
    public interface IUsuarioService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/registrar", ReplyAction="http://tempuri.org/IUsuarioService/registrarResponse")]
        AppAuditoriaEventos.UsuarioService.ServiceResponse registrar(AppAuditoriaEventos.UsuarioService.Usuario usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/registrar", ReplyAction="http://tempuri.org/IUsuarioService/registrarResponse")]
        System.Threading.Tasks.Task<AppAuditoriaEventos.UsuarioService.ServiceResponse> registrarAsync(AppAuditoriaEventos.UsuarioService.Usuario usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/actualizar", ReplyAction="http://tempuri.org/IUsuarioService/actualizarResponse")]
        AppAuditoriaEventos.UsuarioService.ServiceResponse actualizar(AppAuditoriaEventos.UsuarioService.Usuario usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/actualizar", ReplyAction="http://tempuri.org/IUsuarioService/actualizarResponse")]
        System.Threading.Tasks.Task<AppAuditoriaEventos.UsuarioService.ServiceResponse> actualizarAsync(AppAuditoriaEventos.UsuarioService.Usuario usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/eliminar", ReplyAction="http://tempuri.org/IUsuarioService/eliminarResponse")]
        AppAuditoriaEventos.UsuarioService.ServiceResponse eliminar(int CodUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/eliminar", ReplyAction="http://tempuri.org/IUsuarioService/eliminarResponse")]
        System.Threading.Tasks.Task<AppAuditoriaEventos.UsuarioService.ServiceResponse> eliminarAsync(int CodUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/listar", ReplyAction="http://tempuri.org/IUsuarioService/listarResponse")]
        AppAuditoriaEventos.UsuarioService.Usuario[] listar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/listar", ReplyAction="http://tempuri.org/IUsuarioService/listarResponse")]
        System.Threading.Tasks.Task<AppAuditoriaEventos.UsuarioService.Usuario[]> listarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/buscar", ReplyAction="http://tempuri.org/IUsuarioService/buscarResponse")]
        AppAuditoriaEventos.UsuarioService.Usuario buscar(int CodUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/buscar", ReplyAction="http://tempuri.org/IUsuarioService/buscarResponse")]
        System.Threading.Tasks.Task<AppAuditoriaEventos.UsuarioService.Usuario> buscarAsync(int CodUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/login", ReplyAction="http://tempuri.org/IUsuarioService/loginResponse")]
        AppAuditoriaEventos.UsuarioService.Usuario login(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/login", ReplyAction="http://tempuri.org/IUsuarioService/loginResponse")]
        System.Threading.Tasks.Task<AppAuditoriaEventos.UsuarioService.Usuario> loginAsync(string email, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUsuarioServiceChannel : AppAuditoriaEventos.UsuarioService.IUsuarioService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UsuarioServiceClient : System.ServiceModel.ClientBase<AppAuditoriaEventos.UsuarioService.IUsuarioService>, AppAuditoriaEventos.UsuarioService.IUsuarioService {
        
        public UsuarioServiceClient() {
        }
        
        public UsuarioServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UsuarioServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuarioServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuarioServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AppAuditoriaEventos.UsuarioService.ServiceResponse registrar(AppAuditoriaEventos.UsuarioService.Usuario usuario) {
            return base.Channel.registrar(usuario);
        }
        
        public System.Threading.Tasks.Task<AppAuditoriaEventos.UsuarioService.ServiceResponse> registrarAsync(AppAuditoriaEventos.UsuarioService.Usuario usuario) {
            return base.Channel.registrarAsync(usuario);
        }
        
        public AppAuditoriaEventos.UsuarioService.ServiceResponse actualizar(AppAuditoriaEventos.UsuarioService.Usuario usuario) {
            return base.Channel.actualizar(usuario);
        }
        
        public System.Threading.Tasks.Task<AppAuditoriaEventos.UsuarioService.ServiceResponse> actualizarAsync(AppAuditoriaEventos.UsuarioService.Usuario usuario) {
            return base.Channel.actualizarAsync(usuario);
        }
        
        public AppAuditoriaEventos.UsuarioService.ServiceResponse eliminar(int CodUsuario) {
            return base.Channel.eliminar(CodUsuario);
        }
        
        public System.Threading.Tasks.Task<AppAuditoriaEventos.UsuarioService.ServiceResponse> eliminarAsync(int CodUsuario) {
            return base.Channel.eliminarAsync(CodUsuario);
        }
        
        public AppAuditoriaEventos.UsuarioService.Usuario[] listar() {
            return base.Channel.listar();
        }
        
        public System.Threading.Tasks.Task<AppAuditoriaEventos.UsuarioService.Usuario[]> listarAsync() {
            return base.Channel.listarAsync();
        }
        
        public AppAuditoriaEventos.UsuarioService.Usuario buscar(int CodUsuario) {
            return base.Channel.buscar(CodUsuario);
        }
        
        public System.Threading.Tasks.Task<AppAuditoriaEventos.UsuarioService.Usuario> buscarAsync(int CodUsuario) {
            return base.Channel.buscarAsync(CodUsuario);
        }
        
        public AppAuditoriaEventos.UsuarioService.Usuario login(string email, string password) {
            return base.Channel.login(email, password);
        }
        
        public System.Threading.Tasks.Task<AppAuditoriaEventos.UsuarioService.Usuario> loginAsync(string email, string password) {
            return base.Channel.loginAsync(email, password);
        }
    }
}