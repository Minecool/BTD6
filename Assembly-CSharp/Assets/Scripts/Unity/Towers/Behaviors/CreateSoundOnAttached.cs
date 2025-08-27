namespace Assets.Scripts.Unity.Towers.Behaviors;

public class CreateSoundOnAttached : TowerBehavior
{
	public CreateSoundOnAttached parent; //Field offset: 0x98
	public AudioClip sound; //Field offset: 0xA0
	public AudioClip expSound; //Field offset: 0xA8
	public AudioClip altSound; //Field offset: 0xB0
	public AudioClip expAltSound; //Field offset: 0xB8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 467
	}

	public CreateSoundOnAttached() { }

	public virtual TowerBehaviorModel get_Def() { }

}

