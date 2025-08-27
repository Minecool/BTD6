namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "TowerExpireOnParentUpgraded", menuName = "BTD6/Behaviors/Towers/TowerExpireOnParentUpgraded")]
public class TowerExpireOnParentUpgraded : TowerBehavior
{
	public Tower tower; //Field offset: 0x30

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 182
	}

	public TowerExpireOnParentUpgraded() { }

	public virtual TowerBehaviorModel get_Def() { }

}

