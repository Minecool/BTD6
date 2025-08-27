namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "TargetSupplierSupport", menuName = "BTD6/Behaviors/Towers/TargetSupplierSupport")]
public class TargetSupplierSupport : SupportBehavior
{
	public string mutatorId; //Field offset: 0x48
	public AttackBehavior targetSupplier; //Field offset: 0x50

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 354
	}

	public TargetSupplierSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

