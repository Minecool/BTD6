namespace Assets.Scripts.Unity.Towers.Behaviors;

public class RotateToDefaultPositionTower : TowerBehavior
{
	public RotateToDefaultPositionTower parent; //Field offset: 0x98
	public float rotation; //Field offset: 0xA0
	public string expRotation; //Field offset: 0xA8
	public int onlyOnReachingTier; //Field offset: 0xB0
	public string expOnlyOnReachingTier; //Field offset: 0xB8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 134
	}

	public RotateToDefaultPositionTower() { }

	public virtual TowerBehaviorModel get_Def() { }

}

