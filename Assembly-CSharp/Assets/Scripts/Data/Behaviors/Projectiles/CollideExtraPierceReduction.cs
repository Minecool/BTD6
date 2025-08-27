namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "CollideExtraPierceReduction", menuName = "BTD6/Behaviors/Projectiles/CollideExtraPierceReduction")]
public class CollideExtraPierceReduction : ProjectileBehavior
{
	public string bloonTag; //Field offset: 0x30
	public int extraAmount; //Field offset: 0x38
	public bool destroyProjectileIfPierceNotEnough; //Field offset: 0x3C

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 147
	}

	public CollideExtraPierceReduction() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

