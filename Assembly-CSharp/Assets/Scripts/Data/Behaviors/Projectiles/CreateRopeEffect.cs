namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "CreateRopeEffect", menuName = "BTD6/Behaviors/Projectiles/CreateRopeEffect")]
public class CreateRopeEffect : ProjectileBehavior
{
	public PrefabReference display; //Field offset: 0x30
	public PrefabReference endDisplay; //Field offset: 0x38
	public float spriteRadius; //Field offset: 0x40
	public float spriteSpacing; //Field offset: 0x44
	public float spriteOffset; //Field offset: 0x48

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 195
	}

	public CreateRopeEffect() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

