namespace NinjaKiwi.LiNK.Client.LocalStorage;

public class FileKeyValueStorage : ILocalKeyValueStorage
{
	private const string UNDERSCORE = "_"; //Field offset: 0x0
	private string absolutePath; //Field offset: 0x10
	private readonly string relativePath; //Field offset: 0x18
	private readonly string rootDirectory; //Field offset: 0x20

	public FileKeyValueStorage(string subdirectory, string rootPath) { }

	private string GetFilePath(string key) { }

	private string InitialiseFileDirectory() { }

	public override Byte[] Load(string key) { }

	public override void Save(string key, Byte[] value) { }

}

