﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Consul;

namespace Zhaoxi.AgilityFramework.ConsulClientExtend
{
    public class PollingDispatcher : IConsulDispatcher
    {
        private static int _iTotalCount = 0;
        private static int iTotalCount
        {
            get
            {
                return _iTotalCount;
            }
            set
            {
                _iTotalCount = value >= Int32.MaxValue ? 0 : value;
            }
        }
        public string ChooseAddress(string serviceName)
        {
            ConsulClient client = new ConsulClient(c =>//TODO:根据集群找可用Consul Agent地址
            {
                c.Address = new Uri("http://localhost:8500/");
                c.Datacenter = "dc1";
            });
            var response = client.Agent.Services().Result.Response;
            foreach (var item in response)
            {
                Console.WriteLine("***************************************");
                Console.WriteLine(item.Key);
                var service = item.Value;
                Console.WriteLine($"{service.Address}--{service.Port}--{service.Service}");
                Console.WriteLine("***************************************");
            }

            AgentService agentService = null;
            var serviceDictionary = response.Where(s => s.Value.Service.Equals(serviceName, StringComparison.OrdinalIgnoreCase)).ToArray();
            {
                int index = iTotalCount++ % serviceDictionary.Length;
                agentService = serviceDictionary[index].Value;
                //轮询
            }

            return $"{agentService.Address}:{agentService.Port}";
        }
    }
}
