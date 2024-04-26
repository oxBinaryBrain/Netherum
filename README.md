# Nethereum Blockchain Application

This project demonstrates a basic blockchain application developed using Nethereum, a .NET integration library for Ethereum. The application connects to an Ethereum network, deploys a simple smart contract, and interacts with it.

## Getting Started

Follow these instructions to get a copy of the project up and running on your local machine.

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) installed on your machine
- Infura API key (for connecting to an Ethereum network)
- Ethereum account private key
### Installing

1. Clone the repository to your local machine:

   ```bash
   git clone https://github.com/oxBinaryBrain/Netherum.git
   ```
2. Navigate to the project directory:
   ```bash
   cd nethereum-blockchain-application
   ```
3. Restore project dependencies:
   ```bash
   dotnet restore
   ```
4. Update the Program.cs file with your Infura API key and Ethereum account private key.

 
### Usage

Upon running the application, it will connect to the specified Ethereum network (e.g., Ropsten) using your Infura API key and deploy a simple smart contract. The contract stores and retrieves a single integer value. The application will interact with the contract by setting and getting the value.

### Contributing
Contributions are welcome! If you find any issues or have suggestions for improvements, please open an issue or submit a pull request.

### License
This project is licensed under the MIT License - see the LICENSE file for details.

### Acknowledgments
Nethereum - for providing the .NET integration library for Ethereum
Infura - for providing the Ethereum infrastructure and APIs

]
