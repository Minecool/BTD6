namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "DistributeToChildrenBloonModifier", menuName = "BTD6/Behaviors/Projectiles/DistributeToChildrenBloonModifier")]
public class DistributeToChildrenBloonModifier : ProjectileBehavior
{
	public string bloonTags; //Field offset: 0x30

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 114
	}

	public DistributeToChildrenBloonModifier() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

