namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "CreateSoundOnEndOfRound", menuName = "BTD6/Behaviors/Towers/CreateSoundOnEndOfRound")]
public class CreateSoundOnEndOfRound : TowerBehavior
{
	public Sound sound; //Field offset: 0x30

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 147
	}

	public CreateSoundOnEndOfRound() { }

	public virtual TowerBehaviorModel get_Def() { }

}

