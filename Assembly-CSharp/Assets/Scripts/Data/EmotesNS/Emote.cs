namespace Assets.Scripts.Data.EmotesNS;

public class Emote : AssetChangeItem
{
	public PrefabReference uiPrefab; //Field offset: 0x20
	public PrefabReference prefab; //Field offset: 0x28
	public float displayDuration; //Field offset: 0x30
	public bool standardEmote; //Field offset: 0x34
	public bool textEmote; //Field offset: 0x35
	public string textLocString; //Field offset: 0x38
	public bool canvasEmote; //Field offset: 0x40
	public bool fullscreenEmote; //Field offset: 0x41

	public Emote() { }

}

