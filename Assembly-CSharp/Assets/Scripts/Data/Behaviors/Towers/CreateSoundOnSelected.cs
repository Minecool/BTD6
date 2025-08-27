namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "CreateSoundOnSelected", menuName = "BTD6/Behaviors/Towers/CreateSoundOnSelected")]
public class CreateSoundOnSelected : TowerBehavior
{
	public Sound sound1; //Field offset: 0x30
	public Sound sound2; //Field offset: 0x38
	public Sound sound3; //Field offset: 0x40
	public Sound sound4; //Field offset: 0x48
	public Sound sound5; //Field offset: 0x50
	public Sound sound6; //Field offset: 0x58
	public Sound altSound1; //Field offset: 0x60
	public Sound altSound2; //Field offset: 0x68

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 523
	}

	public CreateSoundOnSelected() { }

	public virtual TowerBehaviorModel get_Def() { }

}

