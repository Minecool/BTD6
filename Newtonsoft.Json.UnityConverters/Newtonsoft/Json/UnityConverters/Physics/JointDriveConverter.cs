namespace Newtonsoft.Json.UnityConverters.Physics;

public class JointDriveConverter : PartialConverter<JointDrive>
{

	public JointDriveConverter() { }

	protected virtual void ReadValue(ref JointDrive value, string name, JsonReader reader, JsonSerializer serializer) { }

	protected virtual void WriteJsonProperties(JsonWriter writer, JointDrive value, JsonSerializer serializer) { }

}

