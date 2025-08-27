namespace Newtonsoft.Json.UnityConverters.Physics;

public class JointLimitsConverter : PartialConverter<JointLimits>
{

	public JointLimitsConverter() { }

	protected virtual void ReadValue(ref JointLimits value, string name, JsonReader reader, JsonSerializer serializer) { }

	protected virtual void WriteJsonProperties(JsonWriter writer, JointLimits value, JsonSerializer serializer) { }

}

