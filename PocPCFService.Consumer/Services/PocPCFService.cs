using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;

namespace PocPCFService.Consumer.Services
{
    public class PocPCFService : ClientBase<IPocPCFService>, IPocPCFService
    {
        public PocPCFService(string endpointConfigurationName) : base(endpointConfigurationName)
        {
        }

        public PocPCFService(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
        {
        }

        public PocPCFService(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
        {
        }

        public PocPCFService(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
        {
        }

        public string GetData(int value)
        {
            return base.Channel.GetData(value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            return base.Channel.GetDataUsingDataContract(composite);
        }
    }
}