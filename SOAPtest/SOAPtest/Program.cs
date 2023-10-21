
using ServiceReference1;

CalculatorSoapClient client = new CalculatorSoapClient(CalculatorSoapClient.EndpointConfiguration.CalculatorSoap);

var Item = await client.AddAsync(10, 20);
Console.WriteLine(Item);