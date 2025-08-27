namespace Assets.Scripts.Data.MapEditor;

public class MapEditorBaseMapTextureData : MapEditorItem
{
	public MaterialReference material; //Field offset: 0x40
	public SpriteReference icon; //Field offset: 0x48
	public AreaType baseAreaType; //Field offset: 0x50

	public MapEditorBaseMapTextureData() { }

	public MapTextureModel Def() { }

}

