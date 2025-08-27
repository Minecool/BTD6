namespace NinjaKiwi.Common.ResourceUtils;

public interface IAssetReference
{

	public string AssetGUID
	{
		 get { } //Length: 0
	}

	public string get_AssetGUID() { }

	public bool RuntimeKeyIsValid() { }

}

