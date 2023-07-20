using System;
using System.Text.Json;
using Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

var user = new AppUser
{
    FullName = "Samandar Xamroqulov",
    EmailAdrress = null,
    Password = "1234655",
    PhoneNumber = "998777878"
};


//var bytes = JsonSerializer.SerializeToUtf8Bytes(user);

//foreach (var by in bytes)
//{
//    Console.WriteLine(by);
//}

//var options = new JsonSerializerOptions
//{
//    WriteIndented = true
//};

//var str = JsonSerializer.Serialize(user, options);

//Console.WriteLine(str);

//var jsonString = @"
//{
//    ""Name"": ""Charles"",
//    ""Phone"": ""+998998773074"",
//    ""Email"": ""MyEmail"",
//    ""Parol"" : ""1234""
//}";

//// ========================================= Deserialize ====================================//
//var copyObject = JsonSerializer.Deserialize<AppUser>(jsonString) 
//                 ?? throw new ArgumentNullException();
//Console.WriteLine(copyObject.ToString());


// =============== Using NewtonSoft Json ====================================================//


//var jsonObject = JsonConvert.SerializeObject(user,Formatting.Indented)
//    ?? throw new ArgumentNullException();

//Console.WriteLine(jsonObject);

//var  person = JsonConvert.DeserializeObject<AppUser>(jsonObject) ??
//              throw new ArgumentNullException();

//Console.WriteLine(person);

// ========================= == = = = Parsing to Json Object ====================== ===//

var jsonString = @"
{
    ""Name"": ""Charles"",
    ""Phone"": ""+998998773074"",
    ""Email"": ""MyEmail"",
    ""Parol"" : ""1234""
}";

JObject jObject = JObject.Parse(jsonString);

string? name = (string?)jObject["Name"];
string? phone = (string?)jObject["Phone"];
string? email = (string?)jObject["Email"];
string? parol = (string?)jObject["Phone"];


Console.WriteLine($"Name: {name}");
Console.WriteLine($"Phone: {phone}");
Console.WriteLine($"Email: {email}");
Console.WriteLine($"Parol: {parol}");
