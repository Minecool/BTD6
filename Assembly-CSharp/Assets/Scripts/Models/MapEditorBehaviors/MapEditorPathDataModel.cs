namespace Assets.Scripts.Models.MapEditorBehaviors;

public class MapEditorPathDataModel : Model
{
	public const float EVENLY_SPACED_POINT_SPACING = 0.5; //Field offset: 0x0
	public const float EVENLY_SPACED_POINT_RESOLUTION = 0.5; //Field offset: 0x0
	public PathNode[] pathNodes; //Field offset: 0x30
	public int layer; //Field offset: 0x38
	public int orderInLayer; //Field offset: 0x3C
	public float pathWidth; //Field offset: 0x40

	public MapEditorPathDataModel(string name, PathNode[] pathNodes, int layer, int orderInLayer, float pathWidth) { }

	public virtual Model Clone() { }

	public PathModel GetPathModel(string pathName) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

