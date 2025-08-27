namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class CreateSoundOnProjectileCreated : WeaponBehavior
{
	public CreateSoundOnProjectileCreated parent; //Field offset: 0x90
	public AudioClip sound1; //Field offset: 0x98
	public AudioClip expSound1; //Field offset: 0xA0
	public AudioClip sound2; //Field offset: 0xA8
	public AudioClip expSound2; //Field offset: 0xB0
	public AudioClip sound3; //Field offset: 0xB8
	public AudioClip expSound3; //Field offset: 0xC0
	public AudioClip sound4; //Field offset: 0xC8
	public AudioClip expSound4; //Field offset: 0xD0
	public AudioClip sound5; //Field offset: 0xD8
	public AudioClip expSound5; //Field offset: 0xE0
	public string type; //Field offset: 0xE8
	public string expType; //Field offset: 0xF0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 992
	}

	public CreateSoundOnProjectileCreated() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

