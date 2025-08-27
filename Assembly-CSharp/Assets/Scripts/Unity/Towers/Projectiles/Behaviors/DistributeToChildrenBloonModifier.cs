namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class DistributeToChildrenBloonModifier : ProjectileBehavior
{
	public DistributeToChildrenBloonModifier parent; //Field offset: 0x88
	public string bloonTags; //Field offset: 0x90
	public string expBloonTags; //Field offset: 0x98

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 117
	}

	public DistributeToChildrenBloonModifier() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

