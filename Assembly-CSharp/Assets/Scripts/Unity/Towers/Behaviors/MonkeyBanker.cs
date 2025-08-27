namespace Assets.Scripts.Unity.Towers.Behaviors;

public class MonkeyBanker : TowerBehaviorBuff
{
	public MonkeyBanker parent; //Field offset: 0xB8
	public float bankIncomeMultiplierBase; //Field offset: 0xC0
	public string expBankIncomeMultiplierBase; //Field offset: 0xC8
	public float bankIncomeMultiplierPerStack; //Field offset: 0xD0
	public string expBankIncomeMultiplierPerStack; //Field offset: 0xD8
	public int bankIncomeMaxStacks; //Field offset: 0xE0
	public string expBankIncomeMaxStacks; //Field offset: 0xE8
	public bool isBananaFinancier; //Field offset: 0xF0
	public string expIsBananaFinancier; //Field offset: 0xF8
	public float bankInstaDepositAmount; //Field offset: 0x100
	public string expBankInstaDepositAmount; //Field offset: 0x108
	public float bankInstaDepositStackAmount; //Field offset: 0x110
	public string expBankInstaDepositStackAmount; //Field offset: 0x118
	public float bankInstaDepositMaxStackAmount; //Field offset: 0x120
	public string expBankInstaDepositMaxStackAmount; //Field offset: 0x128
	public int bankCollectAnimation; //Field offset: 0x130
	public string expBankCollectAnimation; //Field offset: 0x138

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 293
	}

	public MonkeyBanker() { }

	public virtual TowerBehaviorModel get_Def() { }

}

