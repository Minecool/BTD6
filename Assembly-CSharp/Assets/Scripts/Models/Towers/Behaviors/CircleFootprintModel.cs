namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(CircleFootprint), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CircleFootprintModel : FootprintModel
{
	public float radius; //Field offset: 0x38

	public CircleFootprintModel(string name, float radius, bool doesntBlockTowerPlacement, bool ignoresPlacementCheck, bool ignoresTowerOverlap) { }

	public virtual Model Clone() { }

}

