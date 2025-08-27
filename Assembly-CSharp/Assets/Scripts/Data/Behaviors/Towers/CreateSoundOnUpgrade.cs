namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "CreateSoundOnUpgrade", menuName = "BTD6/Behaviors/Towers/CreateSoundOnUpgrade")]
public class CreateSoundOnUpgrade : TowerBehavior
{
	public Sound sound; //Field offset: 0x30
	public Sound sound1; //Field offset: 0x38
	public Sound sound2; //Field offset: 0x40
	public Sound sound3; //Field offset: 0x48
	public Sound sound4; //Field offset: 0x50
	public Sound sound5; //Field offset: 0x58
	public Sound sound6; //Field offset: 0x60
	public Sound sound7; //Field offset: 0x68
	public Sound sound8; //Field offset: 0x70

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 579
	}

	public CreateSoundOnUpgrade() { }

	public virtual TowerBehaviorModel get_Def() { }

}

