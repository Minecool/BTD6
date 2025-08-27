namespace Assets.Scripts.Models.ContentBrowser;

public interface IHasCustomMapModel : IContentBrowserData
{

	public CustomMapModel CustomMapModel
	{
		 get { } //Length: 0
	}

	public CustomMapModel get_CustomMapModel() { }

}

