namespace Assets.Scripts.Unity.Towers.Behaviors;

public class CreateSoundOnBloonDestroyed : TowerBehavior
{
	public CreateSoundOnBloonDestroyed parent; //Field offset: 0x98
	public AudioClip sound1; //Field offset: 0xA0
	public AudioClip expSound1; //Field offset: 0xA8
	public AudioClip sound2; //Field offset: 0xB0
	public AudioClip expSound2; //Field offset: 0xB8
	public string bloonType; //Field offset: 0xC0
	public string expbloonType; //Field offset: 0xC8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 489
	}

	public CreateSoundOnBloonDestroyed() { }

	public virtual TowerBehaviorModel get_Def() { }

}

