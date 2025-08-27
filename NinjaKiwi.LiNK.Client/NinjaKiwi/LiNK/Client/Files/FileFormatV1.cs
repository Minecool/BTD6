namespace NinjaKiwi.LiNK.Client.Files;

internal class FileFormatV1 : FileFormat
{
	public readonly int saveCount; //Field offset: 0x10
	public readonly Nullable<Guid> guid; //Field offset: 0x14
	public readonly Nullable<DateTime> dateCreated; //Field offset: 0x28
	public readonly Nullable<DateTime> dateModified; //Field offset: 0x38

	public virtual int Version
	{
		 get { } //Length: 6
	}

	public FileFormatV1(int saveCount, Nullable<Guid> guid, Nullable<DateTime> dateCreated, Nullable<DateTime> dateModified) { }

	public FileFormatV1() { }

	public FileFormatV1(BinaryReader reader) { }

	public static FileFormatV1 FromFile(File<T> file) { }

	public virtual int get_Version() { }

	public virtual Byte[] ToBytes() { }

	public virtual File<T> ToFile(T content, PasswordGenerator passwordGenerator, JsonSerializerSettings jsonSettings, IStorage storage) { }

}

