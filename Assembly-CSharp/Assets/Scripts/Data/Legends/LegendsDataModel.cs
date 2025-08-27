namespace Assets.Scripts.Data.Legends;

public class LegendsDataModel
{
	public Dictionary<String, RogueGameSaveData> rogueSaves; //Field offset: 0x10
	public string selectedRogueSave; //Field offset: 0x18
	public HashSet<String> unlockedStarterArtifacts; //Field offset: 0x20
	public List<ArtifactLoot> selectedStarterArtifacts; //Field offset: 0x28
	[HideInInspector]
	public int uniqueInstaId; //Field offset: 0x30
	public int rogueGameId; //Field offset: 0x34
	public int highestStageBeaten; //Field offset: 0x38
	public bool hasSeenInfoPopup; //Field offset: 0x3C
	public int rogueLegendXp; //Field offset: 0x40
	public int unseenLegendXpReward; //Field offset: 0x44
	public bool hasSeenXpShopPip; //Field offset: 0x48
	public Dictionary<String, Int32> unlockedRogueXpShopItems; //Field offset: 0x50
	public Dictionary<String, Dictionary`2<String, Boolean>> savedLegendsStats; //Field offset: 0x58
	public Dictionary<String, LegendMedalSaveData> savedLegendMedals; //Field offset: 0x60
	public Dictionary<Int32, Int32> featsProgress; //Field offset: 0x68
	public HashSet<Int32> featsClaimed; //Field offset: 0x70

	public LegendsDataModel() { }

	public void DeleteProgress(string saveName) { }

	public void ResetRogueProgress(string saveName) { }

}

