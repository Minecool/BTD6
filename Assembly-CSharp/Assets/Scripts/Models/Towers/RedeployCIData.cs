namespace Assets.Scripts.Models.Towers;

public class RedeployCIData
{
	public PrefabReference validTargetImgId; //Field offset: 0x10
	public List<ObjectId> validTowerIds; //Field offset: 0x18
	public string helperMsg; //Field offset: 0x20
	public string helperMsgBanned; //Field offset: 0x28

	public RedeployCIData() { }

}

