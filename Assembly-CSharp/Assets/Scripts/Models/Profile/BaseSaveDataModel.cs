namespace Assets.Scripts.Models.Profile;

public class BaseSaveDataModel
{
	[JsonProperty("playerChallengeId")]
	public string playerContentId; //Field offset: 0x10
	[JsonProperty("playerChallengeType")]
	public Nullable<ContentType> playerContentType; //Field offset: 0x18
	public bool isCreationMode; //Field offset: 0x1A
	public string dailyChallengeEventID; //Field offset: 0x20

	public BaseSaveDataModel() { }

}

