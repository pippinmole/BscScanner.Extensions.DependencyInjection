# BscScanner.Extensions.DependencyInjection
 BscScanner extensions for Microsoft.Extensions.DependencyInjection 

[![NuGet version (BscScanner)](https://img.shields.io/github/license/pippinmole/BscScanner.Extensions.DependencyInjection?style=for-the-badge)](https://www.nuget.org/packages/BscScanner.Extensions.DependencyInjection)
[![NuGet downloads](https://img.shields.io/nuget/dt/BscScanner.Extensions.DependencyInjection?style=for-the-badge)](https://www.nuget.org/packages/BscScanner.Extensions.DependencyInjection)
[![Code size](https://img.shields.io/github/languages/code-size/pippinmole/BscScanner.Extensions.DependencyInjection?style=for-the-badge)](https://github.com/pippinmole/BscScanner.Extensions.DependencyInjection)

## How to use

1. Install the [Nuget](https://www.nuget.org/packages/BscScanner) package
    ```cli
    Install-Package BscScanner.Extensions.DependencyInjection
    ```
2. Set up the service
    ```cs
    services.AddBscScanner(opt => {
        opt.ApiKey = "api key here";
    });
    ```
3. Inject the service into your classes (ASP.NET Core API example)
   ```cs
   [ApiController]
   [Route("[controller]")]
   public class BscScannerController : ControllerBase {

        private readonly IBscScanClient _bscScanClient;

        public BscScannerController(IBscScanClient bscScanClient) {
            _bscScanClient = bscScanClient;
        }

        [HttpGet]
        public async Task<float> GetBalanceFor(string address) {
            var result = await _bscScanClient.GetBnbBalanceSingleAsync(address);

            return result;
        }
   }
   ```
   
For more information, please see the [example folder](https://github.com/pippinmole/BscScanner.Extensions.DependencyInjection/tree/main/BscScanner.Extensions.DependencyInjection).

## How to contribute

You can contribute by pulling the code, making some changes and then opening a pull request. The changes will be revised and merged into main if it is a valid feature/bug fix.

1. Pull the latest main branch
2. Nuget restore to get dependencies
3. Make some changes
4. Create a pull request with a detailed explanation on why the changes were made

You can also donate BNB or Ether in order for me to maintain the project to this address: 0x59784ccC71205eF6A292F973e44f46CdC1f58306
