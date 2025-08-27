namespace NinjaKiwi.LiNK.Client.Files;

internal abstract class FileFormat
{

	public abstract int Version
	{
		 get { } //Length: 0
	}

	protected FileFormat() { }

	public static FileFormat CreateFromFile(File<T> file) { }

	public static FileFormat CreateLatest() { }

	public abstract int get_Version() { }

	public abstract Byte[] ToBytes() { }

	public abstract File<T> ToFile(T content, PasswordGenerator passwordGenerator, JsonSerializerSettings jsonSettings, IStorage storage) { }

}

