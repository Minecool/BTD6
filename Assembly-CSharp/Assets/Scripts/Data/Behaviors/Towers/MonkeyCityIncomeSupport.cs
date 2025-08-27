namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "MonkeyCityIncomeSupport", menuName = "BTD6/Behaviors/Towers/MonkeyCityIncomeSupport")]
public class MonkeyCityIncomeSupport : SupportBehavior
{
	public string uniqueMutatorId; //Field offset: 0x48
	public float incomeModifier; //Field offset: 0x50

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 220
	}

	public MonkeyCityIncomeSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

