﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankManager.LogServices {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ErrorView", Namespace="http://schemas.datacontract.org/2004/07/DSABusinessServices.Log")]
    [System.SerializableAttribute()]
    public partial class ErrorView : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> DateTriggeredField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InnerExceptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
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
        public System.Nullable<System.DateTime> DateTriggered {
            get {
                return this.DateTriggeredField;
            }
            set {
                if ((this.DateTriggeredField.Equals(value) != true)) {
                    this.DateTriggeredField = value;
                    this.RaisePropertyChanged("DateTriggered");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InnerException {
            get {
                return this.InnerExceptionField;
            }
            set {
                if ((object.ReferenceEquals(this.InnerExceptionField, value) != true)) {
                    this.InnerExceptionField = value;
                    this.RaisePropertyChanged("InnerException");
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
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="EventView", Namespace="http://schemas.datacontract.org/2004/07/DSABusinessServices.Log")]
    [System.SerializableAttribute()]
    public partial class EventView : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> DateModifiedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModifiedByField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SourceTableField;
        
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
        public System.Nullable<System.DateTime> DateModified {
            get {
                return this.DateModifiedField;
            }
            set {
                if ((this.DateModifiedField.Equals(value) != true)) {
                    this.DateModifiedField = value;
                    this.RaisePropertyChanged("DateModified");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
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
        public string ModifiedBy {
            get {
                return this.ModifiedByField;
            }
            set {
                if ((object.ReferenceEquals(this.ModifiedByField, value) != true)) {
                    this.ModifiedByField = value;
                    this.RaisePropertyChanged("ModifiedBy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SourceTable {
            get {
                return this.SourceTableField;
            }
            set {
                if ((object.ReferenceEquals(this.SourceTableField, value) != true)) {
                    this.SourceTableField = value;
                    this.RaisePropertyChanged("SourceTable");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LogServices.ILogServices")]
    public interface ILogServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogServices/DeleteError", ReplyAction="http://tempuri.org/ILogServices/DeleteErrorResponse")]
        void DeleteError(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogServices/DeleteError", ReplyAction="http://tempuri.org/ILogServices/DeleteErrorResponse")]
        System.Threading.Tasks.Task DeleteErrorAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogServices/DeleteEvent", ReplyAction="http://tempuri.org/ILogServices/DeleteEventResponse")]
        void DeleteEvent(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogServices/DeleteEvent", ReplyAction="http://tempuri.org/ILogServices/DeleteEventResponse")]
        System.Threading.Tasks.Task DeleteEventAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogServices/ListErrors", ReplyAction="http://tempuri.org/ILogServices/ListErrorsResponse")]
        System.Collections.Generic.List<BankManager.LogServices.ErrorView> ListErrors();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogServices/ListErrors", ReplyAction="http://tempuri.org/ILogServices/ListErrorsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<BankManager.LogServices.ErrorView>> ListErrorsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogServices/ListEvents", ReplyAction="http://tempuri.org/ILogServices/ListEventsResponse")]
        System.Collections.Generic.List<BankManager.LogServices.EventView> ListEvents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogServices/ListEvents", ReplyAction="http://tempuri.org/ILogServices/ListEventsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<BankManager.LogServices.EventView>> ListEventsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogServices/LogError", ReplyAction="http://tempuri.org/ILogServices/LogErrorResponse")]
        void LogError(string username, string message, string innerException);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogServices/LogError", ReplyAction="http://tempuri.org/ILogServices/LogErrorResponse")]
        System.Threading.Tasks.Task LogErrorAsync(string username, string message, string innerException);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogServices/LogEvent", ReplyAction="http://tempuri.org/ILogServices/LogEventResponse")]
        void LogEvent(string username, string message, string source);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogServices/LogEvent", ReplyAction="http://tempuri.org/ILogServices/LogEventResponse")]
        System.Threading.Tasks.Task LogEventAsync(string username, string message, string source);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILogServicesChannel : BankManager.LogServices.ILogServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LogServicesClient : System.ServiceModel.ClientBase<BankManager.LogServices.ILogServices>, BankManager.LogServices.ILogServices {
        
        public LogServicesClient() {
        }
        
        public LogServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LogServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LogServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LogServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DeleteError(int id) {
            base.Channel.DeleteError(id);
        }
        
        public System.Threading.Tasks.Task DeleteErrorAsync(int id) {
            return base.Channel.DeleteErrorAsync(id);
        }
        
        public void DeleteEvent(int id) {
            base.Channel.DeleteEvent(id);
        }
        
        public System.Threading.Tasks.Task DeleteEventAsync(int id) {
            return base.Channel.DeleteEventAsync(id);
        }
        
        public System.Collections.Generic.List<BankManager.LogServices.ErrorView> ListErrors() {
            return base.Channel.ListErrors();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<BankManager.LogServices.ErrorView>> ListErrorsAsync() {
            return base.Channel.ListErrorsAsync();
        }
        
        public System.Collections.Generic.List<BankManager.LogServices.EventView> ListEvents() {
            return base.Channel.ListEvents();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<BankManager.LogServices.EventView>> ListEventsAsync() {
            return base.Channel.ListEventsAsync();
        }
        
        public void LogError(string username, string message, string innerException) {
            base.Channel.LogError(username, message, innerException);
        }
        
        public System.Threading.Tasks.Task LogErrorAsync(string username, string message, string innerException) {
            return base.Channel.LogErrorAsync(username, message, innerException);
        }
        
        public void LogEvent(string username, string message, string source) {
            base.Channel.LogEvent(username, message, source);
        }
        
        public System.Threading.Tasks.Task LogEventAsync(string username, string message, string source) {
            return base.Channel.LogEventAsync(username, message, source);
        }
    }
}
