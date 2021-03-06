﻿using Newtonsoft.Json;
using System;

namespace StockMarketClient.Models
{
    /// <summary>
    /// Objeto representa um acionista no mercado de ações
    /// </summary>
    public class Stockholder
    {
        private long _version = 0;
        private string _name = "";
        private Guid _id = Guid.NewGuid();

        public Stockholder() { }

        public Stockholder(string name) => Name = name;

        [JsonProperty(PropertyName = "version")]
        public long Version { get => _version; private set => _version = value; }

        [JsonProperty(PropertyName = "id")]
        public Guid Id { get => _id; private set => _id = value; }

        [JsonProperty(PropertyName = "name")]
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                Version++;
            }
        }
    }
}
