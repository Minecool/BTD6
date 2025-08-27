namespace Assets.Twitch.Models;

public class Poll
{
	public string id; //Field offset: 0x10
	[JsonProperty("broadcaster_id")]
	public string userId; //Field offset: 0x18
	[JsonProperty("broadcaster_name")]
	public string userName; //Field offset: 0x20
	[JsonProperty("broadcaster_login")]
	public string userLogin; //Field offset: 0x28
	public string title; //Field offset: 0x30
	public Choice[] choices; //Field offset: 0x38
	[JsonProperty("bits_voting_enabled")]
	public bool canBitVote; //Field offset: 0x40
	[JsonProperty("bits_per_vote")]
	public uint bitsPerVote; //Field offset: 0x44
	[JsonProperty("channel_points_voting_enabled")]
	public bool canPointVote; //Field offset: 0x48
	[JsonProperty("channel_points_per_vote")]
	public uint pointsPerVote; //Field offset: 0x4C
	public PollStatus status; //Field offset: 0x50
	[JsonConverter(typeof(TimeSpanSecondsConverter))]
	public TimeSpan duration; //Field offset: 0x58
	[JsonProperty("started_at")]
	public DateTime startTime; //Field offset: 0x60
	[JsonProperty("ended_at")]
	public DateTime endedTime; //Field offset: 0x68

	public Poll() { }

}

