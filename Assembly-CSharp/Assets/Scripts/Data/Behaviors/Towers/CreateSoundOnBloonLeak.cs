namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "CreateSoundOnBloonLeak", menuName = "BTD6/Behaviors/Towers/CreateSoundOnBloonLeak")]
public class CreateSoundOnBloonLeak : TowerBehavior
{
	public Sound sound1; //Field offset: 0x30
	public Sound sound2; //Field offset: 0x38

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 198
	}

	public CreateSoundOnBloonLeak() { }

	public virtual TowerBehaviorModel get_Def() { }

}

