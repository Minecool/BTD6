namespace Assets.Twitch.Models;

public class PollItem
{
	public string id; //Field offset: 0x10
	public string title; //Field offset: 0x18
	public PollItemStatus status; //Field offset: 0x20
	public uint votes; //Field offset: 0x24

	public PollItem(string id, string title) { }

}

