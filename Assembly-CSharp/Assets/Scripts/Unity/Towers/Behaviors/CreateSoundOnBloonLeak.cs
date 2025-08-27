namespace Assets.Scripts.Unity.Towers.Behaviors;

public class CreateSoundOnBloonLeak : TowerBehavior
{
	public CreateSoundOnBloonLeak parent; //Field offset: 0x98
	public AudioClip sound1; //Field offset: 0xA0
	public AudioClip expSound1; //Field offset: 0xA8
	public AudioClip sound2; //Field offset: 0xB0
	public AudioClip expSound2; //Field offset: 0xB8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 476
	}

	public CreateSoundOnBloonLeak() { }

	public virtual TowerBehaviorModel get_Def() { }

}

