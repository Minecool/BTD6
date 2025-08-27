namespace Assets.Scripts.Models.ServerEvents;

public class SweepstakesEventMetadata : NewsBannerMetadata, IEventMetadata
{
	public string settingsId; //Field offset: 0x20
	public string prizeBanner; //Field offset: 0x28

	public SweepstakesEventMetadata() { }

}

