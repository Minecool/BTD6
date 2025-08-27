namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "ClearHitBloons", menuName = "BTD6/Behaviors/Projectiles/ClearHitBloons")]
public class ClearHitBloons : ProjectileBehavior
{
	public float interval; //Field offset: 0x30

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 106
	}

	public ClearHitBloons() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

