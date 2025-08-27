namespace Assets.Scripts.Data.Boss;

public class BossData
{
	public BossType id; //Field offset: 0x10
	public PrefabReference eventBtn; //Field offset: 0x18
	public PrefabReference worldScene; //Field offset: 0x20
	public PrefabReference titlePrefab; //Field offset: 0x28
	public PrefabReference trackFXPrefab; //Field offset: 0x30
	public PrefabReference ambientMapFXPrefab; //Field offset: 0x38
	public SpriteReference normalBtn; //Field offset: 0x40
	public SpriteReference eliteBtn; //Field offset: 0x48
	public SpriteReference normalPortrait; //Field offset: 0x50
	public SpriteReference elitePortrait; //Field offset: 0x58
	public SpriteReference normalDefeatPortrait; //Field offset: 0x60
	public SpriteReference eliteDefeatPortrait; //Field offset: 0x68
	public SpriteReference normalHudIcon; //Field offset: 0x70
	public SpriteReference eliteHudIcon; //Field offset: 0x78
	public SpriteReference eventIcon; //Field offset: 0x80
	public SpriteReference eventBackground; //Field offset: 0x88
	public string bossChildrenOverlay; //Field offset: 0x90
	public SpriteReference normalBadgeIcon; //Field offset: 0x98
	public SpriteReference eliteBadgeIcon; //Field offset: 0xA0
	public MusicItem musicTrack; //Field offset: 0xA8

	public string LocsKey
	{
		 get { } //Length: 83
	}

	public BossData() { }

	public string get_LocsKey() { }

}

