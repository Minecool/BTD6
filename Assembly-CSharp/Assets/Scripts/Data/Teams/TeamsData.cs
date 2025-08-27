namespace Assets.Scripts.Data.Teams;

public class TeamsData : ScriptableObject
{
	public TeamsStoreItems teamsStoreItems; //Field offset: 0x18
	public PrefabReference teamMedalPrefab; //Field offset: 0x20
	public PrefabReference teamMemberMessagePrefab; //Field offset: 0x28
	public PrefabReference teamSystemMessagePrefab; //Field offset: 0x30
	public PrefabReference teamCtMessagePrefab; //Field offset: 0x38
	public PrefabReference teamBossRushMessagePrefab; //Field offset: 0x40
	public PrefabReference teamMemberPanelPrefab; //Field offset: 0x48
	public ProfileAvatars teamIcons; //Field offset: 0x50
	public ProfileAvatars teamFrames; //Field offset: 0x58
	public ProfileBanners teamBanners; //Field offset: 0x60
	public PrefabReference defaultBuildingSlot; //Field offset: 0x68
	public PrefabReference defaultWaterSlot; //Field offset: 0x70
	public PrefabReference defaultFlyingSlot; //Field offset: 0x78
	public PrefabReference defaultFlagSlot; //Field offset: 0x80
	public PrefabReference defaultBase1Slot; //Field offset: 0x88
	public PrefabReference defaultBase2Slot; //Field offset: 0x90
	public PrefabReference defaultBase3Slot; //Field offset: 0x98
	public PrefabReference defaultBase4Slot; //Field offset: 0xA0
	public CTTeamsBuildingMaterialSwap defaultFlagMaterials; //Field offset: 0xA8
	public CTTeamsBuildingMaterialSwap defaultLifeRingMaterials; //Field offset: 0xB0

	public TeamsData() { }

}

