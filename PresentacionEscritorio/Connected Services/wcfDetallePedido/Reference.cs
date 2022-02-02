﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PresentacionEscritorio.wcfDetallePedido {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DetallePedidoEntidades", Namespace="http://schemas.datacontract.org/2004/07/Entidades")]
    [System.SerializableAttribute()]
    public partial class DetallePedidoEntidades : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CantidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private char ConseguidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdPedidoPerteneceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdProductoTiendaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double SubtotalField;
        
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
        public int Cantidad {
            get {
                return this.CantidadField;
            }
            set {
                if ((this.CantidadField.Equals(value) != true)) {
                    this.CantidadField = value;
                    this.RaisePropertyChanged("Cantidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public char Conseguido {
            get {
                return this.ConseguidoField;
            }
            set {
                if ((this.ConseguidoField.Equals(value) != true)) {
                    this.ConseguidoField = value;
                    this.RaisePropertyChanged("Conseguido");
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
        public int IdPedidoPertenece {
            get {
                return this.IdPedidoPerteneceField;
            }
            set {
                if ((this.IdPedidoPerteneceField.Equals(value) != true)) {
                    this.IdPedidoPerteneceField = value;
                    this.RaisePropertyChanged("IdPedidoPertenece");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdProductoTienda {
            get {
                return this.IdProductoTiendaField;
            }
            set {
                if ((this.IdProductoTiendaField.Equals(value) != true)) {
                    this.IdProductoTiendaField = value;
                    this.RaisePropertyChanged("IdProductoTienda");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Subtotal {
            get {
                return this.SubtotalField;
            }
            set {
                if ((this.SubtotalField.Equals(value) != true)) {
                    this.SubtotalField = value;
                    this.RaisePropertyChanged("Subtotal");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wcfDetallePedido.IDetallePedido")]
    public interface IDetallePedido {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDetallePedido/Nuevo", ReplyAction="http://tempuri.org/IDetallePedido/NuevoResponse")]
        PresentacionEscritorio.wcfDetallePedido.DetallePedidoEntidades Nuevo(PresentacionEscritorio.wcfDetallePedido.DetallePedidoEntidades detallePedido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDetallePedido/Nuevo", ReplyAction="http://tempuri.org/IDetallePedido/NuevoResponse")]
        System.Threading.Tasks.Task<PresentacionEscritorio.wcfDetallePedido.DetallePedidoEntidades> NuevoAsync(PresentacionEscritorio.wcfDetallePedido.DetallePedidoEntidades detallePedido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDetallePedido/EliminarDetallePedidoPorId", ReplyAction="http://tempuri.org/IDetallePedido/EliminarDetallePedidoPorIdResponse")]
        bool EliminarDetallePedidoPorId(int identificador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDetallePedido/EliminarDetallePedidoPorId", ReplyAction="http://tempuri.org/IDetallePedido/EliminarDetallePedidoPorIdResponse")]
        System.Threading.Tasks.Task<bool> EliminarDetallePedidoPorIdAsync(int identificador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDetallePedido/DevolerListaDetallesPorPedido", ReplyAction="http://tempuri.org/IDetallePedido/DevolerListaDetallesPorPedidoResponse")]
        PresentacionEscritorio.wcfDetallePedido.DetallePedidoEntidades[] DevolerListaDetallesPorPedido(int idPedido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDetallePedido/DevolerListaDetallesPorPedido", ReplyAction="http://tempuri.org/IDetallePedido/DevolerListaDetallesPorPedidoResponse")]
        System.Threading.Tasks.Task<PresentacionEscritorio.wcfDetallePedido.DetallePedidoEntidades[]> DevolerListaDetallesPorPedidoAsync(int idPedido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDetallePedido/DevolverDetallePorId", ReplyAction="http://tempuri.org/IDetallePedido/DevolverDetallePorIdResponse")]
        PresentacionEscritorio.wcfDetallePedido.DetallePedidoEntidades DevolverDetallePorId(int identificador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDetallePedido/DevolverDetallePorId", ReplyAction="http://tempuri.org/IDetallePedido/DevolverDetallePorIdResponse")]
        System.Threading.Tasks.Task<PresentacionEscritorio.wcfDetallePedido.DetallePedidoEntidades> DevolverDetallePorIdAsync(int identificador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDetallePedido/EliminarDetallesPorId", ReplyAction="http://tempuri.org/IDetallePedido/EliminarDetallesPorIdResponse")]
        bool EliminarDetallesPorId(int identificador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDetallePedido/EliminarDetallesPorId", ReplyAction="http://tempuri.org/IDetallePedido/EliminarDetallesPorIdResponse")]
        System.Threading.Tasks.Task<bool> EliminarDetallesPorIdAsync(int identificador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDetallePedido/MarcarConseguido", ReplyAction="http://tempuri.org/IDetallePedido/MarcarConseguidoResponse")]
        bool MarcarConseguido(int idDetallePedido, char estado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDetallePedido/MarcarConseguido", ReplyAction="http://tempuri.org/IDetallePedido/MarcarConseguidoResponse")]
        System.Threading.Tasks.Task<bool> MarcarConseguidoAsync(int idDetallePedido, char estado);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDetallePedidoChannel : PresentacionEscritorio.wcfDetallePedido.IDetallePedido, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DetallePedidoClient : System.ServiceModel.ClientBase<PresentacionEscritorio.wcfDetallePedido.IDetallePedido>, PresentacionEscritorio.wcfDetallePedido.IDetallePedido {
        
        public DetallePedidoClient() {
        }
        
        public DetallePedidoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DetallePedidoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DetallePedidoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DetallePedidoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PresentacionEscritorio.wcfDetallePedido.DetallePedidoEntidades Nuevo(PresentacionEscritorio.wcfDetallePedido.DetallePedidoEntidades detallePedido) {
            return base.Channel.Nuevo(detallePedido);
        }
        
        public System.Threading.Tasks.Task<PresentacionEscritorio.wcfDetallePedido.DetallePedidoEntidades> NuevoAsync(PresentacionEscritorio.wcfDetallePedido.DetallePedidoEntidades detallePedido) {
            return base.Channel.NuevoAsync(detallePedido);
        }
        
        public bool EliminarDetallePedidoPorId(int identificador) {
            return base.Channel.EliminarDetallePedidoPorId(identificador);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarDetallePedidoPorIdAsync(int identificador) {
            return base.Channel.EliminarDetallePedidoPorIdAsync(identificador);
        }
        
        public PresentacionEscritorio.wcfDetallePedido.DetallePedidoEntidades[] DevolerListaDetallesPorPedido(int idPedido) {
            return base.Channel.DevolerListaDetallesPorPedido(idPedido);
        }
        
        public System.Threading.Tasks.Task<PresentacionEscritorio.wcfDetallePedido.DetallePedidoEntidades[]> DevolerListaDetallesPorPedidoAsync(int idPedido) {
            return base.Channel.DevolerListaDetallesPorPedidoAsync(idPedido);
        }
        
        public PresentacionEscritorio.wcfDetallePedido.DetallePedidoEntidades DevolverDetallePorId(int identificador) {
            return base.Channel.DevolverDetallePorId(identificador);
        }
        
        public System.Threading.Tasks.Task<PresentacionEscritorio.wcfDetallePedido.DetallePedidoEntidades> DevolverDetallePorIdAsync(int identificador) {
            return base.Channel.DevolverDetallePorIdAsync(identificador);
        }
        
        public bool EliminarDetallesPorId(int identificador) {
            return base.Channel.EliminarDetallesPorId(identificador);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarDetallesPorIdAsync(int identificador) {
            return base.Channel.EliminarDetallesPorIdAsync(identificador);
        }
        
        public bool MarcarConseguido(int idDetallePedido, char estado) {
            return base.Channel.MarcarConseguido(idDetallePedido, estado);
        }
        
        public System.Threading.Tasks.Task<bool> MarcarConseguidoAsync(int idDetallePedido, char estado) {
            return base.Channel.MarcarConseguidoAsync(idDetallePedido, estado);
        }
    }
}
