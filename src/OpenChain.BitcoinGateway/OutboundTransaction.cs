﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenChain.BitcoinGateway
{
    public class OutboundTransaction
    {
        public OutboundTransaction(string account, string asset, long amount, ByteString mutationHash)
        {
            this.Account = account;
            this.Asset = asset; 
            this.Amount = amount;
            this.MutationHash = mutationHash;
        }

        public string Account { get; }

        public ByteString MutationHash { get; }

        public string Asset { get; }

        public long Amount { get; }
    }
}