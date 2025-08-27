namespace Assets.Scripts.Unity.Towers.Behaviors;

public class SwitchTargetSupplierOnUpgrade : TowerBehavior
{
	public SwitchTargetSupplierOnUpgrade parent; //Field offset: 0x98
	public string targetSupplierName; //Field offset: 0xA0
	public string expTargetSupplierName; //Field offset: 0xA8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 108
	}

	public SwitchTargetSupplierOnUpgrade() { }

	public virtual TowerBehaviorModel get_Def() { }

}

