namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "MoveBack", menuName = "BTD6/Behaviors/Projectiles/MoveBack")]
public class MoveBack : ProjectileBehavior
{
	public float multiplier; //Field offset: 0x30
	public float lifespan; //Field offset: 0x34
	public int layers; //Field offset: 0x38
	public string mutationId; //Field offset: 0x40

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 169
	}

	public MoveBack() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

