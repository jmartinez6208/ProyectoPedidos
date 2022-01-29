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

namespace PresentacionMovil.wcfCategorias {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_ICategoriaWCF", Namespace="http://tempuri.org/")]
    public partial class CategoriaWCF : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback EliminarCategoriaPorIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback NuevoOperationCompleted;
        
        private System.Threading.SendOrPostCallback ActualizarOperationCompleted;
        
        private System.Threading.SendOrPostCallback DevolverListaCategoriaOperationCompleted;
        
        private System.Threading.SendOrPostCallback DevolverCategoriaPorNombreOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public CategoriaWCF() {
            this.Url = "http://proyectopedidos.somee.com/CategoriaWCF.svc";
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
        public event EliminarCategoriaPorIdCompletedEventHandler EliminarCategoriaPorIdCompleted;
        
        /// <remarks/>
        public event NuevoCompletedEventHandler NuevoCompleted;
        
        /// <remarks/>
        public event ActualizarCompletedEventHandler ActualizarCompleted;
        
        /// <remarks/>
        public event DevolverListaCategoriaCompletedEventHandler DevolverListaCategoriaCompleted;
        
        /// <remarks/>
        public event DevolverCategoriaPorNombreCompletedEventHandler DevolverCategoriaPorNombreCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ICategoriaWCF/EliminarCategoriaPorId", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void EliminarCategoriaPorId(int identificador, [System.Xml.Serialization.XmlIgnoreAttribute()] bool identificadorSpecified, out bool EliminarCategoriaPorIdResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool EliminarCategoriaPorIdResultSpecified) {
            object[] results = this.Invoke("EliminarCategoriaPorId", new object[] {
                        identificador,
                        identificadorSpecified});
            EliminarCategoriaPorIdResult = ((bool)(results[0]));
            EliminarCategoriaPorIdResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void EliminarCategoriaPorIdAsync(int identificador, bool identificadorSpecified) {
            this.EliminarCategoriaPorIdAsync(identificador, identificadorSpecified, null);
        }
        
        /// <remarks/>
        public void EliminarCategoriaPorIdAsync(int identificador, bool identificadorSpecified, object userState) {
            if ((this.EliminarCategoriaPorIdOperationCompleted == null)) {
                this.EliminarCategoriaPorIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEliminarCategoriaPorIdOperationCompleted);
            }
            this.InvokeAsync("EliminarCategoriaPorId", new object[] {
                        identificador,
                        identificadorSpecified}, this.EliminarCategoriaPorIdOperationCompleted, userState);
        }
        
