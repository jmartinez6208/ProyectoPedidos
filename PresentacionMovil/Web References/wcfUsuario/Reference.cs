﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace PresentacionMovil.wcfUsuario {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IUsuarioWCF", Namespace="http://tempuri.org/")]
    public partial class UsuarioWCF : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback DevolverUsuarioOperationCompleted;
        
        private System.Threading.SendOrPostCallback NuevoOperationCompleted;
        
        private System.Threading.SendOrPostCallback LoginOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public UsuarioWCF() {
            this.Url = "http://proyectopedidos.somee.com/UsuarioWCF.svc";
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event DevolverUsuarioCompletedEventHandler DevolverUsuarioCompleted;
        
        /// <remarks/>
        public event NuevoCompletedEventHandler NuevoCompleted;
        
        /// <remarks/>
        public event LoginCompletedEventHandler LoginCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IUsuarioWCF/DevolverUsuario", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public UsuarioEntidades DevolverUsuario([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string username) {
            object[] results = this.Invoke("DevolverUsuario", new object[] {
                        username});
            return ((UsuarioEntidades)(results[0]));
        }
        
        /// <remarks/>
        public void DevolverUsuarioAsync(string username) {
            this.DevolverUsuarioAsync(username, null);
        }
        
        /// <remarks/>
        public void DevolverUsuarioAsync(string username, object userState) {
            if ((this.DevolverUsuarioOperationCompleted == null)) {
                this.DevolverUsuarioOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDevolverUsuarioOperationCompleted);
            }
            this.InvokeAsync("DevolverUsuario", new object[] {
                        username}, this.DevolverUsuarioOperationCompleted, userState);
        }
        
        private void OnDevolverUsuarioOperationCompleted(object arg) {
            if ((this.DevolverUsuarioCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DevolverUsuarioCompleted(this, new DevolverUsuarioCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IUsuarioWCF/Nuevo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public UsuarioEntidades Nuevo([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] UsuarioEntidades usuario) {
            object[] results = this.Invoke("Nuevo", new object[] {
                        usuario});
            return ((UsuarioEntidades)(results[0]));
        }
        
        /// <remarks/>
        public void NuevoAsync(UsuarioEntidades usuario) {
            this.NuevoAsync(usuario, null);
        }
        
        /// <remarks/>
        public void NuevoAsync(UsuarioEntidades usuario, object userState) {
            if ((this.NuevoOperationCompleted == null)) {
                this.NuevoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnNuevoOperationCompleted);
            }
            this.InvokeAsync("Nuevo", new object[] {
                        usuario}, this.NuevoOperationCompleted, userState);
        }
        
        private void OnNuevoOperationCompleted(object arg) {
            if ((this.NuevoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.NuevoCompleted(this, new NuevoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IUsuarioWCF/Login", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public UsuarioEntidades Login([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string username, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string password) {
            object[] results = this.Invoke("Login", new object[] {
                        username,
                        password});
            return ((UsuarioEntidades)(results[0]));
        }
        
        /// <remarks/>
        public void LoginAsync(string username, string password) {
            this.LoginAsync(username, password, null);
        }
        
        /// <remarks/>
        public void LoginAsync(string username, string password, object userState) {
            if ((this.LoginOperationCompleted == null)) {
                this.LoginOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLoginOperationCompleted);
            }
            this.InvokeAsync("Login", new object[] {
                        username,
                        password}, this.LoginOperationCompleted, userState);
        }
        
        private void OnLoginOperationCompleted(object arg) {
            if ((this.LoginCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LoginCompleted(this, new LoginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Entidades")]
    public partial class UsuarioEntidades {
        
        private string contraseñaField;
        
        private string fechaCreacionField;
        
        private int idField;
        
        private bool idFieldSpecified;
        
        private int idTipoUsuarioField;
        
        private bool idTipoUsuarioFieldSpecified;
        
        private string nombreField;
        
        private string userField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Contraseña {
            get {
                return this.contraseñaField;
            }
            set {
                this.contraseñaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string FechaCreacion {
            get {
                return this.fechaCreacionField;
            }
            set {
                this.fechaCreacionField = value;
            }
        }
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int IdTipoUsuario {
            get {
                return this.idTipoUsuarioField;
            }
            set {
                this.idTipoUsuarioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdTipoUsuarioSpecified {
            get {
                return this.idTipoUsuarioFieldSpecified;
            }
            set {
                this.idTipoUsuarioFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string User {
            get {
                return this.userField;
            }
            set {
                this.userField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void DevolverUsuarioCompletedEventHandler(object sender, DevolverUsuarioCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DevolverUsuarioCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DevolverUsuarioCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public UsuarioEntidades Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((UsuarioEntidades)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void NuevoCompletedEventHandler(object sender, NuevoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class NuevoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal NuevoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public UsuarioEntidades Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((UsuarioEntidades)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void LoginCompletedEventHandler(object sender, LoginCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LoginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public UsuarioEntidades Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((UsuarioEntidades)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591