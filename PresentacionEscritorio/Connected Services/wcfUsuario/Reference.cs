﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PresentacionEscritorio.wcfUsuario {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UsuarioEntidades", Namespace="http://schemas.datacontract.org/2004/07/Entidades")]
    [System.SerializableAttribute()]
    public partial class UsuarioEntidades : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContraseñaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FechaCreacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdTipoUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserField;
        
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
        public string Contraseña {
            get {
                return this.ContraseñaField;
            }
            set {
                if ((object.ReferenceEquals(this.ContraseñaField, value) != true)) {
                    this.ContraseñaField = value;
                    this.RaisePropertyChanged("Contraseña");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FechaCreacion {
            get {
                return this.FechaCreacionField;
            }
            set {
                if ((object.ReferenceEquals(this.FechaCreacionField, value) != true)) {
                    this.FechaCreacionField = value;
                    this.RaisePropertyChanged("FechaCreacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdTipoUsuario {
            get {
                return this.IdTipoUsuarioField;
            }
            set {
                if ((this.IdTipoUsuarioField.Equals(value) != true)) {
                    this.IdTipoUsuarioField = value;
                    this.RaisePropertyChanged("IdTipoUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoUsuario {
            get {
                return this.TipoUsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoUsuarioField, value) != true)) {
                    this.TipoUsuarioField = value;
                    this.RaisePropertyChanged("TipoUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="UsuarioWCF", Namespace="http://schemas.datacontract.org/2004/07/ServiciosWCF")]
    [System.SerializableAttribute()]
    public partial class UsuarioWCF : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wcfUsuario.IUsuarioWCF")]
    public interface IUsuarioWCF {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioWCF/DevolverUsuario", ReplyAction="http://tempuri.org/IUsuarioWCF/DevolverUsuarioResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(PresentacionEscritorio.wcfUsuario.UsuarioWCF), Action="http://tempuri.org/IUsuarioWCF/DevolverUsuarioUsuarioWCFFault", Name="UsuarioWCF", Namespace="http://schemas.datacontract.org/2004/07/ServiciosWCF")]
        PresentacionEscritorio.wcfUsuario.UsuarioEntidades DevolverUsuario(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioWCF/DevolverUsuario", ReplyAction="http://tempuri.org/IUsuarioWCF/DevolverUsuarioResponse")]
        System.Threading.Tasks.Task<PresentacionEscritorio.wcfUsuario.UsuarioEntidades> DevolverUsuarioAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioWCF/Nuevo", ReplyAction="http://tempuri.org/IUsuarioWCF/NuevoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(PresentacionEscritorio.wcfUsuario.UsuarioWCF), Action="http://tempuri.org/IUsuarioWCF/NuevoUsuarioWCFFault", Name="UsuarioWCF", Namespace="http://schemas.datacontract.org/2004/07/ServiciosWCF")]
        PresentacionEscritorio.wcfUsuario.UsuarioEntidades Nuevo(PresentacionEscritorio.wcfUsuario.UsuarioEntidades usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioWCF/Nuevo", ReplyAction="http://tempuri.org/IUsuarioWCF/NuevoResponse")]
        System.Threading.Tasks.Task<PresentacionEscritorio.wcfUsuario.UsuarioEntidades> NuevoAsync(PresentacionEscritorio.wcfUsuario.UsuarioEntidades usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioWCF/Login", ReplyAction="http://tempuri.org/IUsuarioWCF/LoginResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(PresentacionEscritorio.wcfUsuario.UsuarioWCF), Action="http://tempuri.org/IUsuarioWCF/LoginUsuarioWCFFault", Name="UsuarioWCF", Namespace="http://schemas.datacontract.org/2004/07/ServiciosWCF")]
        PresentacionEscritorio.wcfUsuario.UsuarioEntidades Login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioWCF/Login", ReplyAction="http://tempuri.org/IUsuarioWCF/LoginResponse")]
        System.Threading.Tasks.Task<PresentacionEscritorio.wcfUsuario.UsuarioEntidades> LoginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioWCF/DevolverUsuarioPorId", ReplyAction="http://tempuri.org/IUsuarioWCF/DevolverUsuarioPorIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(PresentacionEscritorio.wcfUsuario.UsuarioWCF), Action="http://tempuri.org/IUsuarioWCF/DevolverUsuarioPorIdUsuarioWCFFault", Name="UsuarioWCF", Namespace="http://schemas.datacontract.org/2004/07/ServiciosWCF")]
        PresentacionEscritorio.wcfUsuario.UsuarioEntidades DevolverUsuarioPorId(int identificador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioWCF/DevolverUsuarioPorId", ReplyAction="http://tempuri.org/IUsuarioWCF/DevolverUsuarioPorIdResponse")]
        System.Threading.Tasks.Task<PresentacionEscritorio.wcfUsuario.UsuarioEntidades> DevolverUsuarioPorIdAsync(int identificador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioWCF/DevolverListaRepartidores", ReplyAction="http://tempuri.org/IUsuarioWCF/DevolverListaRepartidoresResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(PresentacionEscritorio.wcfUsuario.UsuarioWCF), Action="http://tempuri.org/IUsuarioWCF/DevolverListaRepartidoresUsuarioWCFFault", Name="UsuarioWCF", Namespace="http://schemas.datacontract.org/2004/07/ServiciosWCF")]
        PresentacionEscritorio.wcfUsuario.UsuarioEntidades[] DevolverListaRepartidores();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioWCF/DevolverListaRepartidores", ReplyAction="http://tempuri.org/IUsuarioWCF/DevolverListaRepartidoresResponse")]
        System.Threading.Tasks.Task<PresentacionEscritorio.wcfUsuario.UsuarioEntidades[]> DevolverListaRepartidoresAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioWCF/EliminarRepartidorPorId", ReplyAction="http://tempuri.org/IUsuarioWCF/EliminarRepartidorPorIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(PresentacionEscritorio.wcfUsuario.UsuarioWCF), Action="http://tempuri.org/IUsuarioWCF/EliminarRepartidorPorIdUsuarioWCFFault", Name="UsuarioWCF", Namespace="http://schemas.datacontract.org/2004/07/ServiciosWCF")]
        bool EliminarRepartidorPorId(int identificador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioWCF/EliminarRepartidorPorId", ReplyAction="http://tempuri.org/IUsuarioWCF/EliminarRepartidorPorIdResponse")]
        System.Threading.Tasks.Task<bool> EliminarRepartidorPorIdAsync(int identificador);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUsuarioWCFChannel : PresentacionEscritorio.wcfUsuario.IUsuarioWCF, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UsuarioWCFClient : System.ServiceModel.ClientBase<PresentacionEscritorio.wcfUsuario.IUsuarioWCF>, PresentacionEscritorio.wcfUsuario.IUsuarioWCF {
        
        public UsuarioWCFClient() {
        }
        
        public UsuarioWCFClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UsuarioWCFClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuarioWCFClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuarioWCFClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PresentacionEscritorio.wcfUsuario.UsuarioEntidades DevolverUsuario(string username) {
            return base.Channel.DevolverUsuario(username);
        }
        
        public System.Threading.Tasks.Task<PresentacionEscritorio.wcfUsuario.UsuarioEntidades> DevolverUsuarioAsync(string username) {
            return base.Channel.DevolverUsuarioAsync(username);
        }
        
        public PresentacionEscritorio.wcfUsuario.UsuarioEntidades Nuevo(PresentacionEscritorio.wcfUsuario.UsuarioEntidades usuario) {
            return base.Channel.Nuevo(usuario);
        }
        
        public System.Threading.Tasks.Task<PresentacionEscritorio.wcfUsuario.UsuarioEntidades> NuevoAsync(PresentacionEscritorio.wcfUsuario.UsuarioEntidades usuario) {
            return base.Channel.NuevoAsync(usuario);
        }
        
        public PresentacionEscritorio.wcfUsuario.UsuarioEntidades Login(string username, string password) {
            return base.Channel.Login(username, password);
        }
        
        public System.Threading.Tasks.Task<PresentacionEscritorio.wcfUsuario.UsuarioEntidades> LoginAsync(string username, string password) {
            return base.Channel.LoginAsync(username, password);
        }
        
        public PresentacionEscritorio.wcfUsuario.UsuarioEntidades DevolverUsuarioPorId(int identificador) {
            return base.Channel.DevolverUsuarioPorId(identificador);
        }
        
        public System.Threading.Tasks.Task<PresentacionEscritorio.wcfUsuario.UsuarioEntidades> DevolverUsuarioPorIdAsync(int identificador) {
            return base.Channel.DevolverUsuarioPorIdAsync(identificador);
        }
        
        public PresentacionEscritorio.wcfUsuario.UsuarioEntidades[] DevolverListaRepartidores() {
            return base.Channel.DevolverListaRepartidores();
        }
        
        public System.Threading.Tasks.Task<PresentacionEscritorio.wcfUsuario.UsuarioEntidades[]> DevolverListaRepartidoresAsync() {
            return base.Channel.DevolverListaRepartidoresAsync();
        }
        
        public bool EliminarRepartidorPorId(int identificador) {
            return base.Channel.EliminarRepartidorPorId(identificador);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarRepartidorPorIdAsync(int identificador) {
            return base.Channel.EliminarRepartidorPorIdAsync(identificador);
        }
    }
}
