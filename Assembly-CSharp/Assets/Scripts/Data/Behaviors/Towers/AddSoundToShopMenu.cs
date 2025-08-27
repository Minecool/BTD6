namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "AddSoundToShopMenu", menuName = "BTD6/Behaviors/Towers/AddSoundToShopMenu")]
public class AddSoundToShopMenu : TowerBehavior
{
	public Sound openShopSound; //Field offset: 0x30
	public Sound heroVoiceSound1; //Field offset: 0x38
	public Sound heroVoiceSound2; //Field offset: 0x40

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 253
	}

	public AddSoundToShopMenu() { }

	public virtual TowerBehaviorModel get_Def() { }

}

