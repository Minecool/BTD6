namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "IgnoreTowersBlocker", menuName = "BTD6/Behaviors/Towers/IgnoreTowersBlocker")]
public class IgnoreTowersBlocker : TowerBehavior
{
	public string whitelistedTowers; //Field offset: 0x30

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 159
	}

	public IgnoreTowersBlocker() { }

	public virtual TowerBehaviorModel get_Def() { }

}

