namespace NinjaKiwi.LiNK.Client.Files;

internal abstract class FileWriter : IDisposable
{
	protected readonly BinaryWriter binaryWriter; //Field offset: 0x10

	public FileWriter(Stream outputStream) { }

	public override void Dispose() { }

	public abstract void WriteFileContent(T content, JsonSerializerSettings jsonSettings) { }

	public void WriteFileFormat(FileFormat fileFormat) { }

}

