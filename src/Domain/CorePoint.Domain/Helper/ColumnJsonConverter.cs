using System.Text.Json;
using System.Text.Json.Serialization;
using CorePoint.Domain.Entities;

namespace CorePoint.Domain.Helper;

public class ColumnJsonConverter : JsonConverter<Column>
{
    public override Column? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var jsonDoc = JsonDocument.ParseValue(ref reader);
        var root = jsonDoc.RootElement;

        // Lấy giá trị của trường "Type"
        var type = root.GetProperty("Type").GetString();

        // Deserialize vào đối tượng phù hợp
        return type switch
        {
            nameof(DateTimeColumn) => JsonSerializer.Deserialize<DateTimeColumn>(root.GetRawText(), options),
            nameof(NumberColumn) => JsonSerializer.Deserialize<NumberColumn>(root.GetRawText(), options),
            _ => JsonSerializer.Deserialize<Column>(root.GetRawText(), options)
        };
    }

    public override void Write(Utf8JsonWriter writer, Column value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, (object)value, options);
    }
}
