namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "CreateSoundOnTowerPlace", menuName = "BTD6/Behaviors/Towers/CreateSoundOnTowerPlace")]
public class CreateSoundOnTowerPlace : TowerBehavior
{
	public Sound sound1; //Field offset: 0x30
	public Sound sound2; //Field offset: 0x38
	public Sound waterSound1; //Field offset: 0x40
	public Sound waterSound2; //Field offset: 0x48
	public Sound heroSound1; //Field offset: 0x50
	public Sound heroSound2; //Field offset: 0x58
	public Sound reactSound; //Field offset: 0x60
	public Sound reactSoundAlt; //Field offset: 0x68
	public string towerType; //Field offset: 0x70
	public string towerSkin; //Field offset: 0x78
	public float reactDelay; //Field offset: 0x80

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 617
	}

	public CreateSoundOnTowerPlace() { }

	public virtual TowerBehaviorModel get_Def() { }

}

