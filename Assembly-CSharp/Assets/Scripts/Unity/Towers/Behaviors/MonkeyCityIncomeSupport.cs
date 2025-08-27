namespace Assets.Scripts.Unity.Towers.Behaviors;

public class MonkeyCityIncomeSupport : SupportBehavior
{
	public MonkeyCityIncomeSupport parent; //Field offset: 0xC8
	public string uniqueMutatorId; //Field offset: 0xD0
	public string expUniqueMutatorId; //Field offset: 0xD8
	public float incomeModifier; //Field offset: 0xE0
	public string expIncomeModifier; //Field offset: 0xE8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 258
	}

	public MonkeyCityIncomeSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

