namespace Assets.Scripts.Data.Knowledge;

public class ActiveRelicKnowledgeConverter : JsonConverter
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<ContestedTerritoryRelicType, UInt16>, String> <>9__3_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <WriteJson>b__3_0(KeyValuePair<ContestedTerritoryRelicType, UInt16> kvp) { }

	}

	private const char kCountDelimeter = '\u3A'; //Field offset: 0x0

	public ActiveRelicKnowledgeConverter() { }

	public virtual bool CanConvert(Type t) { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

