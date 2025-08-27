namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(RectangleFootprint), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RectangleFootprintModel : FootprintModel
{
	public float xWidth; //Field offset: 0x38
	public float yWidth; //Field offset: 0x3C

	public RectangleFootprintModel(string name, float xWidth, float yWidth, bool doesntBlockTowerPlacement, bool ignoresPlacementCheck, bool ignoresTowerOverlap) { }

	public virtual Model Clone() { }

}

