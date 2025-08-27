namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "PlayAnimationIndex", menuName = "BTD6/Behaviors/Towers/PlayAnimationIndex")]
public class PlayAnimationIndex : TowerBehavior
{
	public int placeAnimation; //Field offset: 0x30
	public int upgradeAnimation; //Field offset: 0x34

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 161
	}

	public PlayAnimationIndex() { }

	public virtual TowerBehaviorModel get_Def() { }

}

