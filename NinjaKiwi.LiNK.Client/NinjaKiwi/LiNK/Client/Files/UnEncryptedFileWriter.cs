namespace NinjaKiwi.LiNK.Client.Files;

internal class UnEncryptedFileWriter : FileWriter
{

	public UnEncryptedFileWriter(Stream outputStream) { }

	public virtual void WriteFileContent(T content, JsonSerializerSettings jsonSettings) { }

}

