//#reset
#r "C:\Users\danie\Documents\Jeti\Jeti_Studies\packages\EntityFramework.6.1.3\lib\net40\EntityFramework.dll"
#r "C:\Users\danie\Documents\Jeti\Jeti_Studies\packages\EntityFramework.6.1.3\lib\net40\EntityFramework.SqlServer.dll"
#r "C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\Profile\Client\System.dll"
#r "C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\Profile\Client\System.ComponentModel.DataAnnotations.dll"
#r "C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\Profile\Client\System.Core.dll"
#r "C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\Profile\Client\System.Data.Entity.dll"
#r "C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\Profile\Client\System.Runtime.Serialization.dll"
#r "C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\Profile\Client\System.Security.dll"
#r "C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\Profile\Client\System.Xml.Linq.dll"
#r "C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\Profile\Client\System.Data.DataSetExtensions.dll"
#r "C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\Profile\Client\Microsoft.CSharp.dll"
#r "C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\Profile\Client\System.Data.dll"
#r "C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\Profile\Client\System.Xml.dll"
#r "C:\Users\danie\Documents\Jeti\Jeti_Studies\csharpclient\bin\Debug\TWSLib.dll"
#r "Jeti_v0.exe"
using Jeti_v0;
var d = new db();
var c = db.GetActiveContracts();
Console.WriteLine(c[0].IBFuturesLocalSymbol);