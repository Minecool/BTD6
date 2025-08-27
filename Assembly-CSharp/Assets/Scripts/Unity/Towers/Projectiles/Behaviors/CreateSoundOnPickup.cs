namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class CreateSoundOnPickup : ProjectileBehavior
{
	public CreateSoundOnPickup parent; //Field offset: 0x88
	public AudioClip sound; //Field offset: 0x90
	public AudioClip expSound; //Field offset: 0x98

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 309
	}

	public CreateSoundOnPickup() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

