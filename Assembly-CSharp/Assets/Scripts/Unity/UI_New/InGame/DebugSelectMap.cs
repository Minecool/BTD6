namespace Assets.Scripts.Unity.UI_New.InGame;

public class DebugSelectMap : MonoBehaviour
{
	private bool isLoaded; //Field offset: 0x20
	public GameObject baseButton; //Field offset: 0x28
	public Color beginner; //Field offset: 0x30
	public Color intermediate; //Field offset: 0x40
	public Color advanced; //Field offset: 0x50
	public Color expert; //Field offset: 0x60

	public bool IsLoaded
	{
		 get { } //Length: 5
	}

	public DebugSelectMap() { }

	public bool get_IsLoaded() { }

	public void LoadMaps(MapDetails[] maps, Transform parent, Action<MapDetails> onClicked) { }

}

