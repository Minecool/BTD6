namespace Assets.Scripts.Data.MapEditor;

public class MapEditorAreaTextureData : MapEditorItem
{
	public SpriteReference icon; //Field offset: 0x40
	public SpriteShapeReference spriteShape; //Field offset: 0x48
	public AreaType areaType; //Field offset: 0x50
	public bool isTowerPlacementBlockingOnly; //Field offset: 0x54
	public bool isRemoveableArea; //Field offset: 0x55

	public MapEditorAreaTextureData() { }

	public AreaTextureModel Def() { }

}

