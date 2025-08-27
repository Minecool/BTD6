namespace NinjaKiwi.LiNK.Client.Files;

internal abstract class FileReader : IDisposable
{
	protected readonly BinaryReader binaryReader; //Field offset: 0x10

	public FileReader(Stream inputStream) { }

	public override void Dispose() { }

	public string ReadFileBinary() { }

	public abstract T ReadFileContent(JsonSerializerSettings jsonSettings) { }

	public FileFormat ReadFileFormat() { }

}

