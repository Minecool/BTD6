namespace NinjaKiwi.LiNK.Client.Files;

internal class EncryptedFileWriter : FileWriter
{
	private readonly Func<StringAndVersion> getPassword; //Field offset: 0x18

	public EncryptedFileWriter(Stream outputStream, Func<StringAndVersion> getPassword) { }

	public virtual void WriteFileContent(T content, JsonSerializerSettings jsonSettings) { }

}

