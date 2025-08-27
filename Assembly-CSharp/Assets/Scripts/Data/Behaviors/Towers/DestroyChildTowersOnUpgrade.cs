namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "DestroyChildTowersOnUpgrade", menuName = "BTD6/Behaviors/Towers/DestroyChildTowersOnUpgrade")]
public class DestroyChildTowersOnUpgrade : TowerBehavior
{
	public string towerId; //Field offset: 0x30

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 105
	}

	public DestroyChildTowersOnUpgrade() { }

	public virtual TowerBehaviorModel get_Def() { }

}

