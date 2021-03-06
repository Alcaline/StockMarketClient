﻿using Newtonsoft.Json;
using StockMarketClient.Models.Util;

namespace StockMarketClient.Models
{
    /// <summary>
    /// Objeto representa uma ordem de operação sobre ações no mercado de ações
    /// </summary>
    [JsonConverter(typeof(StockOrderConverter))]
    public abstract class StockOrder
    {
        private long _version = 0;
        private long? _id = null;
        private Stockholder _orderPlacer = null;
        private Stocks _stocks;

        [JsonProperty(PropertyName = "version")]
        public long Version { get => _version; private set => _version = value; }

        [JsonProperty(PropertyName = "id")]
        public long? Id {
            get => _id;
            set
            {
                _id = value;
                Version++;
            }
        }

        [JsonProperty(PropertyName = "orderPlacer")]
        public Stockholder OrderPlacer
        {
            get => _orderPlacer;
            set
            {
                _orderPlacer = value;
                Version++;
            }
        }

        [JsonProperty(PropertyName = "stocks")]
        public Stocks Stocks
        {
            get => _stocks;
            set
            {
                _stocks = value;
                Version++;
            }
        }

        [JsonProperty(PropertyName = "buying")]
        public virtual bool IsBuying { get; }

        [JsonProperty(PropertyName = "selling")]
        public virtual bool IsSelling { get; }
    }
}
