namespace NinjaKiwi.LiNK.DataModels;

public class NexusStatusModel
{
	[JsonProperty("eligible")]
	public bool isEligible; //Field offset: 0x10
	[JsonProperty("linked")]
	public bool isLinked; //Field offset: 0x11

	public NexusStatusModel() { }

}

