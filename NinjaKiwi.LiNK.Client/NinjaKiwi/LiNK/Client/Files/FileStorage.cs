namespace NinjaKiwi.LiNK.Client.Files;

public static class FileStorage
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public string password; //Field offset: 0x10

		public <>c__DisplayClass8_0() { }

		internal string <CreatePasswordGenerator>b__0() { }

	}

	internal class CorruptedException : Exception
	{

		public CorruptedException() { }

	}


	private static PasswordGenerator CreatePasswordGenerator(string password) { }

	private static File<T> InternalLoad(IStorage storage, PasswordGenerator passwordGenerator, JsonSerializerSettings jsonSettings, bool ignoreIfNotReadable) { }

	public static File<T> Load(string path, Strategy storageStrategy = 0, JsonSerializerSettings jsonSettings = null, bool ignoreIfNotReadable = false) { }

	public static File<T> Load(string path, string password, Strategy storageStrategy = 0, JsonSerializerSettings jsonSettings = null, bool ignoreIfNotReadable = false) { }

	public static File<T> Load(string path, PasswordGenerator passwordGenerator, Strategy storageStrategy = 0, JsonSerializerSettings jsonSettings = null, bool ignoreIfNotReadable = false) { }

	public static File<T> LoadStorage(IStorage storage, JsonSerializerSettings jsonSettings = null, bool ignoreIfNotReadable = false) { }

	public static File<T> LoadStorage(IStorage storage, string password, JsonSerializerSettings jsonSettings = null, bool ignoreIfNotReadable = false) { }

	public static File<T> LoadStorage(IStorage storage, PasswordGenerator passwordGenerator, JsonSerializerSettings jsonSettings = null, bool ignoreIfNotReadable = false) { }

}

