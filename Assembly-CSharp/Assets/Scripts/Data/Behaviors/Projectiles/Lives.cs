namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "Lives", menuName = "BTD6/Behaviors/Projectiles/Lives")]
public class Lives : ProjectileBehavior
{
	public float minimum; //Field offset: 0x30
	public float maximum; //Field offset: 0x34
	public float salvage; //Field offset: 0x38

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 155
	}

	public Lives() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

