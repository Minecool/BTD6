namespace Assets.Scripts.Models.MapEditorBehaviors;

public class TrackTextureModel : EditorItemModel
{
	public SpriteShapeReference spriteShape; //Field offset: 0x80

	public TrackTextureModel(string name, int id, SpriteReference icon, SpriteShapeReference spriteShape, bool isNewItem, bool isPremiumItem, ItemVarientData itemVarientData) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

