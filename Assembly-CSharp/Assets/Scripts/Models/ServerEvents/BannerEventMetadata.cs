namespace Assets.Scripts.Models.ServerEvents;

public class BannerEventMetadata : NewsBannerMetadata
{
	public string action; //Field offset: 0x20
	public string url; //Field offset: 0x28

	public BannerEventMetadata() { }

}

