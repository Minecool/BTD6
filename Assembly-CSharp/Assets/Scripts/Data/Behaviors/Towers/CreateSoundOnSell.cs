namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "CreateSoundOnSell", menuName = "BTD6/Behaviors/Towers/CreateSoundOnSell")]
public class CreateSoundOnSell : TowerBehavior
{
	public Sound sound; //Field offset: 0x30

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 147
	}

	public CreateSoundOnSell() { }

	public virtual TowerBehaviorModel get_Def() { }

}

