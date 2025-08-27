namespace NinjaKiwi.Common.IO;

public static class FileIO
{
	private static IFileIO defaultPersistentStorage; //Field offset: 0x0
	private static IFileIO defaultTemporaryStorage; //Field offset: 0x8
	private static readonly Char[] invalidFileNameChars; //Field offset: 0x10

	public static IFileIO DefaultPersistentStorage
	{
		 get { } //Length: 227
	}

	public static IFileIO DefaultTemporaryStorage
	{
		 get { } //Length: 229
	}

	private static FileIO() { }

	public static IFileIO get_DefaultPersistentStorage() { }

	public static IFileIO get_DefaultTemporaryStorage() { }

	public static string ReplaceInvalidFileNameChars(string filename, char replace) { }

}

