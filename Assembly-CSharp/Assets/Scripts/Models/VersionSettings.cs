namespace Assets.Scripts.Models;

public class VersionSettings
{
	public TimeSpan popupInterval; //Field offset: 0x10
	public string update_url; //Field offset: 0x18
	public Outdated outdated; //Field offset: 0x20

	public VersionSettings() { }

}

