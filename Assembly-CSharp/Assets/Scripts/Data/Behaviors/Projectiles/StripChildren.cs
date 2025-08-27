namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "StripChildren", menuName = "BTD6/Behaviors/Projectiles/StripChildren")]
public class StripChildren : ProjectileBehavior
{
	public string overlayType; //Field offset: 0x30

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 105
	}

	public StripChildren() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

