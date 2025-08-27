namespace Assets.Scripts.Models.Map;

public class CoopAreaModel : Model
{
	public readonly int areaIndex; //Field offset: 0x30
	public readonly Vector2 marker; //Field offset: 0x34
	public readonly Polygon polygon; //Field offset: 0x40
	public readonly Polygon[] holes; //Field offset: 0x48

	public CoopAreaModel(int playerIndex, Polygon polygon, Polygon[] holes, Vector2 marker) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public bool IsPointInside(Vector2 p) { }

}

