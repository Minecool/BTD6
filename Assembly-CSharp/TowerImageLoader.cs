//Type is in global namespace

public class TowerImageLoader : MonoBehaviour
{
	public Material grayscaleMaterial; //Field offset: 0x20
	public Image image; //Field offset: 0x28
	public Image bg; //Field offset: 0x30
	[CompilerGenerated]
	private TowerModel <TowerModel>k__BackingField; //Field offset: 0x38

	public private TowerModel TowerModel
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public TowerImageLoader() { }

	[CompilerGenerated]
	public TowerModel get_TowerModel() { }

	private SpriteReference GetBgSprite(bool useRoundBg) { }

	public void Load(string towerID, bool instaTower, bool dontShowLockedState = false, bool showTowerSetBackground = true, bool useRoundBg = false, Int32[] instaTowerTiers = null, bool useLevel1Portrait = false) { }

	public void LoadHero(string heroOrHeroskin) { }

	[CompilerGenerated]
	private void set_TowerModel(TowerModel value) { }

}

