namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "SpeedUpTowers", menuName = "BTD6/Behaviors/Projectiles/SpeedUpTowers")]
public class SpeedUpTowers : ProjectileBehavior
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

	public SpeedUpTowers() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

