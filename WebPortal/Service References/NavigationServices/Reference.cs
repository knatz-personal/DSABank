﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebPortal.NavigationServices {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MenuView", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceDSABank")]
    [System.SerializableAttribute()]
    public partial class MenuView : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ActionNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ControllerNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> ParentIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> SortOrderField;
        
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
        public string ActionName {
            get {
                return this.ActionNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ActionNameField, value) != true)) {
                    this.ActionNameField = value;
                    this.RaisePropertyChanged("ActionName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ControllerName {
            get {
                return this.ControllerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ControllerNameField, value) != true)) {
                    this.ControllerNameField = value;
                    this.RaisePropertyChanged("ControllerName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ParentID {
            get {
                return this.ParentIDField;
            }
            set {
                if ((this.ParentIDField.Equals(value) != true)) {
                    this.ParentIDField = value;
                    this.RaisePropertyChanged("ParentID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> SortOrder {
            get {
                return this.SortOrderField;
            }
            set {
                if ((this.SortOrderField.Equals(value) != true)) {
                    this.SortOrderField = value;
                    this.RaisePropertyChanged("SortOrder");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NavigationServices.INavigationServices")]
    public interface INavigationServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INavigationServices/ListAll", ReplyAction="http://tempuri.org/INavigationServices/ListAllResponse")]
        System.Collections.Generic.List<WebPortal.NavigationServices.MenuView> ListAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INavigationServices/Create", ReplyAction="http://tempuri.org/INavigationServices/CreateResponse")]
        void Create(WebPortal.NavigationServices.MenuView menu);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INavigationServices/Read", ReplyAction="http://tempuri.org/INavigationServices/ReadResponse")]
        WebPortal.NavigationServices.MenuView Read(WebPortal.NavigationServices.MenuView itemToRead);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INavigationServices/Update", ReplyAction="http://tempuri.org/INavigationServices/UpdateResponse")]
        WebPortal.NavigationServices.MenuView Update(WebPortal.NavigationServices.MenuView updatedItem);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INavigationServices/Delete", ReplyAction="http://tempuri.org/INavigationServices/DeleteResponse")]
        void Delete(WebPortal.NavigationServices.MenuView itemToDelete);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INavigationServices/GetMenuByRole", ReplyAction="http://tempuri.org/INavigationServices/GetMenuByRoleResponse")]
        System.Collections.Generic.List<WebPortal.NavigationServices.MenuView> GetMenuByRole(int roleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INavigationServices/GetSubMenus", ReplyAction="http://tempuri.org/INavigationServices/GetSubMenusResponse")]
        System.Collections.Generic.List<WebPortal.NavigationServices.MenuView> GetSubMenus(int roleId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INavigationServicesChannel : WebPortal.NavigationServices.INavigationServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NavigationServicesClient : System.ServiceModel.ClientBase<WebPortal.NavigationServices.INavigationServices>, WebPortal.NavigationServices.INavigationServices {
        
        public NavigationServicesClient() {
        }
        
        public NavigationServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NavigationServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NavigationServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NavigationServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<WebPortal.NavigationServices.MenuView> ListAll() {
            return base.Channel.ListAll();
        }
        
        public void Create(WebPortal.NavigationServices.MenuView menu) {
            base.Channel.Create(menu);
        }
        
        public WebPortal.NavigationServices.MenuView Read(WebPortal.NavigationServices.MenuView itemToRead) {
            return base.Channel.Read(itemToRead);
        }
        
        public WebPortal.NavigationServices.MenuView Update(WebPortal.NavigationServices.MenuView updatedItem) {
            return base.Channel.Update(updatedItem);
        }
        
        public void Delete(WebPortal.NavigationServices.MenuView itemToDelete) {
            base.Channel.Delete(itemToDelete);
        }
        
        public System.Collections.Generic.List<WebPortal.NavigationServices.MenuView> GetMenuByRole(int roleId) {
            return base.Channel.GetMenuByRole(roleId);
        }
        
        public System.Collections.Generic.List<WebPortal.NavigationServices.MenuView> GetSubMenus(int roleId) {
            return base.Channel.GetSubMenus(roleId);
        }
    }
}
