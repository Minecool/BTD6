namespace Assets.Twitch.Models;

public class Choice : ChoiceBase
{
	public string id; //Field offset: 0x18
	public uint votes; //Field offset: 0x20
	public uint channel_points_votes; //Field offset: 0x24
	public uint bits_votes; //Field offset: 0x28

	public Choice() { }

}

