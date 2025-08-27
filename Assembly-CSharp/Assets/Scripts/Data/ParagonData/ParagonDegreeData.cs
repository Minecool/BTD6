namespace Assets.Scripts.Data.ParagonData;

public class ParagonDegreeData : ScriptableObject
{
	public Int32[] powerDegreeRequirements; //Field offset: 0x18
	public float attackCooldownReductionX; //Field offset: 0x20
	public float piercePercentPerDegree; //Field offset: 0x24
	public float pierceIncreasePerDegree; //Field offset: 0x28
	public float damagePercentPerDegree; //Field offset: 0x2C
	public float damageIncreasePerDegree; //Field offset: 0x30
	public float damageIncreaseForDegrees; //Field offset: 0x34
	public int degreeCount; //Field offset: 0x38
	public int maxPowerFromPops; //Field offset: 0x3C
	public int maxPowerFromMoneySpent; //Field offset: 0x40
	public int maxPowerFromNonTier5Count; //Field offset: 0x44
	public int maxPowerFromTier5Count; //Field offset: 0x48
	public float popsOverX; //Field offset: 0x4C
	public float moneySpentOverX; //Field offset: 0x50
	public float nonTier5TowersMultByX; //Field offset: 0x54
	public float tier5TowersMultByX; //Field offset: 0x58
	public float bonusBossDamagePercent; //Field offset: 0x5C
	public int bonusBossDamagePerDegrees; //Field offset: 0x60
	public float cashEarnedContributionModifier; //Field offset: 0x64
	public float paidContributionPenalty; //Field offset: 0x68

	public ParagonDegreeDataModel Def
	{
		 get { } //Length: 395
	}

	public ParagonDegreeData() { }

	public ParagonDegreeDataModel get_Def() { }

}

