namespace NinjaKiwi.GUTS.Models.ContentBrowser;

public interface IContentBrowserSettings
{

	public ContentBrowserServerSettings ContentBrowserServer
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public ContentBrowserServerSettings get_ContentBrowserServer() { }

	public void set_ContentBrowserServer(ContentBrowserServerSettings value) { }

}

