namespace Assets.Scripts;

public struct ObjectId : IEquatable<ObjectId>, IComparable<ObjectId>
{
	internal class ObjectIdConverter : JsonConverter
	{

		public ObjectIdConverter() { }

		public virtual bool CanConvert(Type t) { }

		public virtual object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer) { }

		public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	}

	private const int kIdBits = 24; //Field offset: 0x0
	private const uint kkIdMask = 16777215; //Field offset: 0x0
	private const uint kVersionMask = 4278190080; //Field offset: 0x0
	private const uint kInvalidData = 4294967295; //Field offset: 0x0
	private uint data; //Field offset: 0x0

	public int Id
	{
		 get { } //Length: 19
	}

	public static ObjectId Invalid
	{
		 get { } //Length: 6
	}

	public bool IsValid
	{
		 get { } //Length: 7
	}

	public uint Raw
	{
		 get { } //Length: 3
	}

	public int Version
	{
		 get { } //Length: 15
	}

	public ObjectId Add(uint add) { }

	public override int CompareTo(ObjectId other) { }

	public static ObjectId Create(uint id, byte version = 0) { }

	public override bool Equals(ObjectId other) { }

	public virtual bool Equals(object obj) { }

	public static ObjectId FromData(uint id) { }

	public static ObjectId FromString(string id) { }

	public int get_Id() { }

	public static ObjectId get_Invalid() { }

	public bool get_IsValid() { }

	public uint get_Raw() { }

	public int get_Version() { }

	public virtual int GetHashCode() { }

	public ObjectId IncrementVersion() { }

	public static bool op_Equality(ObjectId l, ObjectId r) { }

	public static bool op_GreaterThan(ObjectId l, ObjectId r) { }

	public static bool op_Inequality(ObjectId l, ObjectId r) { }

	public static bool op_LessThan(ObjectId l, ObjectId r) { }

	public virtual string ToString() { }

}

