namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "RangeUpTowers", menuName = "BTD6/Behaviors/Projectiles/RangeUpTowers")]
public class RangeUpTowers : ProjectileBehavior
{
	public float increase; //Field offset: 0x30
	public float lifespan; //Field offset: 0x34
	public bool isUnique; //Field offset: 0x38
	public bool useClosest; //Field offset: 0x39
	public string mutatorId; //Field offset: 0x40
	public float priority; //Field offset: 0x48

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 217
	}

	public RangeUpTowers() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

