namespace Assets.Scripts.Models.ServerEvents;

public class MailboxSettings
{
	public TimeSpan autoRefreshDelay; //Field offset: 0x10
	public String[] confirmDeletion; //Field offset: 0x18

	public MailboxSettings() { }

}

