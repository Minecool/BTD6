namespace NinjaKiwi.Common;

public class StorageManagerJsonSerialiser : IStorageManagerSerialiser
{
	private readonly JsonSerializerSettings settings; //Field offset: 0x10

	public StorageManagerJsonSerialiser(JsonSerializerSettings settings = null) { }

	public override T Deserialize(string data) { }

	public override string Serialise(T obj) { }

}

