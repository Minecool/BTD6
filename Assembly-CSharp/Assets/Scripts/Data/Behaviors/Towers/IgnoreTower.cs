namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "IgnoreTower", menuName = "BTD6/Behaviors/Towers/IgnoreTower")]
public class IgnoreTower : TowerBehavior
{
	public string ignoreId; //Field offset: 0x30

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 105
	}

	public IgnoreTower() { }

	public virtual TowerBehaviorModel get_Def() { }

}

