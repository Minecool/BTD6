namespace Assets.Scripts.Unity.UI_New.Teams;

public class TeamBrowserAdvancedPanel : MonoBehaviour
{
	[SerializeField]
	private Toggle hideFullTeamsTgl; //Field offset: 0x20
	[SerializeField]
	private Toggle hidePrivateTeamsTgl; //Field offset: 0x28
	[SerializeField]
	private Toggle hideAutoJoinDisabledTeamsTgl; //Field offset: 0x30
	[SerializeField]
	private Slider minMembersSlider; //Field offset: 0x38
	[SerializeField]
	private Slider maxMembersSlider; //Field offset: 0x40
	[SerializeField]
	private NK_TextMeshProUGUI advMinMemberCountTxt; //Field offset: 0x48
	[SerializeField]
	private NK_TextMeshProUGUI advMaxMemberCountTxt; //Field offset: 0x50
	[SerializeField]
	private Button resetButton; //Field offset: 0x58
	[SerializeField]
	private Button applyButton; //Field offset: 0x60
	[SerializeField]
	private Lightbox backgroundButton; //Field offset: 0x68
	[SerializeField]
	private TMP_Dropdown stanceFilterDropdown; //Field offset: 0x70
	private Action ApplySearchSettings; //Field offset: 0x78
	private GuildSearchFilters searchFilters; //Field offset: 0x80
	private bool hasPendingChanges; //Field offset: 0x88

	public bool IsActive
	{
		 get { } //Length: 113
	}

	public bool IsDefaultSearch
	{
		 get { } //Length: 224
	}

	public int MaxTeamSizeFilter
	{
		 get { } //Length: 46
	}

	public int MinTeamSizeFilter
	{
		 get { } //Length: 46
	}

	public TeamBrowserAdvancedPanel() { }

	public void Bind(GuildSearchFilters searchFilters, Action onClickAdvSearch) { }

	public void CloseAndSearch() { }

	public bool get_IsActive() { }

	public bool get_IsDefaultSearch() { }

	public int get_MaxTeamSizeFilter() { }

	public int get_MinTeamSizeFilter() { }

	public void Hide() { }

	private void HideAutoJoinChanged(bool isOn) { }

	private void HideFullTeamsChanged(bool isOn) { }

	private void HidePrivateTeamChanged(bool isOn) { }

	private void MaxMemberCountChanged(float value) { }

	private void MinMemberCountChanged(float value) { }

	private void OnClickResetSearchSettings() { }

	private void OnEnable() { }

	public void Open() { }

	private void StanceFilterChanged(int value) { }

}

