namespace Unity.Services.Analytics.Internal;

internal class FileSystemCalls : IFileSystemCalls
{

	public FileSystemCalls() { }

	public override bool CanAccessFileSystem() { }

	public override void DeleteFile(string path) { }

	public override bool FileExists(string path) { }

	public override Stream OpenFileForWriting(string path) { }

}

