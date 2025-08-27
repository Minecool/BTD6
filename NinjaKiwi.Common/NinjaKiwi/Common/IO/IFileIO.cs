namespace NinjaKiwi.Common.IO;

public interface IFileIO
{

	public void CleanDirectory(string path) { }

	public void CreateDirectory(string path) { }

	public bool DirectoryExists(string path) { }

	public void FileDelete(string path) { }

	public bool FileExists(string path) { }

	public IEnumerable<String> FilesInDirectory(string path, bool recursive) { }

	public DateTime GetCreationTime(string path) { }

	public long GetFileSize(string path) { }

	public DateTime GetLastAccessTime(string path) { }

	public DateTime GetLastWriteTime(string path) { }

	public Byte[] ReadAllBytes(string path) { }

	public Task<Byte[]> ReadAllBytesAsync(string path, CancellationToken cancellationToken = null) { }

	public void SetLastAccessTime(string path, DateTime time) { }

	public void WriteAllBytes(string path, Byte[] bytes) { }

	public Task WriteAllBytesAsync(string path, Byte[] bytes, CancellationToken cancellationToken = null) { }

}

