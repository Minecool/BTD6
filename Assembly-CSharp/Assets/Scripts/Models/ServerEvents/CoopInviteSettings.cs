namespace Assets.Scripts.Models.ServerEvents;

public class CoopInviteSettings : EnableFlag
{
	public TimeSpan normalCheckInterval; //Field offset: 0x18
	public TimeSpan frequentCheckInterval; //Field offset: 0x20
	public TimeSpan popupDuration; //Field offset: 0x28

	public CoopInviteSettings() { }

}

