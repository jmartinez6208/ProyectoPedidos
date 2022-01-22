﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace PresentacionMovil.wcfProductoTienda {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4161.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IProductoTiendaWCF", Namespace="http://tempuri.org/")]
    public partial class ProductoTiendaWCF : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback DevolverListaProductosOperationCompleted;
        
        private System.Threading.SendOrPostCallback DevolverListaProductosPorCategoriaOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ProductoTiendaWCF() {
            this.Url = "http://proyectopedidos.somee.com/ProductoTiendaWCF.svc";
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
        public event DevolverListaProductosCompletedEventHandler DevolverListaProductosCompleted;
        
        /// <remarks/>
        public event DevolverListaProductosPorCategoriaCompletedEventHandler DevolverListaProductosPorCategoriaCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IProductoTiendaWCF/DevolverListaProductos", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/Entidades")]
        public ProductosTiendaEntidades[] DevolverListaProductos() {
            object[] results = this.Invoke("DevolverListaProductos", new object[0]);
            return ((ProductosTiendaEntidades[])(results[0]));
        }
        
        /// <remarks/>
        public void DevolverListaProductosAsync() {
            this.DevolverListaProductosAsync(null);
        }
        
        /// <remarks/>
        public void DevolverListaProductosAsync(object userState) {
            if ((this.DevolverListaProductosOperationCompleted == null)) {
                this.DevolverListaProductosOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDevolverListaProductosOperationCompleted);
            }
            this.InvokeAsync("DevolverListaProductos", new object[0], this.DevolverListaProductosOperationCompleted, userState);
        }
        
        private void OnDevolverListaProductosOperationCompleted(object arg) {
            if ((this.DevolverListaProductosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DevolverListaProductosCompleted(this, new DevolverListaProductosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IProductoTiendaWCF/DevolverListaProductosPorCategoria", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/Entidades")]
        public ProductosTiendaEntidades[] DevolverListaProductosPorCategoria(int idCategoria, [System.Xml.Serialization.XmlIgnoreAttribute()] bool idCategoriaSpecified) {
            object[] results = this.Invoke("DevolverListaProductosPorCategoria", new object[] {
                        idCategoria,
                        idCategoriaSpecified});
            return ((ProductosTiendaEntidades[])(results[0]));
        }
        
        /// <remarks/>
        public void DevolverListaProductosPorCategoriaAsync(int idCategoria, bool idCategoriaSpecified) {
            this.DevolverListaProductosPorCategoriaAsync(idCategoria, idCategoriaSpecified, null);
        }
        
        /// <remarks/>
        public void DevolverListaProductosPorCategoriaAsync(int idCategoria, bool idCategoriaSpecified, object userState) {
            if ((this.DevolverListaProductosPorCategoriaOperationCompleted == null)) {
                this.DevolverListaProductosPorCategoriaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDevolverListaProductosPorCategoriaOperationCompleted);
            }
            this.InvokeAsync("DevolverListaProductosPorCategoria", new object[] {
                        idCategoria,
                        idCategoriaSpecified}, this.DevolverListaProductosPorCategoriaOperationCompleted, userState);
        }
        
        private void OnDevolverListaProductosPorCategoriaOperationCompleted(object arg) {
            if ((this.DevolverListaProductosPorCategoriaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DevolverListaProductosPorCategoriaCompleted(this, new DevolverListaProductosPorCategoriaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4161.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Entidades")]
    public partial class ProductosTiendaEntidades {
        
        private int idField;
        
        private bool idFieldSpecified;
        
        private int idCategoriaField;
        
        private bool idCategoriaFieldSpecified;
        
        private int idProductoField;
        
        private bool idProductoFieldSpecified;
        
        private int idTiendaField;
        
        private bool idTiendaFieldSpecified;
        
        private long imagenField;
        
        private bool imagenFieldSpecified;
        
        private string nombreProductoField;
        
        private string nombreTiendaField;
        
        private double precioField;
        
        private bool precioFieldSpecified;
        
        private int stockField;
        
        private bool stockFieldSpecified;
        
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
        public int IdCategoria {
            get {
                return this.idCategoriaField;
            }
            set {
                this.idCategoriaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdCategoriaSpecified {
            get {
                return this.idCategoriaFieldSpecified;
            }
            set {
                this.idCategoriaFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int IdProducto {
            get {
                return this.idProductoField;
            }
            set {
                this.idProductoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdProductoSpecified {
            get {
                return this.idProductoFieldSpecified;
            }
            set {
                this.idProductoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int IdTienda {
            get {
                return this.idTiendaField;
            }
            set {
                this.idTiendaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdTiendaSpecified {
            get {
                return this.idTiendaFieldSpecified;
            }
            set {
                this.idTiendaFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public long Imagen {
            get {
                return this.imagenField;
            }
            set {
                this.imagenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ImagenSpecified {
            get {
                return this.imagenFieldSpecified;
            }
            set {
                this.imagenFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string NombreProducto {
            get {
                return this.nombreProductoField;
            }
            set {
                this.nombreProductoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string NombreTienda {
            get {
                return this.nombreTiendaField;
            }
            set {
                this.nombreTiendaField = value;
            }
        }
        
        /// <remarks/>
        public double Precio {
            get {
                return this.precioField;
            }
            set {
                this.precioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrecioSpecified {
            get {
                return this.precioFieldSpecified;
            }
            set {
                this.precioFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int Stock {
            get {
                return this.stockField;
            }
            set {
                this.stockField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StockSpecified {
            get {
                return this.stockFieldSpecified;
            }
            set {
                this.stockFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4161.0")]
    public delegate void DevolverListaProductosCompletedEventHandler(object sender, DevolverListaProductosCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4161.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DevolverListaProductosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DevolverListaProductosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ProductosTiendaEntidades[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ProductosTiendaEntidades[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4161.0")]
    public delegate void DevolverListaProductosPorCategoriaCompletedEventHandler(object sender, DevolverListaProductosPorCategoriaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4161.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DevolverListaProductosPorCategoriaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DevolverListaProductosPorCategoriaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ProductosTiendaEntidades[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ProductosTiendaEntidades[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591