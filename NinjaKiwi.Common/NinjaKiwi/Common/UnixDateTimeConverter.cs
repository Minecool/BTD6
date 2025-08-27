namespace NinjaKiwi.Common;

public class UnixDateTimeConverter : DateTimeConverterBase
{

	private DateTime EpochDate
	{
		private get { } //Length: 78
	}

	public UnixDateTimeConverter() { }

	private DateTime get_EpochDate() { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

