namespace Assets.Scripts.Unity.Towers.Behaviors;

public class CreateSoundOnBloonEnterTrack : TowerBehavior
{
	public CreateSoundOnBloonEnterTrack parent; //Field offset: 0x98
	public AudioClip enterMoabSound; //Field offset: 0xA0
	public AudioClip expEnterMoabSound; //Field offset: 0xA8
	public AudioClip enterBfbSound; //Field offset: 0xB0
	public AudioClip expEnterBfbSound; //Field offset: 0xB8
	public AudioClip enterDdtSound; //Field offset: 0xC0
	public AudioClip expEnterDdtSound; //Field offset: 0xC8
	public AudioClip enterZomgSound; //Field offset: 0xD0
	public AudioClip expEnterZomgSound; //Field offset: 0xD8
	public AudioClip enterBadSound; //Field offset: 0xE0
	public AudioClip expEnterBadSound; //Field offset: 0xE8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 967
	}

	public CreateSoundOnBloonEnterTrack() { }

	public virtual TowerBehaviorModel get_Def() { }

}

