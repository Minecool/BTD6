namespace NinjaKiwi.Common;

public interface IStorageManagerSerialiser
{

	public T Deserialize(string data) { }

	public string Serialise(T obj) { }

}

