﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebPortal.UserServices {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GenderView", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceDSABank")]
    [System.SerializableAttribute()]
    public partial class GenderView : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
    [System.Runtime.Serialization.DataContractAttribute(Name="RoleView", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceDSABank")]
    [System.SerializableAttribute()]
    public partial class RoleView : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
    [System.Runtime.Serialization.DataContractAttribute(Name="UserView", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceDSABank")]
    [System.SerializableAttribute()]
    public partial class UserView : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BlockedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateOfBirthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> GenderIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenderNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MiddleInitialField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MobileField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NoOfAttemptsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<WebPortal.UserServices.RoleView> RolesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SaltField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> TownIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TownNameField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Blocked {
            get {
                return this.BlockedField;
            }
            set {
                if ((this.BlockedField.Equals(value) != true)) {
                    this.BlockedField = value;
                    this.RaisePropertyChanged("Blocked");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateOfBirth {
            get {
                return this.DateOfBirthField;
            }
            set {
                if ((this.DateOfBirthField.Equals(value) != true)) {
                    this.DateOfBirthField = value;
                    this.RaisePropertyChanged("DateOfBirth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> GenderID {
            get {
                return this.GenderIDField;
            }
            set {
                if ((this.GenderIDField.Equals(value) != true)) {
                    this.GenderIDField = value;
                    this.RaisePropertyChanged("GenderID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GenderName {
            get {
                return this.GenderNameField;
            }
            set {
                if ((object.ReferenceEquals(this.GenderNameField, value) != true)) {
                    this.GenderNameField = value;
                    this.RaisePropertyChanged("GenderName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MiddleInitial {
            get {
                return this.MiddleInitialField;
            }
            set {
                if ((object.ReferenceEquals(this.MiddleInitialField, value) != true)) {
                    this.MiddleInitialField = value;
                    this.RaisePropertyChanged("MiddleInitial");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Mobile {
            get {
                return this.MobileField;
            }
            set {
                if ((this.MobileField.Equals(value) != true)) {
                    this.MobileField = value;
                    this.RaisePropertyChanged("Mobile");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NoOfAttempts {
            get {
                return this.NoOfAttemptsField;
            }
            set {
                if ((this.NoOfAttemptsField.Equals(value) != true)) {
                    this.NoOfAttemptsField = value;
                    this.RaisePropertyChanged("NoOfAttempts");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<WebPortal.UserServices.RoleView> Roles {
            get {
                return this.RolesField;
            }
            set {
                if ((object.ReferenceEquals(this.RolesField, value) != true)) {
                    this.RolesField = value;
                    this.RaisePropertyChanged("Roles");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Salt {
            get {
                return this.SaltField;
            }
            set {
                if ((object.ReferenceEquals(this.SaltField, value) != true)) {
                    this.SaltField = value;
                    this.RaisePropertyChanged("Salt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> TownID {
            get {
                return this.TownIDField;
            }
            set {
                if ((this.TownIDField.Equals(value) != true)) {
                    this.TownIDField = value;
                    this.RaisePropertyChanged("TownID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TownName {
            get {
                return this.TownNameField;
            }
            set {
                if ((object.ReferenceEquals(this.TownNameField, value) != true)) {
                    this.TownNameField = value;
                    this.RaisePropertyChanged("TownName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TownView", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceDSABank")]
    [System.SerializableAttribute()]
    public partial class TownView : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserServices.IUserServices")]
    public interface IUserServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/AllocateRole", ReplyAction="http://tempuri.org/IUserServices/AllocateRoleResponse")]
        void AllocateRole(string username, int roleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/AllocateRole", ReplyAction="http://tempuri.org/IUserServices/AllocateRoleResponse")]
        System.Threading.Tasks.Task AllocateRoleAsync(string username, int roleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/Authenticate", ReplyAction="http://tempuri.org/IUserServices/AuthenticateResponse")]
        bool Authenticate(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/Authenticate", ReplyAction="http://tempuri.org/IUserServices/AuthenticateResponse")]
        System.Threading.Tasks.Task<bool> AuthenticateAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/DeallocateRole", ReplyAction="http://tempuri.org/IUserServices/DeallocateRoleResponse")]
        void DeallocateRole(string username, int roleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/DeallocateRole", ReplyAction="http://tempuri.org/IUserServices/DeallocateRoleResponse")]
        System.Threading.Tasks.Task DeallocateRoleAsync(string username, int roleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/Delete", ReplyAction="http://tempuri.org/IUserServices/DeleteResponse")]
        void Delete(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/Delete", ReplyAction="http://tempuri.org/IUserServices/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/DoesUsernameExist", ReplyAction="http://tempuri.org/IUserServices/DoesUsernameExistResponse")]
        bool DoesUsernameExist(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/DoesUsernameExist", ReplyAction="http://tempuri.org/IUserServices/DoesUsernameExistResponse")]
        System.Threading.Tasks.Task<bool> DoesUsernameExistAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/IsUserInRole", ReplyAction="http://tempuri.org/IUserServices/IsUserInRoleResponse")]
        bool IsUserInRole(string username, int roleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/IsUserInRole", ReplyAction="http://tempuri.org/IUserServices/IsUserInRoleResponse")]
        System.Threading.Tasks.Task<bool> IsUserInRoleAsync(string username, int roleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/Genders", ReplyAction="http://tempuri.org/IUserServices/GendersResponse")]
        System.Collections.Generic.List<WebPortal.UserServices.GenderView> Genders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/Genders", ReplyAction="http://tempuri.org/IUserServices/GendersResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WebPortal.UserServices.GenderView>> GendersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/GenerateToken", ReplyAction="http://tempuri.org/IUserServices/GenerateTokenResponse")]
        string GenerateToken();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/GenerateToken", ReplyAction="http://tempuri.org/IUserServices/GenerateTokenResponse")]
        System.Threading.Tasks.Task<string> GenerateTokenAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/GetRoleById", ReplyAction="http://tempuri.org/IUserServices/GetRoleByIdResponse")]
        WebPortal.UserServices.RoleView GetRoleById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/GetRoleById", ReplyAction="http://tempuri.org/IUserServices/GetRoleByIdResponse")]
        System.Threading.Tasks.Task<WebPortal.UserServices.RoleView> GetRoleByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/GetRoleIdByName", ReplyAction="http://tempuri.org/IUserServices/GetRoleIdByNameResponse")]
        int GetRoleIdByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/GetRoleIdByName", ReplyAction="http://tempuri.org/IUserServices/GetRoleIdByNameResponse")]
        System.Threading.Tasks.Task<int> GetRoleIdByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/GetRoles", ReplyAction="http://tempuri.org/IUserServices/GetRolesResponse")]
        System.Collections.Generic.List<WebPortal.UserServices.RoleView> GetRoles(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/GetRoles", ReplyAction="http://tempuri.org/IUserServices/GetRolesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WebPortal.UserServices.RoleView>> GetRolesAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/ListRoles", ReplyAction="http://tempuri.org/IUserServices/ListRolesResponse")]
        System.Collections.Generic.List<WebPortal.UserServices.RoleView> ListRoles();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/ListRoles", ReplyAction="http://tempuri.org/IUserServices/ListRolesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WebPortal.UserServices.RoleView>> ListRolesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/ListUsers", ReplyAction="http://tempuri.org/IUserServices/ListUsersResponse")]
        System.Collections.Generic.List<WebPortal.UserServices.UserView> ListUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/ListUsers", ReplyAction="http://tempuri.org/IUserServices/ListUsersResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WebPortal.UserServices.UserView>> ListUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/ListUsernames", ReplyAction="http://tempuri.org/IUserServices/ListUsernamesResponse")]
        System.Collections.Generic.List<string> ListUsernames();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/ListUsernames", ReplyAction="http://tempuri.org/IUserServices/ListUsernamesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<string>> ListUsernamesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/ReadByUsername", ReplyAction="http://tempuri.org/IUserServices/ReadByUsernameResponse")]
        WebPortal.UserServices.UserView ReadByUsername(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/ReadByUsername", ReplyAction="http://tempuri.org/IUserServices/ReadByUsernameResponse")]
        System.Threading.Tasks.Task<WebPortal.UserServices.UserView> ReadByUsernameAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/Register", ReplyAction="http://tempuri.org/IUserServices/RegisterResponse")]
        bool Register(WebPortal.UserServices.UserView user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/Register", ReplyAction="http://tempuri.org/IUserServices/RegisterResponse")]
        System.Threading.Tasks.Task<bool> RegisterAsync(WebPortal.UserServices.UserView user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/Search", ReplyAction="http://tempuri.org/IUserServices/SearchResponse")]
        System.Collections.Generic.List<WebPortal.UserServices.UserView> Search(string query);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/Search", ReplyAction="http://tempuri.org/IUserServices/SearchResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WebPortal.UserServices.UserView>> SearchAsync(string query);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/Towns", ReplyAction="http://tempuri.org/IUserServices/TownsResponse")]
        System.Collections.Generic.List<WebPortal.UserServices.TownView> Towns();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/Towns", ReplyAction="http://tempuri.org/IUserServices/TownsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WebPortal.UserServices.TownView>> TownsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/Update", ReplyAction="http://tempuri.org/IUserServices/UpdateResponse")]
        void Update(WebPortal.UserServices.UserView user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/Update", ReplyAction="http://tempuri.org/IUserServices/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(WebPortal.UserServices.UserView user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/ValidateToken", ReplyAction="http://tempuri.org/IUserServices/ValidateTokenResponse")]
        bool ValidateToken(string securityToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServices/ValidateToken", ReplyAction="http://tempuri.org/IUserServices/ValidateTokenResponse")]
        System.Threading.Tasks.Task<bool> ValidateTokenAsync(string securityToken);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserServicesChannel : WebPortal.UserServices.IUserServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServicesClient : System.ServiceModel.ClientBase<WebPortal.UserServices.IUserServices>, WebPortal.UserServices.IUserServices {
        
        public UserServicesClient() {
        }
        
        public UserServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AllocateRole(string username, int roleId) {
            base.Channel.AllocateRole(username, roleId);
        }
        
        public System.Threading.Tasks.Task AllocateRoleAsync(string username, int roleId) {
            return base.Channel.AllocateRoleAsync(username, roleId);
        }
        
        public bool Authenticate(string username, string password) {
            return base.Channel.Authenticate(username, password);
        }
        
        public System.Threading.Tasks.Task<bool> AuthenticateAsync(string username, string password) {
            return base.Channel.AuthenticateAsync(username, password);
        }
        
        public void DeallocateRole(string username, int roleId) {
            base.Channel.DeallocateRole(username, roleId);
        }
        
        public System.Threading.Tasks.Task DeallocateRoleAsync(string username, int roleId) {
            return base.Channel.DeallocateRoleAsync(username, roleId);
        }
        
        public void Delete(string username) {
            base.Channel.Delete(username);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(string username) {
            return base.Channel.DeleteAsync(username);
        }
        
        public bool DoesUsernameExist(string username) {
            return base.Channel.DoesUsernameExist(username);
        }
        
        public System.Threading.Tasks.Task<bool> DoesUsernameExistAsync(string username) {
            return base.Channel.DoesUsernameExistAsync(username);
        }
        
        public bool IsUserInRole(string username, int roleId) {
            return base.Channel.IsUserInRole(username, roleId);
        }
        
        public System.Threading.Tasks.Task<bool> IsUserInRoleAsync(string username, int roleId) {
            return base.Channel.IsUserInRoleAsync(username, roleId);
        }
        
        public System.Collections.Generic.List<WebPortal.UserServices.GenderView> Genders() {
            return base.Channel.Genders();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WebPortal.UserServices.GenderView>> GendersAsync() {
            return base.Channel.GendersAsync();
        }
        
        public string GenerateToken() {
            return base.Channel.GenerateToken();
        }
        
        public System.Threading.Tasks.Task<string> GenerateTokenAsync() {
            return base.Channel.GenerateTokenAsync();
        }
        
        public WebPortal.UserServices.RoleView GetRoleById(int id) {
            return base.Channel.GetRoleById(id);
        }
        
        public System.Threading.Tasks.Task<WebPortal.UserServices.RoleView> GetRoleByIdAsync(int id) {
            return base.Channel.GetRoleByIdAsync(id);
        }
        
        public int GetRoleIdByName(string name) {
            return base.Channel.GetRoleIdByName(name);
        }
        
        public System.Threading.Tasks.Task<int> GetRoleIdByNameAsync(string name) {
            return base.Channel.GetRoleIdByNameAsync(name);
        }
        
        public System.Collections.Generic.List<WebPortal.UserServices.RoleView> GetRoles(string username) {
            return base.Channel.GetRoles(username);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WebPortal.UserServices.RoleView>> GetRolesAsync(string username) {
            return base.Channel.GetRolesAsync(username);
        }
        
        public System.Collections.Generic.List<WebPortal.UserServices.RoleView> ListRoles() {
            return base.Channel.ListRoles();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WebPortal.UserServices.RoleView>> ListRolesAsync() {
            return base.Channel.ListRolesAsync();
        }
        
        public System.Collections.Generic.List<WebPortal.UserServices.UserView> ListUsers() {
            return base.Channel.ListUsers();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WebPortal.UserServices.UserView>> ListUsersAsync() {
            return base.Channel.ListUsersAsync();
        }
        
        public System.Collections.Generic.List<string> ListUsernames() {
            return base.Channel.ListUsernames();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<string>> ListUsernamesAsync() {
            return base.Channel.ListUsernamesAsync();
        }
        
        public WebPortal.UserServices.UserView ReadByUsername(string username) {
            return base.Channel.ReadByUsername(username);
        }
        
        public System.Threading.Tasks.Task<WebPortal.UserServices.UserView> ReadByUsernameAsync(string username) {
            return base.Channel.ReadByUsernameAsync(username);
        }
        
        public bool Register(WebPortal.UserServices.UserView user) {
            return base.Channel.Register(user);
        }
        
        public System.Threading.Tasks.Task<bool> RegisterAsync(WebPortal.UserServices.UserView user) {
            return base.Channel.RegisterAsync(user);
        }
        
        public System.Collections.Generic.List<WebPortal.UserServices.UserView> Search(string query) {
            return base.Channel.Search(query);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WebPortal.UserServices.UserView>> SearchAsync(string query) {
            return base.Channel.SearchAsync(query);
        }
        
        public System.Collections.Generic.List<WebPortal.UserServices.TownView> Towns() {
            return base.Channel.Towns();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WebPortal.UserServices.TownView>> TownsAsync() {
            return base.Channel.TownsAsync();
        }
        
        public void Update(WebPortal.UserServices.UserView user) {
            base.Channel.Update(user);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(WebPortal.UserServices.UserView user) {
            return base.Channel.UpdateAsync(user);
        }
        
        public bool ValidateToken(string securityToken) {
            return base.Channel.ValidateToken(securityToken);
        }
        
        public System.Threading.Tasks.Task<bool> ValidateTokenAsync(string securityToken) {
            return base.Channel.ValidateTokenAsync(securityToken);
        }
    }
}
