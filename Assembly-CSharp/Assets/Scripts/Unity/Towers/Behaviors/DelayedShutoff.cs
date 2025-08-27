namespace Assets.Scripts.Unity.Towers.Behaviors;

public class DelayedShutoff : TowerBehavior
{
	public DelayedShutoff parent; //Field offset: 0x98
	public float delay; //Field offset: 0xA0
	public string expDelay; //Field offset: 0xA8
	public float shutoffTime; //Field offset: 0xB0
	public string expShutoffTime; //Field offset: 0xB8
	public Effect effect; //Field offset: 0xC0
	public Effect expEffect; //Field offset: 0xC8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 239
	}

	public DelayedShutoff() { }

	public virtual TowerBehaviorModel get_Def() { }

}

