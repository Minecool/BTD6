namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "DamageTypeSupport", menuName = "BTD6/Behaviors/Towers/DamageTypeSupport")]
public class DamageTypeSupport : SupportBehavior
{
	public bool isUnique; //Field offset: 0x48
	public string damageType; //Field offset: 0x50
	public string mutatorId; //Field offset: 0x58

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 284
	}

	public DamageTypeSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

