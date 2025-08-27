namespace Assets.Scripts.Models.Towers.Behaviors.Emissions;

[Implementation(typeof(ArcEmission), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ArcEmissionModel : EmissionModel
{
	public float angle; //Field offset: 0x38
	public float offsetStart; //Field offset: 0x3C
	public float offset; //Field offset: 0x40
	public float sliceSize; //Field offset: 0x44
	public bool useProjectileRotation; //Field offset: 0x48
	public bool useAirUnitRotation; //Field offset: 0x49
	[SerializeField]
	private int Count; //Field offset: 0x4C

	public int count
	{
		 get { } //Length: 4
		 set { } //Length: 188
	}

	public ArcEmissionModel(string name, int count, float offset, float angle, EmissionBehaviorModel[] behaviors, bool useProjectileRotation, bool useAirUnitRotation) { }

	public virtual Model Clone() { }

	public int get_count() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_count(int value) { }

}

