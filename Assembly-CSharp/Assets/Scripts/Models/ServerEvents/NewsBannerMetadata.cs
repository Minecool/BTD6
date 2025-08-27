namespace Assets.Scripts.Models.ServerEvents;

public class NewsBannerMetadata : IEventMetadata
{
	public string banner; //Field offset: 0x10
	public int bannerPriority; //Field offset: 0x18
	public bool showTimer; //Field offset: 0x1C
	public bool showOnArcade; //Field offset: 0x1D
	public bool showOnNetflix; //Field offset: 0x1E

	public NewsBannerMetadata() { }

}

