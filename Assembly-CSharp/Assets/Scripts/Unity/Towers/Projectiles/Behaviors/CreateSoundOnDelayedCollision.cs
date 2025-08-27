namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class CreateSoundOnDelayedCollision : ProjectileBehavior
{
	public CreateProjectileOnContact parent; //Field offset: 0x88
	public float delay; //Field offset: 0x90
	public AudioClip sound1; //Field offset: 0x98
	public AudioClip expSound1; //Field offset: 0xA0
	public AudioClip sound2; //Field offset: 0xA8
	public AudioClip expSound2; //Field offset: 0xB0
	public AudioClip sound3; //Field offset: 0xB8
	public AudioClip expSound3; //Field offset: 0xC0
	public AudioClip sound4; //Field offset: 0xC8
	public AudioClip expSound4; //Field offset: 0xD0

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 568
	}

	public CreateSoundOnDelayedCollision() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

