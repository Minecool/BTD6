namespace Assets.Scripts.Models.MapEditorBehaviors;

public class AreaTextureModel : EditorItemModel
{
	public SpriteShapeReference spriteShape; //Field offset: 0x80
	public AreaType areaType; //Field offset: 0x88
	public bool isTowerPlacementBlockingOnly; //Field offset: 0x8C
	public bool isRemoveableArea; //Field offset: 0x8D

	public AreaTextureModel(string name, int id, SpriteReference icon, SpriteShapeReference spriteShape, AreaType areaType, bool isTowerPlacementBlockingOnly, bool isNewItem, bool isPremiumItem, ItemVarientData itemVarientData, bool isRemoveableArea) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

