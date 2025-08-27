namespace Assets.Scripts.Unity.Towers.Behaviors;

public class PlayAnimationIndex : TowerBehavior
{
	public PlayAnimationIndex parent; //Field offset: 0x98
	public int placeAnimation; //Field offset: 0xA0
	public string expPlaceAnimation; //Field offset: 0xA8
	public int upgradeAnimation; //Field offset: 0xB0
	public string expUpgradeAnimation; //Field offset: 0xB8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 179
	}

	public PlayAnimationIndex() { }

	public virtual TowerBehaviorModel get_Def() { }

}

