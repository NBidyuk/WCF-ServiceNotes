﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Note", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary1")]
    [System.SerializableAttribute()]
    public partial class Note : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text {
            get {
                return this.TextField;
            }
            set {
                if ((object.ReferenceEquals(this.TextField, value) != true)) {
                    this.TextField = value;
                    this.RaisePropertyChanged("Text");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Replace", ReplyAction="http://tempuri.org/IService1/ReplaceResponse")]
        void Replace(Client.ServiceReference1.Note note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Replace", ReplyAction="http://tempuri.org/IService1/ReplaceResponse")]
        System.Threading.Tasks.Task ReplaceAsync(Client.ServiceReference1.Note note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ShowByDate", ReplyAction="http://tempuri.org/IService1/ShowByDateResponse")]
        Client.ServiceReference1.Note[] ShowByDate(System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ShowByDate", ReplyAction="http://tempuri.org/IService1/ShowByDateResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.Note[]> ShowByDateAsync(System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ShowAll", ReplyAction="http://tempuri.org/IService1/ShowAllResponse")]
        Client.ServiceReference1.Note[] ShowAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ShowAll", ReplyAction="http://tempuri.org/IService1/ShowAllResponse")]
        System.Threading.Tasks.Task<Client.ServiceReference1.Note[]> ShowAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddNote", ReplyAction="http://tempuri.org/IService1/AddNoteResponse")]
        void AddNote(Client.ServiceReference1.Note note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddNote", ReplyAction="http://tempuri.org/IService1/AddNoteResponse")]
        System.Threading.Tasks.Task AddNoteAsync(Client.ServiceReference1.Note note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ListSerialize", ReplyAction="http://tempuri.org/IService1/ListSerializeResponse")]
        void ListSerialize(Client.ServiceReference1.Note[] noteList);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ListSerialize", ReplyAction="http://tempuri.org/IService1/ListSerializeResponse")]
        System.Threading.Tasks.Task ListSerializeAsync(Client.ServiceReference1.Note[] noteList);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ListDeSerialize", ReplyAction="http://tempuri.org/IService1/ListDeSerializeResponse")]
        void ListDeSerialize(Client.ServiceReference1.Note[] noteList);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ListDeSerialize", ReplyAction="http://tempuri.org/IService1/ListDeSerializeResponse")]
        System.Threading.Tasks.Task ListDeSerializeAsync(Client.ServiceReference1.Note[] noteList);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Client.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Client.ServiceReference1.IService1>, Client.ServiceReference1.IService1 {
        
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
        
        public void Replace(Client.ServiceReference1.Note note) {
            base.Channel.Replace(note);
        }
        
        public System.Threading.Tasks.Task ReplaceAsync(Client.ServiceReference1.Note note) {
            return base.Channel.ReplaceAsync(note);
        }
        
        public Client.ServiceReference1.Note[] ShowByDate(System.DateTime date) {
            return base.Channel.ShowByDate(date);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.Note[]> ShowByDateAsync(System.DateTime date) {
            return base.Channel.ShowByDateAsync(date);
        }
        
        public Client.ServiceReference1.Note[] ShowAll() {
            return base.Channel.ShowAll();
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference1.Note[]> ShowAllAsync() {
            return base.Channel.ShowAllAsync();
        }
        
        public void AddNote(Client.ServiceReference1.Note note) {
            base.Channel.AddNote(note);
        }
        
        public System.Threading.Tasks.Task AddNoteAsync(Client.ServiceReference1.Note note) {
            return base.Channel.AddNoteAsync(note);
        }
        
        public void ListSerialize(Client.ServiceReference1.Note[] noteList) {
            base.Channel.ListSerialize(noteList);
        }
        
        public System.Threading.Tasks.Task ListSerializeAsync(Client.ServiceReference1.Note[] noteList) {
            return base.Channel.ListSerializeAsync(noteList);
        }
        
        public void ListDeSerialize(Client.ServiceReference1.Note[] noteList) {
            base.Channel.ListDeSerialize(noteList);
        }
        
        public System.Threading.Tasks.Task ListDeSerializeAsync(Client.ServiceReference1.Note[] noteList) {
            return base.Channel.ListDeSerializeAsync(noteList);
        }
    }
}
