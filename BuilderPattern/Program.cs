using BuilderPattern.Method1;
using System.Text;

var sb = new StringBuilder();
sb.Append("Cemal");
sb.Append("ordu");
var fullname=sb.ToString();
var eb = new EndpointBuilder("https://localhost");
eb.Append("api").Append("v1").Append("user").AppendParam("id", "5");
var url = eb.Build();
System.Console.WriteLine(url);