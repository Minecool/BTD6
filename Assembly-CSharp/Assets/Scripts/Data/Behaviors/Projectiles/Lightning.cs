namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "Lightning", menuName = "BTD6/Behaviors/Projectiles/Lightning")]
public class Lightning : ProjectileBehavior
{
	public int splits; //Field offset: 0x30
	public Emission emission; //Field offset: 0x38
	public float splitRange; //Field offset: 0x40
	public float delay; //Field offset: 0x44

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 208
	}

	public Lightning() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

