namespace Assets.Scripts.Models.ServerEvents;

public class ChallengeBrowserTabSettings
{
	public TabSettings casual; //Field offset: 0x10
	public TabSettings expert; //Field offset: 0x18
	public TabSettings mostLiked; //Field offset: 0x20
	public TabSettingsTrending trending; //Field offset: 0x28
	public TabSettings newest; //Field offset: 0x30
	public TabSettings favorite; //Field offset: 0x38
	public TabSettings following; //Field offset: 0x40
	public TabSettings saved; //Field offset: 0x48
	public TabSettings created; //Field offset: 0x50
	public TabSettings played; //Field offset: 0x58
	public TabSettings custom; //Field offset: 0x60
	public TabSettings featured; //Field offset: 0x68
	public TabSettings workInProgress; //Field offset: 0x70
	public int maxPanels; //Field offset: 0x78
	public int maxCurationPanels; //Field offset: 0x7C

	public ChallengeBrowserTabSettings() { }

}

