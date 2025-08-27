namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "CreateSoundOnBloonDestroyed", menuName = "BTD6/Behaviors/Towers/CreateSoundOnBloonDestroyed")]
public class CreateSoundOnBloonDestroyed : TowerBehavior
{
	public Sound sound1; //Field offset: 0x30
	public Sound sound2; //Field offset: 0x38
	public string bloonType; //Field offset: 0x40

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 221
	}

	public CreateSoundOnBloonDestroyed() { }

	public virtual TowerBehaviorModel get_Def() { }

}

