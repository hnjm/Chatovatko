# Chatovatko
A chatting C# application with end-to-end encryption.
The application is now under development. The works on front end hasn't started yet.

Chatovatko is currently tested under Ubuntu 18.04 and Windows 10.

## Important technical details
* **.NET Core 2.1** used for server-side service and for command-based console application (for testing porpuse)
* **.NET Standart 2.0** used for multiplatform client libraries and server-client shared libraries
* **Tls 1.2** is used for encrypting communication between server and client and for server verification
* **RSA** with key size **4096** is used for client verification and sending AES keys
* **AES256** used for encrypting messages
* **MySql** is required as server-side database.
* Sqlite3 is used as client side database
* Project is developed using **Visual Studio 2017** and **MySql Workbench 8.0**
* Also, project also benefits from Entity Framework Core, Newtonsoft.Json and Pomelo.EntityFrameworkCore.MySql
* SHA256 and SHA1 used for hashing
* Only little endian is supported

## Getting started
There is no offical release currently, but you can download git repository and compile.
To clone repository, enter to your console:
    
    git clone https://github.com/stastnypremysl/Chatovatko/
    
For deep technical details, please, visit wiki.

### Installation of server
Install MySql14 and run script [`Chatovatko/sql/serverBuildScripts/build.sql`](https://github.com/stastnypremysl/Chatovatko/blob/master/sql/serverBuildScripts/build.sql). It is necessary to have `.NET Core 2.1` installed. This [manual](https://www.microsoft.com/net/learn/get-started-with-dotnet-tutorial#install) seems to be useful.

You will need **p12 certificate**. You can run this script to generate it: [`Chatovatko/scripts/genarateCert.sh`](https://github.com/stastnypremysl/Chatovatko/blob/master/scripts/genarateCert.sh).

Than make a config file. Here is an example for inspiration:

    ConnectionString=Server=localhost; database=chatovatko;UID=MyUserName;password=SuperSecretPassword
    CertAddress=/mnt/c/keys/private.p12
    ServerName=Super server name

When is everything ready, run server with this command

    cd /pathToRepository/Chatovatko/Premy.Chatovatko/Premy.Chatovatko.Server
    dotnet run -c Release -- /otherPath/configFile.txt
    
### Console client
#### Installation
As it was in server installation, install [`.NET Core 2.1`](https://www.microsoft.com/net/learn/get-started-with-dotnet-tutorial#install) if you haven't done it already. There are no more prerequsities. Just run

    cd /pathToRepository/Chatovatko/Premy.Chatovatko/Premy.Chatovatko.Client.Console
    dotnet run -c Release

#### First run
