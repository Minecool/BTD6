namespace Assets.Scripts.Unity.UI_New;

public class MapInfoPane : MonoBehaviour
{
	public Button button; //Field offset: 0x20
	public NK_TextMeshProUGUI mapNameTxt; //Field offset: 0x28
	public Image mapImg; //Field offset: 0x30
	public Material grayscaleMaterial; //Field offset: 0x38
	public GameObject coopMapDivisions; //Field offset: 0x40
	public GameObject goldenBloonVisual; //Field offset: 0x48
	public MonkeyTeamsIcon monkeyTeamsVisual; //Field offset: 0x50
	public GameObject collectionEventBonusReward; //Field offset: 0x58
	public GameObject[] collectionEventBonusRewardIcons; //Field offset: 0x60
	public GameObject medalContainer; //Field offset: 0x68
	public GameObject medals; //Field offset: 0x70
	public GameObject regularBackground; //Field offset: 0x78
	public GameObject goldBackground; //Field offset: 0x80
	public GameObject blackBackground; //Field offset: 0x88
	public SpriteReference loadingImage; //Field offset: 0x90
	private MapDetails mapInfo; //Field offset: 0x98

	public MapInfoPane() { }

	public CoopDivision GetCurrentMapDefaultCoopDivision() { }

	public void Init(MapDetails mapInfo, bool loading = false) { }

	public void SetCoopMapDivision(int playerCount, CoopDivision coopDivision = 5) { }

	public void ShowCollectionEvent(bool value) { }

	public void ShowGoldenBloon(bool value) { }

	public void ShowLocked(bool value) { }

	public void ShowMedals(bool value) { }

	public void ShowMonkeyTeams(bool value, String[] monkeyTeams) { }

}

