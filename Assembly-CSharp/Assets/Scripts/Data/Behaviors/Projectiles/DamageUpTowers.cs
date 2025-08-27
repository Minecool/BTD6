namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "DamageUpTowers", menuName = "BTD6/Behaviors/Projectiles/DamageUpTowers")]
public class DamageUpTowers : ProjectileBehavior
{
	public int increase; //Field offset: 0x30
	public float lifespan; //Field offset: 0x34
	public bool useClosest; //Field offset: 0x38
	public string mutatorId; //Field offset: 0x40
	public float priority; //Field offset: 0x48
	public bool useTowerPosition; //Field offset: 0x4C

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 197
	}

	public DamageUpTowers() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

