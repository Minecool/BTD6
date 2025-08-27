namespace Assets.Scripts.Models.MapEditorBehaviors;

public class StampTextureModel : EditorItemModel
{
	public SpriteReference sprite; //Field offset: 0x80

	public StampTextureModel(string name, int id, SpriteReference icon, SpriteReference sprite, bool isNewItem, bool isPremiumItem, ItemVarientData itemVarientData) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

