namespace Assets.Scripts.Unity.CorvusSpells.PassiveBonuses;

public class Balance : TowerBehavior
{
	private BalanceModel def; //Field offset: 0x98
	public float maxGenerationManaPoolThreshold; //Field offset: 0xA0
	public string expMaxGenerationManaPoolThreshold; //Field offset: 0xA8
	public float maxGenerationRate; //Field offset: 0xB0
	public string expMaxGenerationRate; //Field offset: 0xB8
	public float minGenerationManaPoolThreshold; //Field offset: 0xC0
	public string expMinGenerationManaPoolThreshold; //Field offset: 0xC8
	public float minGenerationRate; //Field offset: 0xD0
	public string expMinGenerationRate; //Field offset: 0xD8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 254
	}

	public Balance() { }

	public virtual TowerBehaviorModel get_Def() { }

}

