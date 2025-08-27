namespace NinjaKiwi.LiNK.Client.Files;

internal sealed class EncryptedFileReader : FileReader
{
	private readonly Func<Int32, String> getPassword; //Field offset: 0x18

	public EncryptedFileReader(Stream inputStream, Func<Int32, String> getPassword) { }

	public virtual T ReadFileContent(JsonSerializerSettings jsonSettings) { }

}

