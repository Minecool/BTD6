namespace Assets.Scripts.Unity.Display;

public class LodGroup : MonoBehaviour
{
	private const string kMarkers = "Markers"; //Field offset: 0x0
	[SerializeField]
	private bool dontAddSortingGroup; //Field offset: 0x20
	[SerializeField]
	private int orderInLayer; //Field offset: 0x24

	public LodGroup() { }

	public void Setup() { }

}

