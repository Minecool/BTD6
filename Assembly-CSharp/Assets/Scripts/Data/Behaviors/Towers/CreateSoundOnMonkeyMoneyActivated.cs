namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "CreateSoundOnMonkeyMoneyActivated", menuName = "BTD6/Behaviors/Towers/CreateSoundOnMonkeyMoneyActivated")]
public class CreateSoundOnMonkeyMoneyActivated : TowerBehavior
{
	public Sound sound; //Field offset: 0x30

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 147
	}

	public CreateSoundOnMonkeyMoneyActivated() { }

	public virtual TowerBehaviorModel get_Def() { }

}

