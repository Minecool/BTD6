namespace Newtonsoft.Json.UnityConverters.Physics;

public class SoftJointLimitConverter : PartialConverter<SoftJointLimit>
{

	public SoftJointLimitConverter() { }

	protected virtual void ReadValue(ref SoftJointLimit value, string name, JsonReader reader, JsonSerializer serializer) { }

	protected virtual void WriteJsonProperties(JsonWriter writer, SoftJointLimit value, JsonSerializer serializer) { }

}

