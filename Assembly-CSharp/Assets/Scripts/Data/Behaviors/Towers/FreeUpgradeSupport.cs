namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "FreeUpgradeSupport", menuName = "BTD6/Behaviors/Towers/FreeUpgradeSupport")]
public class FreeUpgradeSupport : SupportBehavior
{
	public string mutatorId; //Field offset: 0x48
	public int upgrade; //Field offset: 0x50

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 191
	}

	public FreeUpgradeSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

