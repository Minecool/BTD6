namespace Assets.Scripts.Simulation;

[Extension]
public static class SerializationUtils
{

	[Extension]
	public static bool DeserializeBool(string s, bool default = false) { }

	[Extension]
	public static T DeserializeEnum(string s) { }

	[Extension]
	public static float DeserializeFloat(string s, float default = 0) { }

	[Extension]
	public static int DeserializeInt(string s, int default = 0) { }

	[Extension]
	public static ObjectId DeserializeObjectId(string s) { }

	[Extension]
	public static string Serialize(T e) { }

	[Extension]
	public static string Serialize(float f) { }

	[Extension]
	public static string Serialize(int i) { }

	[Extension]
	public static string Serialize(bool b) { }

	[Extension]
	public static string Serialize(ObjectId o) { }

}

