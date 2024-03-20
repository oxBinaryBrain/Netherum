using System;
using System.Numerics;
using System.Threading.Tasks;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using Nethereum.Contracts;

class Program
{
    static async Task Main(string[] args)
    {
        // Connect to an Ethereum network
        var web3 = new Web3("https://ropsten.infura.io/v3/your-infura-api-key");