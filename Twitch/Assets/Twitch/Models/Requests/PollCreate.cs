namespace Assets.Twitch.Models.Requests;

public class PollCreate
{
	[JsonProperty("broadcaster_id")]
	public string userId; //Field offset: 0x10
	public string title; //Field offset: 0x18
	public ChoiceBase[] choices; //Field offset: 0x20
	public uint duration; //Field offset: 0x28
	[JsonProperty("bits_voting_enabled")]
	public bool canBitVote; //Field offset: 0x2C
	[JsonProperty("bits_per_vote")]
	public uint bitVotePrice; //Field offset: 0x30
	[JsonProperty("channel_points_voting_enabled")]
	public bool canPointVote; //Field offset: 0x34
	[JsonProperty("channel_points_per_vote")]
	public uint pointVotePrice; //Field offset: 0x38

	public PollCreate(string userId, string title, ChoiceBase[] choices, uint duration) { }

	[OnSerializing]
	public void Validate(StreamingContext context = null) { }

}

