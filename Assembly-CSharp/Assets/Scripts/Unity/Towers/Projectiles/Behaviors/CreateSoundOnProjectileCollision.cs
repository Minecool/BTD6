namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class CreateSoundOnProjectileCollision : ProjectileBehavior
{
	public CreateProjectileOnContact parent; //Field offset: 0x88
	public AudioClip sound1; //Field offset: 0x90
	public AudioClip expSound1; //Field offset: 0x98
	public AudioClip sound2; //Field offset: 0xA0
	public AudioClip expSound2; //Field offset: 0xA8
	public AudioClip sound3; //Field offset: 0xB0
	public AudioClip expSound3; //Field offset: 0xB8
	public AudioClip sound4; //Field offset: 0xC0
	public AudioClip expSound4; //Field offset: 0xC8
	public AudioClip sound5; //Field offset: 0xD0
	public AudioClip expSound5; //Field offset: 0xD8
	public AudioClipReference prefabSound1; //Field offset: 0xE0
	public AudioClipReference prefabSound2; //Field offset: 0xE8
	public AudioClipReference prefabSound3; //Field offset: 0xF0
	public AudioClipReference prefabSound4; //Field offset: 0xF8
	public AudioClipReference prefabSound5; //Field offset: 0x100

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 1018
	}

	public CreateSoundOnProjectileCollision() { }

	public virtual ProjectileBehaviorModel get_Def() { }

	private AudioClipReference GetAudioClipReference(AudioClip audioClip, AudioClipReference prefabSound) { }

}

