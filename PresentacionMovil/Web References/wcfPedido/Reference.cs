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

namespace PresentacionMovil.wcfPedido {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IPedidoWCF", Namespace="http://tempuri.org/")]
    public partial class PedidoWCF : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback NuevoOperationCompleted;
        
        private System.Threading.SendOrPostCallback ActualizarOperationCompleted;
        
        private System.Threading.SendOrPostCallback DevolverPedidoPorIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback DevolverListaPedidosOperationCompleted;
        
        private System.Threading.SendOrPostCallback EliminarPedidoPorIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback DevolverListaPedidosPorClienteOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public PedidoWCF() {
            this.Url = "http://proyectopedidos.somee.com/PedidoWCF.svc";
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
        public event NuevoCompletedEventHandler NuevoCompleted;
        
        /// <remarks/>
        public event ActualizarCompletedEventHandler ActualizarCompleted;
        
        /// <remarks/>
        public event DevolverPedidoPorIdCompletedEventHandler DevolverPedidoPorIdCompleted;
        
        /// <remarks/>
        public event DevolverListaPedidosCompletedEventHandler DevolverListaPedidosCompleted;
        
        /// <remarks/>
        public event EliminarPedidoPorIdCompletedEventHandler EliminarPedidoPorIdCompleted;
        
        /// <remarks/>
        public event DevolverListaPedidosPorClienteCompletedEventHandler DevolverListaPedidosPorClienteCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IPedidoWCF/Nuevo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public PedidoEntidades Nuevo([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] PedidoEntidades pedido) {
            object[] results = this.Invoke("Nuevo", new object[] {
                        pedido});
            return ((PedidoEntidades)(results[0]));
        }
        
        /// <remarks/>
        public void NuevoAsync(PedidoEntidades pedido) {
            this.NuevoAsync(pedido, null);
        }
        
        /// <remarks/>
        public void NuevoAsync(PedidoEntidades pedido, object userState) {
            if ((this.NuevoOperationCompleted == null)) {
                this.NuevoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnNuevoOperationCompleted);
            }
            this.InvokeAsync("Nuevo", new object[] {
                        pedido}, this.NuevoOperationCompleted, userState);
        }
        
