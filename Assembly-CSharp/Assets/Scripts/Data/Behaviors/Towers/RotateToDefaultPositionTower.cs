namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "RotateToDefaultPositionTower", menuName = "BTD6/Behaviors/Towers/RotateToDefaultPositionTower")]
public class RotateToDefaultPositionTower : TowerBehavior
{
	public float rotation; //Field offset: 0x30
	public int onlyOnReachingTier; //Field offset: 0x34

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 128
	}

	public RotateToDefaultPositionTower() { }

	public virtual TowerBehaviorModel get_Def() { }

}

