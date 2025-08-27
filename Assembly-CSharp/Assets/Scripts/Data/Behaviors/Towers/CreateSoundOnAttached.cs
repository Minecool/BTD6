namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "CreateSoundOnAttached", menuName = "BTD6/Behaviors/Towers/CreateSoundOnAttached")]
public class CreateSoundOnAttached : TowerBehavior
{
	public Sound sound; //Field offset: 0x30
	public Sound altSound; //Field offset: 0x38

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 188
	}

	public CreateSoundOnAttached() { }

	public virtual TowerBehaviorModel get_Def() { }

}

