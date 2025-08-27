namespace Assets.Scripts.Data.Global;

public class LootIconSprites : ScriptableObject
{
	public SpriteReference monkeyMoneyIconR; //Field offset: 0x18
	public SpriteReference doubleCashModeIconR; //Field offset: 0x20
	public SpriteReference instaRankIconR; //Field offset: 0x28
	public SpriteReference instaTowerPacksIconR; //Field offset: 0x30
	public SpriteReference knowledgePointsIconR; //Field offset: 0x38
	public SpriteReference powerPacksIconR; //Field offset: 0x40
	public SpriteReference randomPowerIconR; //Field offset: 0x48
	public SpriteReference[] randomInstaMonkeyTierIconsR; //Field offset: 0x50
	public SpriteReference fullTowerUnlockIconR; //Field offset: 0x58
	public SpriteReference towerXPIconR; //Field offset: 0x60
	public SpriteReference[] raceBadgeIconsR; //Field offset: 0x68
	public SpriteReference[] bossBadgeIconsR; //Field offset: 0x70
	public SpriteReference[] bossEliteBadgeIconsR; //Field offset: 0x78
	public SpriteReference trophyIconR; //Field offset: 0x80
	public SpriteReference bigBloonsIconR; //Field offset: 0x88
	public SpriteReference smallBloonsIconR; //Field offset: 0x90
	public SpriteReference bigTowersIconR; //Field offset: 0x98
	public SpriteReference smallTowersIconR; //Field offset: 0xA0
	public SpriteReference resetDailyChestIconR; //Field offset: 0xA8
	public SpriteReference[] collectionEventIconsR; //Field offset: 0xB0
	public SpriteReference racesPassIconR; //Field offset: 0xB8
	public SpriteReference ctTrophiesIconR; //Field offset: 0xC0
	public SpriteReference ctPointsIconR; //Field offset: 0xC8
	public SpriteReference questIconR; //Field offset: 0xD0
	public SpriteReference smallBossesIconR; //Field offset: 0xD8
	public SpriteReference fastTrackIconR; //Field offset: 0xE0
	public SerializableDictionary<String, SpriteReference> towerIconsR; //Field offset: 0xE8
	public SerializableDictionary<String, SpriteReference> heroSkinIconsR; //Field offset: 0xF0
	[ReorderableList("items", True)]
	[SerializeField]
	public SpriteRefList ctLocalPlayerBadges; //Field offset: 0xF8
	[ReorderableList("items", True)]
	[SerializeField]
	public SpriteRefList ctLocalTeamBadges; //Field offset: 0x100
	[ReorderableList("items", True)]
	[SerializeField]
	public SpriteRefList ctGlobalPlayerBadges; //Field offset: 0x108
	[ReorderableList("items", True)]
	[SerializeField]
	public SpriteRefList ctGlobalTeamBadges; //Field offset: 0x110
	public SpriteReference doubleCashModeIcon; //Field offset: 0x118
	public SpriteReference knowledgePointsIcon; //Field offset: 0x120
	public SpriteReference monkeyMoneyIcon; //Field offset: 0x128
	public SpriteReference bigBloonsModeIcon; //Field offset: 0x130
	public SpriteReference smallBloonsModeIcon; //Field offset: 0x138
	public SpriteReference resetDailyChestModeIcon; //Field offset: 0x140
	public SpriteReference bigTowersModeIcon; //Field offset: 0x148
	public SpriteReference smallTowersModeIcon; //Field offset: 0x150
	public SpriteReference racesPassIcon; //Field offset: 0x158
	public SpriteReference mapEditorUnlockIcon; //Field offset: 0x160
	public SpriteReference fastTrackIcon; //Field offset: 0x168
	public SpriteReference sweepstakesTicketIcon; //Field offset: 0x170
	public SerializableDictionary<String, SpriteReference> legendsIcons; //Field offset: 0x178

	public LootIconSprites() { }

}

