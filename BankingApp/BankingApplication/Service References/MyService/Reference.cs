﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankingApplication.MyService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StringMagic", Namespace="http://schemas.datacontract.org/2004/07/MyWCFService2")]
    [System.SerializableAttribute()]
    public partial class StringMagic : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SmallField;
        
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
        public bool Small {
            get {
                return this.SmallField;
            }
            set {
                if ((this.SmallField.Equals(value) != true)) {
                    this.SmallField = value;
                    this.RaisePropertyChanged("Small");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyService.IMyService")]
    public interface IMyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/DoSomeMagicToString", ReplyAction="http://tempuri.org/IMyService/DoSomeMagicToStringResponse")]
        BankingApplication.MyService.StringMagic DoSomeMagicToString(BankingApplication.MyService.StringMagic sBuilder);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/DoSomeMagicToString", ReplyAction="http://tempuri.org/IMyService/DoSomeMagicToStringResponse")]
        System.Threading.Tasks.Task<BankingApplication.MyService.StringMagic> DoSomeMagicToStringAsync(BankingApplication.MyService.StringMagic sBuilder);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMyServiceChannel : BankingApplication.MyService.IMyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyServiceClient : System.ServiceModel.ClientBase<BankingApplication.MyService.IMyService>, BankingApplication.MyService.IMyService {
        
        public MyServiceClient() {
        }
        
        public MyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BankingApplication.MyService.StringMagic DoSomeMagicToString(BankingApplication.MyService.StringMagic sBuilder) {
            return base.Channel.DoSomeMagicToString(sBuilder);
        }
        
        public System.Threading.Tasks.Task<BankingApplication.MyService.StringMagic> DoSomeMagicToStringAsync(BankingApplication.MyService.StringMagic sBuilder) {
            return base.Channel.DoSomeMagicToStringAsync(sBuilder);
        }
    }
}
