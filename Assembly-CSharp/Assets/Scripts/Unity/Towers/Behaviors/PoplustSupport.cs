namespace Assets.Scripts.Unity.Towers.Behaviors;

public class PoplustSupport : TowerBehaviorBuff
{
	public PoplustSupport parent; //Field offset: 0xB8
	public string mutatorId; //Field offset: 0xC0
	public string expMutatorId; //Field offset: 0xC8
	public int maxStacks; //Field offset: 0xD0
	public string expMaxStacks; //Field offset: 0xD8
	public float ratePercentIncrease; //Field offset: 0xE0
	public string expRatePercentIncrease; //Field offset: 0xE8
	public float piercePercentIncrease; //Field offset: 0xF0
	public string expPiercePercentIncrease; //Field offset: 0xF8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 257
	}

	public PoplustSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

