namespace Assets.Scripts.Models.Bloons;

public abstract class BloonBehaviorModel : Model
{
	internal class CustomJsonConverter : JsonConverter
	{

		public virtual bool CanWrite
		{
			 get { } //Length: 3
		}

		public CustomJsonConverter`1() { }

		public virtual bool CanConvert(Type objectType) { }

		public virtual bool get_CanWrite() { }

		public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

		public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	}


	protected BloonBehaviorModel() { }

	protected BloonBehaviorModel(string name) { }

}

