namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "Rotate", menuName = "BTD6/Behaviors/Projectiles/Rotate")]
public class Rotate : ProjectileBehavior
{
	public float angle; //Field offset: 0x30

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 106
	}

	public Rotate() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

