using System.Text.Json.Serialization;

namespace Json;

public class AppUser
{
    [JsonPropertyName("Name")]
    public string? FullName { get; set; }

    [JsonPropertyName("Email")]
    public string? EmailAdrress { get; set; }

    [JsonPropertyName("Phone")]
    public required string PhoneNumber { get; set; }
    [JsonPropertyName("Parol")]
    public required string Password { get; set; }

    public override string ToString()
        => $" FullName : {FullName}\n Email : {EmailAdrress}" +
           $"\n Phone : {PhoneNumber}\n PassWord : {Password}";

}