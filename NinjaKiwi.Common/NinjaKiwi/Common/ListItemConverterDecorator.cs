namespace NinjaKiwi.Common;

public class ListItemConverterDecorator : JsonConverter
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Type, Boolean> <>9__2_0; //Field offset: 0x8
		public static Func<Type, Boolean> <>9__7_0; //Field offset: 0x10
		public static Func<Type, Type> <>9__7_1; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <CanConvert>b__2_0(Type t) { }

		internal bool <ReadJson>b__7_0(Type t) { }

		internal Type <ReadJson>b__7_1(Type t) { }

	}

	private readonly JsonConverter itemConverter; //Field offset: 0x10

	public virtual bool CanRead
	{
		 get { } //Length: 42
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 42
	}

	public ListItemConverterDecorator(Type type) { }

	public virtual bool CanConvert(Type objectType) { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanWrite() { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

