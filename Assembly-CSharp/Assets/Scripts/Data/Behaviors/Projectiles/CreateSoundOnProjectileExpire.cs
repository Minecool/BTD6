namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "CreateSoundOnProjectileExpire", menuName = "BTD6/Behaviors/Projectiles/CreateSoundOnProjectileExpire")]
public class CreateSoundOnProjectileExpire : ProjectileBehavior
{
	public Sound sound1; //Field offset: 0x30
	public Sound sound2; //Field offset: 0x38
	public Sound sound3; //Field offset: 0x40
	public Sound sound4; //Field offset: 0x48
	public Sound sound5; //Field offset: 0x50
	public int limiter; //Field offset: 0x58

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 387
	}

	public CreateSoundOnProjectileExpire() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

