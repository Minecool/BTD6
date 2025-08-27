namespace Assets.Scripts.Data.Legends;

public class RogueGameModifiers
{
	public float rogueXpMultiplier; //Field offset: 0x10
	public float boostPlacementCostMultiplier; //Field offset: 0x14
	public Single[] upgradeCostMultipliers; //Field offset: 0x18
	public float boostRerollMultiplier; //Field offset: 0x20
	public float merchantBonusRareMultiplier; //Field offset: 0x24
	public float merchantBonusLegendaryMultiplier; //Field offset: 0x28
	public float finalBossHpMultiplier; //Field offset: 0x2C
	public float miniGameGoalRequirementMultiplier; //Field offset: 0x30
	public float miniGameGoalRequirementMultiplierIncreasing; //Field offset: 0x34
	public float miniBossGoalRequirementMultiplier; //Field offset: 0x38
	public float bloonSpeedMultiplier; //Field offset: 0x3C
	public float merchantCostMultiplier; //Field offset: 0x40
	public int bonusPartySize; //Field offset: 0x44
	public int bonusRecruitRerolls; //Field offset: 0x48
	public int bonusBossRerolls; //Field offset: 0x4C
	public int bonusLegendaryTilesPerStage; //Field offset: 0x50
	public int artifactLimit; //Field offset: 0x54
	public int rewardChoiceAddition; //Field offset: 0x58
	public int instaTowerCooldownAddition; //Field offset: 0x5C
	public bool retriesDisabled; //Field offset: 0x60
	public bool boostsDisabled; //Field offset: 0x61
	public bool rerollsDisabled; //Field offset: 0x62
	public bool towerIncomeDisabled; //Field offset: 0x63
	public bool heroPlacementDisabled; //Field offset: 0x64
	public bool xpShopDisabled; //Field offset: 0x65
	public bool bronzeGoalsDisabled; //Field offset: 0x66
	public bool startingArtifactsDisabled; //Field offset: 0x67
	public List<MapDifficulty> bannedMapDifficulties; //Field offset: 0x68

	public RogueGameModifiers() { }

}

