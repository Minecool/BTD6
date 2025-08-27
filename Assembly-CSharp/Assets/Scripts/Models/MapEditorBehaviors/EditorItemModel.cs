namespace Assets.Scripts.Models.MapEditorBehaviors;

public class EditorItemModel : EntityModel
{
	public int id; //Field offset: 0x60
	public bool isNewItem; //Field offset: 0x64
	public bool isPremiumItem; //Field offset: 0x65
	public bool isGroupedWithVarients; //Field offset: 0x66
	public ItemVarientData itemVarientData; //Field offset: 0x68
	public SpriteReference icon; //Field offset: 0x78

	public bool IsPrimaryVarient
	{
		 get { } //Length: 5
	}

	public bool IsVarient
	{
		 get { } //Length: 22
	}

	public int NumVarients
	{
		 get { } //Length: 4
	}

	public EditorItemModel(string baseId, int id, SpriteReference icon, bool isNewItem, bool isPremiumItem, ItemVarientData itemVarientData, PrefabReference display = null, Model[] behaviors = null, float radius = 5) { }

	public virtual Model Clone() { }

	public bool get_IsPrimaryVarient() { }

	public bool get_IsVarient() { }

	public int get_NumVarients() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

