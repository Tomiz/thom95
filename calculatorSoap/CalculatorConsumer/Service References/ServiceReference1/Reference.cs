﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalculatorConsumer.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/calculatorSoap")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ICalculatorService")]
    public interface ICalculatorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Add", ReplyAction="http://tempuri.org/ICalculatorService/AddResponse")]
        double Add(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Add", ReplyAction="http://tempuri.org/ICalculatorService/AddResponse")]
        System.Threading.Tasks.Task<double> AddAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Subtract", ReplyAction="http://tempuri.org/ICalculatorService/SubtractResponse")]
        double Subtract(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Subtract", ReplyAction="http://tempuri.org/ICalculatorService/SubtractResponse")]
        System.Threading.Tasks.Task<double> SubtractAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Multiplier", ReplyAction="http://tempuri.org/ICalculatorService/MultiplierResponse")]
        double Multiplier(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Multiplier", ReplyAction="http://tempuri.org/ICalculatorService/MultiplierResponse")]
        System.Threading.Tasks.Task<double> MultiplierAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Division", ReplyAction="http://tempuri.org/ICalculatorService/DivisionResponse")]
        double Division(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Division", ReplyAction="http://tempuri.org/ICalculatorService/DivisionResponse")]
        System.Threading.Tasks.Task<double> DivisionAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/ICalculatorService/GetDataUsingDataContractResponse")]
        CalculatorConsumer.ServiceReference1.CompositeType GetDataUsingDataContract(CalculatorConsumer.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/ICalculatorService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<CalculatorConsumer.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(CalculatorConsumer.ServiceReference1.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorServiceChannel : CalculatorConsumer.ServiceReference1.ICalculatorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorServiceClient : System.ServiceModel.ClientBase<CalculatorConsumer.ServiceReference1.ICalculatorService>, CalculatorConsumer.ServiceReference1.ICalculatorService {
        
        public CalculatorServiceClient() {
        }
        
        public CalculatorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Add(double a, double b) {
            return base.Channel.Add(a, b);
        }
        
        public System.Threading.Tasks.Task<double> AddAsync(double a, double b) {
            return base.Channel.AddAsync(a, b);
        }
        
        public double Subtract(double a, double b) {
            return base.Channel.Subtract(a, b);
        }
        
        public System.Threading.Tasks.Task<double> SubtractAsync(double a, double b) {
            return base.Channel.SubtractAsync(a, b);
        }
        
        public double Multiplier(double a, double b) {
            return base.Channel.Multiplier(a, b);
        }
        
        public System.Threading.Tasks.Task<double> MultiplierAsync(double a, double b) {
            return base.Channel.MultiplierAsync(a, b);
        }
        
        public double Division(double a, double b) {
            return base.Channel.Division(a, b);
        }
        
        public System.Threading.Tasks.Task<double> DivisionAsync(double a, double b) {
            return base.Channel.DivisionAsync(a, b);
        }
        
        public CalculatorConsumer.ServiceReference1.CompositeType GetDataUsingDataContract(CalculatorConsumer.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<CalculatorConsumer.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(CalculatorConsumer.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
