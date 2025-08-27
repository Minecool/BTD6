namespace Assets.Scripts.Data.Bloons;

[CreateAssetMenu(fileName = "New Bloon Overlay", menuName = "BTD6/Bloon Overlay", order = 1)]
public class BloonOverlayScriptable : ScriptableObject
{
	[SerializeField]
	public int displayLayer; //Field offset: 0x18
	[SerializableDictionary]
	[SerializeField]
	public SerializableDictionary<BloonOverlayClass, PrefabReference> assets; //Field offset: 0x20

	public BloonOverlayScriptable() { }

}

