﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfService2.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfService2")]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/WcfService2.Models")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartmentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SalaryField;
        
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
        public string Department {
            get {
                return this.DepartmentField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartmentField, value) != true)) {
                    this.DepartmentField = value;
                    this.RaisePropertyChanged("Department");
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
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Salary {
            get {
                return this.SalaryField;
            }
            set {
                if ((this.SalaryField.Equals(value) != true)) {
                    this.SalaryField = value;
                    this.RaisePropertyChanged("Salary");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        WcfService2.ServiceReference1.CompositeType GetDataUsingDataContract(WcfService2.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WcfService2.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(WcfService2.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddEmployyeeRecord", ReplyAction="http://tempuri.org/IService1/AddEmployyeeRecordResponse")]
        string AddEmployyeeRecord(WcfService2.ServiceReference1.Employee emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddEmployyeeRecord", ReplyAction="http://tempuri.org/IService1/AddEmployyeeRecordResponse")]
        System.Threading.Tasks.Task<string> AddEmployyeeRecordAsync(WcfService2.ServiceReference1.Employee emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmployeeRecords", ReplyAction="http://tempuri.org/IService1/GetEmployeeRecordsResponse")]
        WcfService2.ServiceReference1.Employee[] GetEmployeeRecords();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmployeeRecords", ReplyAction="http://tempuri.org/IService1/GetEmployeeRecordsResponse")]
        System.Threading.Tasks.Task<WcfService2.ServiceReference1.Employee[]> GetEmployeeRecordsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteRecords", ReplyAction="http://tempuri.org/IService1/DeleteRecordsResponse")]
        string DeleteRecords(System.Nullable<int> Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteRecords", ReplyAction="http://tempuri.org/IService1/DeleteRecordsResponse")]
        System.Threading.Tasks.Task<string> DeleteRecordsAsync(System.Nullable<int> Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchEmployeeRecord", ReplyAction="http://tempuri.org/IService1/SearchEmployeeRecordResponse")]
        WcfService2.ServiceReference1.Employee SearchEmployeeRecord(System.Nullable<int> Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchEmployeeRecord", ReplyAction="http://tempuri.org/IService1/SearchEmployeeRecordResponse")]
        System.Threading.Tasks.Task<WcfService2.ServiceReference1.Employee> SearchEmployeeRecordAsync(System.Nullable<int> Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateEmployeeContact", ReplyAction="http://tempuri.org/IService1/UpdateEmployeeContactResponse")]
        string UpdateEmployeeContact(WcfService2.ServiceReference1.Employee emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateEmployeeContact", ReplyAction="http://tempuri.org/IService1/UpdateEmployeeContactResponse")]
        System.Threading.Tasks.Task<string> UpdateEmployeeContactAsync(WcfService2.ServiceReference1.Employee emp);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WcfService2.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WcfService2.ServiceReference1.IService1>, WcfService2.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public WcfService2.ServiceReference1.CompositeType GetDataUsingDataContract(WcfService2.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WcfService2.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(WcfService2.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public string AddEmployyeeRecord(WcfService2.ServiceReference1.Employee emp) {
            return base.Channel.AddEmployyeeRecord(emp);
        }
        
        public System.Threading.Tasks.Task<string> AddEmployyeeRecordAsync(WcfService2.ServiceReference1.Employee emp) {
            return base.Channel.AddEmployyeeRecordAsync(emp);
        }
        
        public WcfService2.ServiceReference1.Employee[] GetEmployeeRecords() {
            return base.Channel.GetEmployeeRecords();
        }
        
        public System.Threading.Tasks.Task<WcfService2.ServiceReference1.Employee[]> GetEmployeeRecordsAsync() {
            return base.Channel.GetEmployeeRecordsAsync();
        }
        
        public string DeleteRecords(System.Nullable<int> Id) {
            return base.Channel.DeleteRecords(Id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteRecordsAsync(System.Nullable<int> Id) {
            return base.Channel.DeleteRecordsAsync(Id);
        }
        
        public WcfService2.ServiceReference1.Employee SearchEmployeeRecord(System.Nullable<int> Id) {
            return base.Channel.SearchEmployeeRecord(Id);
        }
        
        public System.Threading.Tasks.Task<WcfService2.ServiceReference1.Employee> SearchEmployeeRecordAsync(System.Nullable<int> Id) {
            return base.Channel.SearchEmployeeRecordAsync(Id);
        }
        
        public string UpdateEmployeeContact(WcfService2.ServiceReference1.Employee emp) {
            return base.Channel.UpdateEmployeeContact(emp);
        }
        
        public System.Threading.Tasks.Task<string> UpdateEmployeeContactAsync(WcfService2.ServiceReference1.Employee emp) {
            return base.Channel.UpdateEmployeeContactAsync(emp);
        }
    }
}
