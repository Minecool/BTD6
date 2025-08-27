namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "CreateSoundOnProjectileCollision", menuName = "BTD6/Behaviors/Projectiles/CreateSoundOnProjectileCollision")]
public class CreateSoundOnProjectileCollision : ProjectileBehavior
{
	public Sound sound1; //Field offset: 0x30
	public Sound sound2; //Field offset: 0x38
	public Sound sound3; //Field offset: 0x40
	public Sound sound4; //Field offset: 0x48
	public Sound sound5; //Field offset: 0x50

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 348
	}

	public CreateSoundOnProjectileCollision() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

