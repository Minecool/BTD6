namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "SwitchTargetSupplierOnUpgrade", menuName = "BTD6/Behaviors/Towers/SwitchTargetSupplierOnUpgrade")]
public class SwitchTargetSupplierOnUpgrade : TowerBehavior
{
	public string targetSupplierName; //Field offset: 0x30

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 105
	}

	public SwitchTargetSupplierOnUpgrade() { }

	public virtual TowerBehaviorModel get_Def() { }

}

