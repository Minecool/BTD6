//Type is in global namespace

public class GameObjectEnabler : MonoBehaviour
{
	[SerializableDictionary]
	[SerializeField]
	public SerializableDictionary<String, GameObject> keysToGameObjects; //Field offset: 0x20

	public GameObjectEnabler() { }

	public void DisableAll() { }

	public void EnableTheseDisableRest(List<String> enableKeys) { }

}

