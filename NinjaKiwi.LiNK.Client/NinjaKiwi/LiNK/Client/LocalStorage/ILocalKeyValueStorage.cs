namespace NinjaKiwi.LiNK.Client.LocalStorage;

public interface ILocalKeyValueStorage
{

	public Byte[] Load(string key) { }

	public void Save(string key, Byte[] value) { }

}

