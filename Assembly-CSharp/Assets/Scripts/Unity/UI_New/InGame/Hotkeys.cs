namespace Assets.Scripts.Unity.UI_New.InGame;

public class Hotkeys : MonoBehaviour
{
	internal struct AbilityHotkeyInfo
	{
		public HotkeyButton hotkeyButton; //Field offset: 0x0
		public StackedAbilityButton stackedAbilityButton; //Field offset: 0x8

	}

	internal struct PowerHotkeyInfo
	{
		public HotkeyButton hotkeyButton; //Field offset: 0x0
		public StandardPowerButton standardPowerButton; //Field offset: 0x8

	}

	internal struct SpawnBloonHotkeyInfo
	{
		public HotkeyButton hotkeyButton; //Field offset: 0x0
		public SpawnBloonButton spawnBloonButton; //Field offset: 0x8

	}

	internal struct TowerHotkeyInfo
	{
		public HotkeyButton hotkeyButton; //Field offset: 0x0
		public ITowerPurchaseButton towerPurchaseButton; //Field offset: 0x8
		public string towerBaseId; //Field offset: 0x10

	}

	public readonly List<TowerHotkeyInfo> towerHotkeys; //Field offset: 0x20
	public readonly List<SpawnBloonHotkeyInfo> spawnBloonHotkeys; //Field offset: 0x28
	public readonly List<PowerHotkeyInfo> powerHotkeys; //Field offset: 0x30
	public readonly List<AbilityHotkeyInfo> abilityHotkeys; //Field offset: 0x38
	public HotkeyButton heroHotkey; //Field offset: 0x40
	private ITowerPurchaseButton heroButton; //Field offset: 0x48
	public HotkeyButton upgradePath1Hotkey; //Field offset: 0x50
	public HotkeyButton upgradePath2Hotkey; //Field offset: 0x58
	public HotkeyButton upgradePath3Hotkey; //Field offset: 0x60
	public HotkeyButton changeTargeting; //Field offset: 0x68
	public HotkeyButton reverseChangeTargeting; //Field offset: 0x70
	public HotkeyButton sell; //Field offset: 0x78
	public HotkeyButton copy; //Field offset: 0x80
	public HotkeyButton towerSpecial; //Field offset: 0x88
	public HotkeyButton towerSpecial2; //Field offset: 0x90
	public HotkeyButton playFastForward; //Field offset: 0x98
	public HotkeyButton sendNextRound; //Field offset: 0xA0
	public HotkeyButton pause; //Field offset: 0xA8
	public HotkeyButton clearBloons; //Field offset: 0xB0
	public HotkeyButton clearTowers; //Field offset: 0xB8
	public HotkeyButton resetCooldowns; //Field offset: 0xC0
	public HotkeyButton resetDamage; //Field offset: 0xC8
	public HotkeyButton mergeBeast; //Field offset: 0xD0
	public HotkeyButton quickRestart; //Field offset: 0xD8
	public HotkeyButton setCash; //Field offset: 0xE0
	public HotkeyButton setHealth; //Field offset: 0xE8
	public HotkeyButton selectedTowerActivatedAbility1; //Field offset: 0xF0
	public HotkeyButton selectedTowerActivatedAbility2; //Field offset: 0xF8
	public HotkeyButton selectedTowerActivatedAbility3; //Field offset: 0x100
	public HotkeyButton centeredPathPosition; //Field offset: 0x108
	public List<HotkeyButton> towerInventoryHotkeys; //Field offset: 0x110
	private int suppressHotkeys; //Field offset: 0x118
	public bool isSetup; //Field offset: 0x11C
	public HotkeyButtonSet hotKeyButtonSet; //Field offset: 0x120

	public ITowerPurchaseButton HeroButton
	{
		 get { } //Length: 5
	}

	public bool SuppressHotkeys
	{
		 get { } //Length: 11
		 set { } //Length: 19
	}

	public Hotkeys() { }

	public void AddAbilityButton(StackedAbilityButton button) { }

	public void ClearAbilityButtonHotkeys() { }

	public void ForceSetup() { }

	public ITowerPurchaseButton get_HeroButton() { }

	public bool get_SuppressHotkeys() { }

	public int GetNumberOfAbilityHotkeys() { }

	public bool IsHotkeyDown(HotkeyButton button) { }

	public bool IsHotkeyPressed(HotkeyButton button) { }

	private void LateUpdate() { }

	private void OnDestroy() { }

	public void set_SuppressHotkeys(bool value) { }

	public void Setup() { }

}