        private void OnNuevoOperationCompleted(object arg) {
            if ((this.NuevoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.NuevoCompleted(this, new NuevoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IPedidoWCF/Actualizar", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public PedidoEntidades Actualizar([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] PedidoEntidades pedido) {
            object[] results = this.Invoke("Actualizar", new object[] {
                        pedido});
            return ((PedidoEntidades)(results[0]));
        }
        
        /// <remarks/>
        public void ActualizarAsync(PedidoEntidades pedido) {
            this.ActualizarAsync(pedido, null);
        }
        
        /// <remarks/>
        public void ActualizarAsync(PedidoEntidades pedido, object userState) {
            if ((this.ActualizarOperationCompleted == null)) {
                this.ActualizarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnActualizarOperationCompleted);
            }
            this.InvokeAsync("Actualizar", new object[] {
                        pedido}, this.ActualizarOperationCompleted, userState);
        }
        
        private void OnActualizarOperationCompleted(object arg) {
            if ((this.ActualizarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ActualizarCompleted(this, new ActualizarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IPedidoWCF/DevolverPedidoPorId", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public PedidoEntidades DevolverPedidoPorId(int identificador, [System.Xml.Serialization.XmlIgnoreAttribute()] bool identificadorSpecified) {
            object[] results = this.Invoke("DevolverPedidoPorId", new object[] {
                        identificador,
                        identificadorSpecified});
            return ((PedidoEntidades)(results[0]));
        }
        
        /// <remarks/>
        public void DevolverPedidoPorIdAsync(int identificador, bool identificadorSpecified) {
            this.DevolverPedidoPorIdAsync(identificador, identificadorSpecified, null);
        }
        
        /// <remarks/>
        public void DevolverPedidoPorIdAsync(int identificador, bool identificadorSpecified, object userState) {
            if ((this.DevolverPedidoPorIdOperationCompleted == null)) {
                this.DevolverPedidoPorIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDevolverPedidoPorIdOperationCompleted);
            }
            this.InvokeAsync("DevolverPedidoPorId", new object[] {
                        identificador,
                        identificadorSpecified}, this.DevolverPedidoPorIdOperationCompleted, userState);
        }
        
        private void OnDevolverPedidoPorIdOperationCompleted(object arg) {
            if ((this.DevolverPedidoPorIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DevolverPedidoPorIdCompleted(this, new DevolverPedidoPorIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IPedidoWCF/DevolverListaPedidos", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/Entidades")]
        public PedidoEntidades[] DevolverListaPedidos() {
            object[] results = this.Invoke("DevolverListaPedidos", new object[0]);
            return ((PedidoEntidades[])(results[0]));
        }
        
        /// <remarks/>
        public void DevolverListaPedidosAsync() {
            this.DevolverListaPedidosAsync(null);
        }
        
        /// <remarks/>
        public void DevolverListaPedidosAsync(object userState) {
            if ((this.DevolverListaPedidosOperationCompleted == null)) {
                this.DevolverListaPedidosOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDevolverListaPedidosOperationCompleted);
            }
            this.InvokeAsync("DevolverListaPedidos", new object[0], this.DevolverListaPedidosOperationCompleted, userState);
        }
        
        private void OnDevolverListaPedidosOperationCompleted(object arg) {
            if ((this.DevolverListaPedidosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DevolverListaPedidosCompleted(this, new DevolverListaPedidosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IPedidoWCF/EliminarPedidoPorId", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void EliminarPedidoPorId(int identificador, [System.Xml.Serialization.XmlIgnoreAttribute()] bool identificadorSpecified, out bool EliminarPedidoPorIdResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool EliminarPedidoPorIdResultSpecified) {
            object[] results = this.Invoke("EliminarPedidoPorId", new object[] {
                        identificador,
                        identificadorSpecified});
            EliminarPedidoPorIdResult = ((bool)(results[0]));
            EliminarPedidoPorIdResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void EliminarPedidoPorIdAsync(int identificador, bool identificadorSpecified) {
            this.EliminarPedidoPorIdAsync(identificador, identificadorSpecified, null);
        }
        
        /// <remarks/>
        public void EliminarPedidoPorIdAsync(int identificador, bool identificadorSpecified, object userState) {
            if ((this.EliminarPedidoPorIdOperationCompleted == null)) {
                this.EliminarPedidoPorIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEliminarPedidoPorIdOperationCompleted);
            }
            this.InvokeAsync("EliminarPedidoPorId", new object[] {
                        identificador,
                        identificadorSpecified}, this.EliminarPedidoPorIdOperationCompleted, userState);
        }
        
        private void OnEliminarPedidoPorIdOperationCompleted(object arg) {
            if ((this.EliminarPedidoPorIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.EliminarPedidoPorIdCompleted(this, new EliminarPedidoPorIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IPedidoWCF/DevolverListaPedidosPorCliente", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/Entidades")]
        public PedidoEntidades[] DevolverListaPedidosPorCliente(int idCliente, [System.Xml.Serialization.XmlIgnoreAttribute()] bool idClienteSpecified) {
            object[] results = this.Invoke("DevolverListaPedidosPorCliente", new object[] {
                        idCliente,
                        idClienteSpecified});
            return ((PedidoEntidades[])(results[0]));
        }
        
        /// <remarks/>
        public void DevolverListaPedidosPorClienteAsync(int idCliente, bool idClienteSpecified) {
            this.DevolverListaPedidosPorClienteAsync(idCliente, idClienteSpecified, null);
        }
        
        /// <remarks/>
        public void DevolverListaPedidosPorClienteAsync(int idCliente, bool idClienteSpecified, object userState) {
            if ((this.DevolverListaPedidosPorClienteOperationCompleted == null)) {
                this.DevolverListaPedidosPorClienteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDevolverListaPedidosPorClienteOperationCompleted);
            }
            this.InvokeAsync("DevolverListaPedidosPorCliente", new object[] {
                        idCliente,
                        idClienteSpecified}, this.DevolverListaPedidosPorClienteOperationCompleted, userState);
        }
        
        private void OnDevolverListaPedidosPorClienteOperationCompleted(object arg) {
            if ((this.DevolverListaPedidosPorClienteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DevolverListaPedidosPorClienteCompleted(this, new DevolverListaPedidosPorClienteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public partial class PedidoEntidades {
        
        private string estadoField;
        
        private string fechaCreacionField;
        
        private int idField;
        
        private bool idFieldSpecified;
        
        private int idClienteField;
        
        private bool idClienteFieldSpecified;
        
        private int idRepartidorField;
        
        private bool idRepartidorFieldSpecified;
        
        private double totalField;
        
        private bool totalFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Estado {
            get {
                return this.estadoField;
            }
            set {
                this.estadoField = value;
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
        public int IdCliente {
            get {
                return this.idClienteField;
            }
            set {
                this.idClienteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdClienteSpecified {
            get {
                return this.idClienteFieldSpecified;
            }
            set {
                this.idClienteFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int IdRepartidor {
            get {
                return this.idRepartidorField;
            }
            set {
                this.idRepartidorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdRepartidorSpecified {
            get {
                return this.idRepartidorFieldSpecified;
            }
            set {
                this.idRepartidorFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public double Total {
            get {
                return this.totalField;
            }
            set {
                this.totalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalSpecified {
            get {
                return this.totalFieldSpecified;
            }
            set {
                this.totalFieldSpecified = value;
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
        public PedidoEntidades Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((PedidoEntidades)(this.results[0]));
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
        public PedidoEntidades Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((PedidoEntidades)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void DevolverPedidoPorIdCompletedEventHandler(object sender, DevolverPedidoPorIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DevolverPedidoPorIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DevolverPedidoPorIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public PedidoEntidades Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((PedidoEntidades)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void DevolverListaPedidosCompletedEventHandler(object sender, DevolverListaPedidosCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DevolverListaPedidosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DevolverListaPedidosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public PedidoEntidades[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((PedidoEntidades[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void EliminarPedidoPorIdCompletedEventHandler(object sender, EliminarPedidoPorIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class EliminarPedidoPorIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal EliminarPedidoPorIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool EliminarPedidoPorIdResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool EliminarPedidoPorIdResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void DevolverListaPedidosPorClienteCompletedEventHandler(object sender, DevolverListaPedidosPorClienteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DevolverListaPedidosPorClienteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DevolverListaPedidosPorClienteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public PedidoEntidades[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((PedidoEntidades[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591