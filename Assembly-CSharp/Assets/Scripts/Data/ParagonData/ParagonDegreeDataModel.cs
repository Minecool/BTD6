namespace Assets.Scripts.Data.ParagonData;

public class ParagonDegreeDataModel
{
	public Int32[] powerDegreeRequirements; //Field offset: 0x10
	public float attackCooldownReductionX; //Field offset: 0x18
	public float piercePercentPerDegree; //Field offset: 0x1C
	public float pierceIncreasePerDegree; //Field offset: 0x20
	public float damagePercentPerDegree; //Field offset: 0x24
	public float damageIncreasePerDegree; //Field offset: 0x28
	public float damageIncreaseForDegrees; //Field offset: 0x2C
	public int degreeCount; //Field offset: 0x30
	public int maxPowerFromPops; //Field offset: 0x34
	public int maxPowerFromMoneySpent; //Field offset: 0x38
	public int maxPowerFromNonTier5Count; //Field offset: 0x3C
	public int maxPowerFromTier5Count; //Field offset: 0x40
	public float popsOverX; //Field offset: 0x44
	public float moneySpentOverX; //Field offset: 0x48
	public float nonTier5TowersMultByX; //Field offset: 0x4C
	public float tier5TowersMultByX; //Field offset: 0x50
	public float bonusBossDamagePercent; //Field offset: 0x54
	public int bonusBossDamagePerDegrees; //Field offset: 0x58
	public float cashEarnedContributionModifier; //Field offset: 0x5C
	public float paidContributionPenalty; //Field offset: 0x60

	public int MaxInvestment
	{
		 get { } //Length: 48
	}

	public ParagonDegreeDataModel(Int32[] powerDegreeRequirements, float attackCooldownReductionX, float piercePercentPerDegree, float pierceIncreasePerDegree, float damagePercentPerDegree, float damageIncreasePerDegree, float damageIncreaseForDegrees, int degreeCount, int maxPowerFromPops, int maxPowerFromMoneySpent, int maxPowerFromNonTier5Count, int maxPowerFromTier5Count, float popsOverX, float moneySpentOverX, float nonTier5TowersMultByX, float tier5TowersMultByX, float bonusBossDamagePercent, int bonusBossDamagePerDegrees, float cashEarnedContributionModifier, float paidContributionPenalty) { }

	public int get_MaxInvestment() { }

}

