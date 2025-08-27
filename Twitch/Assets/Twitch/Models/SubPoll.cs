namespace Assets.Twitch.Models;

public class SubPoll
{
	public int id; //Field offset: 0x10
	public List<PollItem> pollItems; //Field offset: 0x18
	public Poll poll; //Field offset: 0x20
	public Exception exception; //Field offset: 0x28
	public Task updater; //Field offset: 0x30

	public SubPoll(int id) { }

}