        private void OnEliminarCategoriaPorIdOperationCompleted(object arg) {
            if ((this.EliminarCategoriaPorIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.EliminarCategoriaPorIdCompleted(this, new EliminarCategoriaPorIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ICategoriaWCF/Nuevo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public CategoriaEntidades Nuevo([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] CategoriaEntidades categoria) {
            object[] results = this.Invoke("Nuevo", new object[] {
                        categoria});
            return ((CategoriaEntidades)(results[0]));
        }
        
        /// <remarks/>
        public void NuevoAsync(CategoriaEntidades categoria) {
            this.NuevoAsync(categoria, null);
        }
        
        /// <remarks/>
        public void NuevoAsync(CategoriaEntidades categoria, object userState) {
            if ((this.NuevoOperationCompleted == null)) {
                this.NuevoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnNuevoOperationCompleted);
            }
            this.InvokeAsync("Nuevo", new object[] {
                        categoria}, this.NuevoOperationCompleted, userState);
        }
        
        private void OnNuevoOperationCompleted(object arg) {
            if ((this.NuevoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.NuevoCompleted(this, new NuevoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ICategoriaWCF/Actualizar", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public CategoriaEntidades Actualizar([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] CategoriaEntidades categoria) {
            object[] results = this.Invoke("Actualizar", new object[] {
                        categoria});
            return ((CategoriaEntidades)(results[0]));
        }
        
        /// <remarks/>
        public void ActualizarAsync(CategoriaEntidades categoria) {
            this.ActualizarAsync(categoria, null);
        }
        
        /// <remarks/>
        public void ActualizarAsync(CategoriaEntidades categoria, object userState) {
            if ((this.ActualizarOperationCompleted == null)) {
                this.ActualizarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnActualizarOperationCompleted);
            }
            this.InvokeAsync("Actualizar", new object[] {
                        categoria}, this.ActualizarOperationCompleted, userState);
        }
        
        private void OnActualizarOperationCompleted(object arg) {
            if ((this.ActualizarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ActualizarCompleted(this, new ActualizarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ICategoriaWCF/DevolverListaCategoria", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/Entidades")]
        public CategoriaEntidades[] DevolverListaCategoria() {
            object[] results = this.Invoke("DevolverListaCategoria", new object[0]);
            return ((CategoriaEntidades[])(results[0]));
        }
        
        /// <remarks/>
        public void DevolverListaCategoriaAsync() {
            this.DevolverListaCategoriaAsync(null);
        }
        
        /// <remarks/>
        public void DevolverListaCategoriaAsync(object userState) {
            if ((this.DevolverListaCategoriaOperationCompleted == null)) {
                this.DevolverListaCategoriaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDevolverListaCategoriaOperationCompleted);
            }
            this.InvokeAsync("DevolverListaCategoria", new object[0], this.DevolverListaCategoriaOperationCompleted, userState);
        }
        
        private void OnDevolverListaCategoriaOperationCompleted(object arg) {
            if ((this.DevolverListaCategoriaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DevolverListaCategoriaCompleted(this, new DevolverListaCategoriaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ICategoriaWCF/DevolverCategoriaPorNombre", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public CategoriaEntidades DevolverCategoriaPorNombre([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string nombreCategoria) {
            object[] results = this.Invoke("DevolverCategoriaPorNombre", new object[] {
                        nombreCategoria});
            return ((CategoriaEntidades)(results[0]));
        }
        
        /// <remarks/>
        public void DevolverCategoriaPorNombreAsync(string nombreCategoria) {
            this.DevolverCategoriaPorNombreAsync(nombreCategoria, null);
        }
        
        /// <remarks/>
        public void DevolverCategoriaPorNombreAsync(string nombreCategoria, object userState) {
            if ((this.DevolverCategoriaPorNombreOperationCompleted == null)) {
                this.DevolverCategoriaPorNombreOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDevolverCategoriaPorNombreOperationCompleted);
            }
            this.InvokeAsync("DevolverCategoriaPorNombre", new object[] {
                        nombreCategoria}, this.DevolverCategoriaPorNombreOperationCompleted, userState);
        }
        
        private void OnDevolverCategoriaPorNombreOperationCompleted(object arg) {
            if ((this.DevolverCategoriaPorNombreCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DevolverCategoriaPorNombreCompleted(this, new DevolverCategoriaPorNombreCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public partial class CategoriaEntidades {
        
        private string descripcionField;
        
        private int idField;
        
        private bool idFieldSpecified;
        
        private string nombreField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void EliminarCategoriaPorIdCompletedEventHandler(object sender, EliminarCategoriaPorIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class EliminarCategoriaPorIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal EliminarCategoriaPorIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool EliminarCategoriaPorIdResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool EliminarCategoriaPorIdResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
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
        public CategoriaEntidades Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CategoriaEntidades)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ActualizarCompletedEventHandler(object sender, ActualizarCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ActualizarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ActualizarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public CategoriaEntidades Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CategoriaEntidades)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void DevolverListaCategoriaCompletedEventHandler(object sender, DevolverListaCategoriaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DevolverListaCategoriaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DevolverListaCategoriaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public CategoriaEntidades[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CategoriaEntidades[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void DevolverCategoriaPorNombreCompletedEventHandler(object sender, DevolverCategoriaPorNombreCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DevolverCategoriaPorNombreCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DevolverCategoriaPorNombreCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public CategoriaEntidades Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CategoriaEntidades)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591