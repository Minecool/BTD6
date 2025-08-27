namespace Assets.Scripts.Unity.UI_New.Teams;

public class TeamsStoreUiPanel : TeamsStoreUiPanelBase
{
	public TMP_Text thumbsUpText; //Field offset: 0xD8
	public GameObject enabledGameObject; //Field offset: 0xE0
	public GameObject isOwnedGameObject; //Field offset: 0xE8
	[CompilerGenerated]
	private bool <IsUsedForLoadout>k__BackingField; //Field offset: 0xF0

	public private bool IsUsedForLoadout
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public TeamsStoreUiPanel() { }

	[CompilerGenerated]
	public bool get_IsUsedForLoadout() { }

	[CompilerGenerated]
	private void set_IsUsedForLoadout(bool value) { }

	public void SetIsUsedForLoadout(bool isUsedForLayout) { }

	public virtual void UpdateUi() { }

}

