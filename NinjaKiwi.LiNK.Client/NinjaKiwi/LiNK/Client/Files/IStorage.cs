namespace NinjaKiwi.LiNK.Client.Files;

public interface IStorage
{

	public string Name
	{
		 get { } //Length: 0
	}

	public void DeleteWriteStream(Stream stream) { }

	public string get_Name() { }

	public IEnumerable<Stream> GetAllReadStreams() { }

	public Stream GetWriteStream() { }

	public void Wipe() { }

}

