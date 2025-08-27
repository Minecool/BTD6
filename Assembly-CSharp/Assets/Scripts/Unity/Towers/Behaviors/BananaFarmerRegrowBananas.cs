namespace Assets.Scripts.Unity.Towers.Behaviors;

public class BananaFarmerRegrowBananas : TowerBehavior
{
	public BananaFarmerRegrowBananas parent; //Field offset: 0x98
	public Projectile regrowBananaSkin; //Field offset: 0xA0
	public Projectile expRegrowBananaSkin; //Field offset: 0xA8
	public int regrowPerBanana; //Field offset: 0xB0
	public string expRegrowPerBanana; //Field offset: 0xB8
	public GameObject selectionObject; //Field offset: 0xC0
	public GameObject expSelectionObject; //Field offset: 0xC8
	public GameObject isSelectableObject; //Field offset: 0xD0
	public GameObject expIsSelectableObject; //Field offset: 0xD8
	public AudioClip activateSound; //Field offset: 0xE0
	public AudioClip expActivateSound; //Field offset: 0xE8
	public AudioClip confirmSound; //Field offset: 0xF0
	public AudioClip expConfirmSound; //Field offset: 0xF8
	public GameObject lineDisplay; //Field offset: 0x100
	public GameObject expLineDisplay; //Field offset: 0x108
	public float lineDotOffset; //Field offset: 0x110
	public string expLineDotOffset; //Field offset: 0x118
	public float lineDotSpacing; //Field offset: 0x120
	public string expLineDotSpacing; //Field offset: 0x128
	public bool isBananaIntelligenceBureau; //Field offset: 0x130
	public string expIsBananaIntelligenceBureau; //Field offset: 0x138

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 754
	}

	public BananaFarmerRegrowBananas() { }

	public virtual TowerBehaviorModel get_Def() { }

}

