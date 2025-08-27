namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public class ExtraSettingsScreen : GameMenu
{
	public ExtraSettingsPanel doubleCash; //Field offset: 0x48
	public ExtraSettingsPanel bigBloons; //Field offset: 0x50
	public ExtraSettingsPanel smallBloons; //Field offset: 0x58
	public ExtraSettingsPanel bigTowers; //Field offset: 0x60
	public ExtraSettingsPanel smallTowers; //Field offset: 0x68
	public ExtraSettingsPanel smallBosses; //Field offset: 0x70
	public ExtraSettingsPanel fastTrack; //Field offset: 0x78

	public ExtraSettingsScreen() { }

	[CompilerGenerated]
	private void <Open>b__8_0() { }

	protected virtual void Awake() { }

	public virtual void Close() { }

	public virtual void Open(object menuData) { }

	private void ToggleBigBloons(bool isOn) { }

	private void ToggleBigTowers(bool isOn) { }

	private void ToggleDoubleCash(bool isOn) { }

	private void ToggleFastTrack(bool isOn) { }

	private void ToggleSmallBloons(bool isOn) { }

	private void ToggleSmallBosses(bool isOn) { }

	private void ToggleSmallTowers(bool isOn) { }

}

