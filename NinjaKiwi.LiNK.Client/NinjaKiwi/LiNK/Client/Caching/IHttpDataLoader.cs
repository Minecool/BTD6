namespace NinjaKiwi.LiNK.Client.Caching;

public interface IHttpDataLoader : IDataLoader
{

	public void SetUp(ContentEncoding requestEncoding = 0, ContentEncoding responseEncoding = 0, bool responseCompression = true, TimeSpan timeout = null) { }

}

