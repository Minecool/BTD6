namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "MorphBloon", menuName = "BTD6/Behaviors/Projectiles/MorphBloon")]
public class MorphBloon : ProjectileBehavior
{
	public string bloonId; //Field offset: 0x30

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 105
	}

	public MorphBloon() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

