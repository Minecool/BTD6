namespace Assets.Scripts.Data.Skins;

public class SkinData : ScriptableObject
{
	public string baseTowerName; //Field offset: 0x18
	public string skinName; //Field offset: 0x20
	public string description; //Field offset: 0x28
	[SerializeField]
	private int mmCost; //Field offset: 0x30
	public SpriteReference icon; //Field offset: 0x38
	public SpriteReference iconSquare; //Field offset: 0x40
	public AudioClipReference unlockedEventSound; //Field offset: 0x48
	public AudioClipReference unlockedVoiceSound; //Field offset: 0x50
	public bool isDefaultTowerSkin; //Field offset: 0x58
	public bool isHiddenWhenLocked; //Field offset: 0x59
	public string unlockScreenName; //Field offset: 0x60
	public string iapName; //Field offset: 0x68
	public AudioClipReference unlockScreenSound; //Field offset: 0x70
	[Header("======== Hero UI Data ========")]
	[Space(10)]
	public string textMaterialId; //Field offset: 0x78
	[AssetName(typeof(Material))]
	public string fontMaterial; //Field offset: 0x80
	public PrefabReference backgroundBanner; //Field offset: 0x88
	public Color backgroundColourTintOverride; //Field offset: 0x90
	[ReorderableList("items", True)]
	[Space(10)]
	public PortraitContainer StorePortraitsContainer; //Field offset: 0xA0
	[Header("======== Asset Swaps ========")]
	[ReorderableList("items", True)]
	[Space(10)]
	public SwapPrefabContainer SwapPrefabContainer; //Field offset: 0xA8
	[ReorderableList("items", True)]
	public SwapSpriteContainer SwapSpriteContainer; //Field offset: 0xB0
	[ReorderableList("items", True)]
	public SwapAudioContainer SwapAudioContainer; //Field offset: 0xB8
	[ReorderableList("items", True)]
	public SwapOverlayContainer SwapOverlayContainer; //Field offset: 0xC0
	[ReorderableList("items", True)]
	public SwapShopSpriteContainer SwapShopSpriteContainer; //Field offset: 0xC8
	[ReorderableList("items", True)]
	public SwapShopProjectilePrefabContainer SwapShopProjectilePrefabContainer; //Field offset: 0xD0
	[ReorderableList("items", True)]
	public SwapProjectileSpriteGroupContainer SwapProjectileSpriteGroupContainer; //Field offset: 0xD8
	[ReorderableList("items", True)]
	public SwapShopPortraitContainer SwapShopPortraitContainer; //Field offset: 0xE0

	public bool IsHiddenBecauseIapsDisabled
	{
		 get { } //Length: 77
	}

	public int MmCost
	{
		 get { } //Length: 101
		 set { } //Length: 4
	}

	public List<StorePortraits> Portraits
	{
		 get { } //Length: 30
	}

	public IEnumerable<SwapAudio> SwapAudio
	{
		 get { } //Length: 30
	}

	public IEnumerable<SwapOverlay> SwapOverlay
	{
		 get { } //Length: 30
	}

	public IEnumerable<SwapPrefab> SwapPrefab
	{
		 get { } //Length: 30
	}

	public IEnumerable<SwapProjectileSpriteGroup> SwapProjectileSpriteGroup
	{
		 get { } //Length: 30
	}

	public IEnumerable<SwapShopPortrait> SwapShopPortrait
	{
		 get { } //Length: 30
	}

	public IEnumerable<SwapShopProjectilePrefab> SwapShopProjectilePrefab
	{
		 get { } //Length: 30
	}

	public IEnumerable<SwapShopSprite> SwapShopSprite
	{
		 get { } //Length: 30
	}

	public IEnumerable<SwapSprite> SwapSprite
	{
		 get { } //Length: 30
	}

	public SkinData() { }

	public bool get_IsHiddenBecauseIapsDisabled() { }

	public int get_MmCost() { }

	public List<StorePortraits> get_Portraits() { }

	public IEnumerable<SwapAudio> get_SwapAudio() { }

	public IEnumerable<SwapOverlay> get_SwapOverlay() { }

	public IEnumerable<SwapPrefab> get_SwapPrefab() { }

	public IEnumerable<SwapProjectileSpriteGroup> get_SwapProjectileSpriteGroup() { }

	public IEnumerable<SwapShopPortrait> get_SwapShopPortrait() { }

	public IEnumerable<SwapShopProjectilePrefab> get_SwapShopProjectilePrefab() { }

	public IEnumerable<SwapShopSprite> get_SwapShopSprite() { }

	public IEnumerable<SwapSprite> get_SwapSprite() { }

	public SpriteReference GetPortraitForLevel(int level) { }

	public void set_MmCost(int value) { }

}

