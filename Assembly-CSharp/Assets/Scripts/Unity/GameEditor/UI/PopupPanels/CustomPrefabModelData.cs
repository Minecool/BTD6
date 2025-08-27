namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public class CustomPrefabModelData : ScriptableObject
{
	public string prefabName; //Field offset: 0x18
	public DateTime Created; //Field offset: 0x20
	public DateTime LastModified; //Field offset: 0x28
	public GameEditorPrefabType prefabType; //Field offset: 0x30
	public string version; //Field offset: 0x38
	public SpriteReference icon; //Field offset: 0x40

	public CustomPrefabModelData() { }

}

