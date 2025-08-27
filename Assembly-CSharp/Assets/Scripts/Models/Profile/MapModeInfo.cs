namespace Assets.Scripts.Models.Profile;

public class MapModeInfo
{
	internal class CustomJsonConverter : JsonConverter
	{

		public CustomJsonConverter() { }

		public virtual bool CanConvert(Type t) { }

		public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

		public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	}

	public bool seen; //Field offset: 0x10
	public bool seenCompleted; //Field offset: 0x11
	public bool seenMedal; //Field offset: 0x12
	public int bestRound; //Field offset: 0x14
	public int timesCompleted; //Field offset: 0x18
	[Obsolete("Not used anymore. Must remain to support old save data structures.")]
	public int dailyChallengeTimesCompleted; //Field offset: 0x1C
	public bool completedWithoutLoadingSave; //Field offset: 0x20

	public MapModeInfo() { }

	private static MapModeInfo FromInt64(long value) { }

	public int GetTotalTimesCompleted() { }

	public static bool IsDefault(MapModeInfo info) { }

	private static long ToInt64(MapModeInfo info) { }

}

