namespace Assets.Scripts.Unity.UI_New.Odyssey;

public class OdysseyWorldMenu : WorldMenu
{
	private int ISLAND_CAMERA_OFFSET; //Field offset: 0x58
	public GameObject objFullScreenClouds; //Field offset: 0x60
	public OdysseyWorldConfig OdysseyConfig; //Field offset: 0x68
	private Dictionary<Int32, OdysseyIslandInteractable> islands; //Field offset: 0x70
	private Dictionary<Int32, OdysseyEnvironmentInteractable> enviroments; //Field offset: 0x78
	private OdysseyEventScreen odysseyEventScreen; //Field offset: 0x80

	public OdysseyEventScreen OdysseyEventScreen
	{
		 set { } //Length: 8
	}

	public OdysseyWorldMenu() { }

	private void Awake() { }

	public virtual void Init() { }

	private void IslandSelected(OdysseyIslandInteractable island, bool useAdditionalCameraOffset = true) { }

	public void On2dWorldClickedTransitionToIsland(int islandIndex, bool useAdditionalCameraOffset = true) { }

	protected virtual void OnTouchedEnvironment(TouchableObject o) { }

	public void set_OdysseyEventScreen(OdysseyEventScreen value) { }

	public virtual void SetMaxPostiveXWorldCameraValue(int difficultyState) { }

}

