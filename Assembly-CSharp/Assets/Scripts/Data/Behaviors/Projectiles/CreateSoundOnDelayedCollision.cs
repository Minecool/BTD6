namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "CreateSoundOnDelayedCollision", menuName = "BTD6/Behaviors/Projectiles/CreateSoundOnDelayedCollision")]
public class CreateSoundOnDelayedCollision : ProjectileBehavior
{
	public float delay; //Field offset: 0x30
	public Sound sound1; //Field offset: 0x38
	public Sound sound2; //Field offset: 0x40
	public Sound sound3; //Field offset: 0x48
	public Sound sound4; //Field offset: 0x50

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 323
	}

	public CreateSoundOnDelayedCollision() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

