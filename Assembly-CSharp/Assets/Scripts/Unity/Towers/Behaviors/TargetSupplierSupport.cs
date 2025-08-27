namespace Assets.Scripts.Unity.Towers.Behaviors;

public class TargetSupplierSupport : SupportBehavior
{
	public TargetSupplierSupport parent; //Field offset: 0xC8
	public string mutatorId; //Field offset: 0xD0
	public string expMutatorId; //Field offset: 0xD8
	public AttackBehavior targetSupplier; //Field offset: 0xE0
	public AttackBehavior expTargetSupplier; //Field offset: 0xE8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 386
	}

	public TargetSupplierSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

