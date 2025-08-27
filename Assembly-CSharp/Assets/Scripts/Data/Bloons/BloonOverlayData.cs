namespace Assets.Scripts.Data.Bloons;

public class BloonOverlayData : ScriptableObject
{
	[SerializableDictionary]
	[SerializeField]
	public SerializableDictionary<String, BloonOverlayScriptable> overlayTypes; //Field offset: 0x18

	public BloonOverlayData() { }

}

