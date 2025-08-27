namespace Newtonsoft.Json.UnityConverters.Physics2D;

public class ContactFilter2DConverter : PartialConverter<ContactFilter2D>
{

	public ContactFilter2DConverter() { }

	protected virtual void ReadValue(ref ContactFilter2D value, string name, JsonReader reader, JsonSerializer serializer) { }

	protected virtual void WriteJsonProperties(JsonWriter writer, ContactFilter2D value, JsonSerializer serializer) { }

}

