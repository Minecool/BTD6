namespace NinjaKiwi.LiNK.Client.Files;

internal sealed class UnEncryptedFileReader : FileReader
{

	public UnEncryptedFileReader(Stream inputStream) { }

	public virtual T ReadFileContent(JsonSerializerSettings jsonSettings) { }

}

