namespace Assets.Scripts.Models.Towers;

public class TechBotCIData
{
	public PrefabReference validTargetImgId; //Field offset: 0x10
	public List<ObjectId> validTowerIds; //Field offset: 0x18
	public List<ObjectId> alreadylinkedIds; //Field offset: 0x20
	public List<ObjectId> noAbilityIds; //Field offset: 0x28
	public string baseHelperMsg; //Field offset: 0x30
	public string alreadyLinkedMsg; //Field offset: 0x38
	public string noAbilityMsg; //Field offset: 0x40
	public string cantLinkMsg; //Field offset: 0x48
	public string noTowersMsg; //Field offset: 0x50

	public TechBotCIData() { }

}

