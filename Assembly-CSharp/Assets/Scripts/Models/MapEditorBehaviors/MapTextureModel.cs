namespace Assets.Scripts.Models.MapEditorBehaviors;

public class MapTextureModel : EditorItemModel
{
	public MaterialReference material; //Field offset: 0x80
	public AreaType areaType; //Field offset: 0x88

	public MapTextureModel(string name, int id, SpriteReference icon, MaterialReference material, AreaType areaType, bool isNewItem, bool isPremiumItem, ItemVarientData itemVarientData) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

