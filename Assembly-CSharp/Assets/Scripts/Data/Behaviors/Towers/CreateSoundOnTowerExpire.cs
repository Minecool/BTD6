namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "CreateSoundOnTowerExpire", menuName = "BTD6/Behaviors/Towers/CreateSoundOnTowerExpire")]
public class CreateSoundOnTowerExpire : TowerBehavior
{
	public Sound sound; //Field offset: 0x30

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 147
	}

	public CreateSoundOnTowerExpire() { }

	public virtual TowerBehaviorModel get_Def() { }

}

