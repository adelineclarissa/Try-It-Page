﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TryIt_AdelineTrisnobuwono.WordCountService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WordCountService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/WordCount", ReplyAction="http://tempuri.org/IService1/WordCountResponse")]
        string WordCount(string filename);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/WordCount", ReplyAction="http://tempuri.org/IService1/WordCountResponse")]
        System.Threading.Tasks.Task<string> WordCountAsync(string filename);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : TryIt_AdelineTrisnobuwono.WordCountService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<TryIt_AdelineTrisnobuwono.WordCountService.IService1>, TryIt_AdelineTrisnobuwono.WordCountService.IService1 {
        
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
        
        public string WordCount(string filename) {
            return base.Channel.WordCount(filename);
        }
        
        public System.Threading.Tasks.Task<string> WordCountAsync(string filename) {
            return base.Channel.WordCountAsync(filename);
        }
    }
}