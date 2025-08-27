namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(FootprintZone), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FootprintZoneModel : SupportModel
{
	public float footprintReduction; //Field offset: 0x60
	public string mutatorId; //Field offset: 0x68
	public bool isUnique; //Field offset: 0x70

	public FootprintZoneModel(string name, bool isUnique, float footprintReduction, string mutatorId, TowerFilterModel[] filters) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

