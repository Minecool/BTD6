namespace Assets.Scripts.Data.MapEditor;

public class MapEditorItem : ScriptableObject
{
	public const int kUnassignedId = -1; //Field offset: 0x0
	public int batchId; //Field offset: 0x18
	public string groupId; //Field offset: 0x20
	[HideInInspector]
	public int id; //Field offset: 0x28
	[HideInInspector]
	[SerializeField]
	[ULongEnumFlags(typeof(MapEditorItemTag), True)]
	private ulong tags; //Field offset: 0x30
	[HideInInspector]
	public String[] Collections; //Field offset: 0x38

	public MapEditorItemTag Tags
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public MapEditorItem() { }

	public MapEditorItemTag get_Tags() { }

	public void set_Tags(MapEditorItemTag value) { }

}

