namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "PierceUpTowers", menuName = "BTD6/Behaviors/Projectiles/PierceUpTowers")]
public class PierceUpTowers : ProjectileBehavior
{
	public float increase; //Field offset: 0x30
	public float lifespan; //Field offset: 0x34
	public bool useClosest; //Field offset: 0x38
	public string mutatorId; //Field offset: 0x40
	public float priority; //Field offset: 0x48
	public bool useTowerPosition; //Field offset: 0x4C
	public PrefabReference displayToAdd; //Field offset: 0x50

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 228
	}

	public PierceUpTowers() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

