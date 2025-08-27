namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class DistributeToChildrenSet : ProjectileBehavior
{
	public DistributeToChildrenSet parent; //Field offset: 0x88
	public int layers; //Field offset: 0x90
	public string expLayers; //Field offset: 0x98

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 116
	}

	public DistributeToChildrenSet() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

