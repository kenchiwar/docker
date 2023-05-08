

using System.Text.Json;
using System.Text.Json.Serialization;

namespace DemoSession1_WebAPI.Converters;

public class DateConverter : JsonConverter<DateTime>
{
    private string formatText = "dd/MM/yyyy";
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString(formatText)) ;
    }
}