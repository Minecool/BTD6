namespace System.IO;

public sealed class DirectoryInfo : FileSystemInfo
{

	public DirectoryInfo(string path) { }

	private DirectoryInfo(SerializationInfo info, StreamingContext context) { }

	internal DirectoryInfo(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false) { }

	public void Delete(bool recursive) { }

	public virtual void Delete() { }

	public IEnumerable<DirectoryInfo> EnumerateDirectories(string searchPattern, SearchOption searchOption) { }

	public IEnumerable<DirectoryInfo> EnumerateDirectories(string searchPattern, EnumerationOptions enumerationOptions) { }

	public IEnumerable<FileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption) { }

	public IEnumerable<FileInfo> EnumerateFiles(string searchPattern, EnumerationOptions enumerationOptions) { }

	public DirectoryInfo[] GetDirectories() { }

	public DirectoryInfo[] GetDirectories(string searchPattern, EnumerationOptions enumerationOptions) { }

	public FileInfo[] GetFiles() { }

	public FileInfo[] GetFiles(string searchPattern) { }

	public FileInfo[] GetFiles(string searchPattern, SearchOption searchOption) { }

	public FileInfo[] GetFiles(string searchPattern, EnumerationOptions enumerationOptions) { }

	private void Init(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false) { }

	internal static IEnumerable<FileSystemInfo> InternalEnumerateInfos(string path, string searchPattern, SearchTarget searchTarget, EnumerationOptions options) { }

}

