namespace Assets.Scripts.Unity.Towers.Behaviors;

public class CreateSoundOnTowerPlace : TowerBehavior
{
	public CreateSoundOnTowerPlace parent; //Field offset: 0x98
	public AudioClip sound1; //Field offset: 0xA0
	public AudioClip expSound1; //Field offset: 0xA8
	public AudioClip sound2; //Field offset: 0xB0
	public AudioClip expSound2; //Field offset: 0xB8
	public AudioClip waterSound1; //Field offset: 0xC0
	public AudioClip expWaterSound1; //Field offset: 0xC8
	public AudioClip waterSound2; //Field offset: 0xD0
	public AudioClip expWaterSound2; //Field offset: 0xD8
	public AudioClip heroSound1; //Field offset: 0xE0
	public AudioClip expHeroSound1; //Field offset: 0xE8
	public AudioClip heroSound2; //Field offset: 0xF0
	public AudioClip expHeroSound2; //Field offset: 0xF8
	public AudioClip reactSound; //Field offset: 0x100
	public AudioClip expReactSound; //Field offset: 0x108
	public AudioClip reactSoundAlt; //Field offset: 0x110
	public AudioClip expReactSoundAlt; //Field offset: 0x118
	public string towerType; //Field offset: 0x120
	public string expTowerType; //Field offset: 0x128
	public string towerSkin; //Field offset: 0x130
	public string expTowerSkin; //Field offset: 0x138
	public float reactDelay; //Field offset: 0x140
	public string expReactDelay; //Field offset: 0x148

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 1594
	}

	public CreateSoundOnTowerPlace() { }

	public virtual TowerBehaviorModel get_Def() { }

}

