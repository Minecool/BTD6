namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "AcidPool", menuName = "BTD6/Behaviors/Projectiles/AcidPool")]
public class AcidPool : ProjectileBehavior
{
	public float lifespan; //Field offset: 0x30
	public float lifespanIfMisses; //Field offset: 0x34
	public float radiusIfMisses; //Field offset: 0x38
	public float pierceIfMisses; //Field offset: 0x3C

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 198
	}

	public AcidPool() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

