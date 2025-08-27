namespace Assets.Scripts.Unity.Towers.Behaviors;

public class CreateSoundOnMonkeyMoneyActivated : TowerBehavior
{
	public CreateSoundOnMonkeyMoneyActivated parent; //Field offset: 0x98
	public AudioClip sound; //Field offset: 0xA0
	public AudioClip expSound; //Field offset: 0xA8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 309
	}

	public CreateSoundOnMonkeyMoneyActivated() { }

	public virtual TowerBehaviorModel get_Def() { }

}

