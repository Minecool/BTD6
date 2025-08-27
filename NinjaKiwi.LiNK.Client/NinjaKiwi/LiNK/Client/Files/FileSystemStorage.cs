namespace NinjaKiwi.LiNK.Client.Files;

public abstract class FileSystemStorage : IStorage
{
	internal enum Strategy
	{
		Basic = 0,
		TimedBackup = 1,
		ReplaceOnDispose = 2,
		Revisions = 3,
		ClientDefined = 4,
	}

	private static Func<String, IStorage> genericStorageOverride; //Field offset: 0x0
	public readonly string filePath; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; //Field offset: 0x18

	public override string Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	protected FileSystemStorage(string filePath) { }

	public static IStorage CreateStorage(string filePath, Strategy strategy) { }

	public abstract void DeleteWriteStream(Stream stream) { }

	[CompilerGenerated]
	public override string get_Name() { }

	public abstract IEnumerable<Stream> GetAllReadStreams() { }

	public abstract Stream GetWriteStream() { }

	public static void SetGenericStorageOverride(Func<String, IStorage> value) { }

	public abstract void Wipe() { }

}

