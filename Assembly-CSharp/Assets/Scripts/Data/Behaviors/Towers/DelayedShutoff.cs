namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "DelayedShutoff", menuName = "BTD6/Behaviors/Towers/DelayedShutoff")]
public class DelayedShutoff : TowerBehavior
{
	public float delay; //Field offset: 0x30
	public float shutoffTime; //Field offset: 0x34
	public Effect effect; //Field offset: 0x38

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 239
	}

	public DelayedShutoff() { }

	public virtual TowerBehaviorModel get_Def() { }

}

