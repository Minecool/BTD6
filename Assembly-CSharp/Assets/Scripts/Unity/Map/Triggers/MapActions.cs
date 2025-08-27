namespace Assets.Scripts.Unity.Map.Triggers;

public class MapActions : MonoBehaviour
{
	public List<MapAction> actions; //Field offset: 0x20
	public List<MapUnityAction> unityActions; //Field offset: 0x28

	public MapActions() { }

}

