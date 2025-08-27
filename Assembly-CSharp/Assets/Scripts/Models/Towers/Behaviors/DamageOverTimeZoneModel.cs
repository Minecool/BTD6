namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(DamageOverTimeZone), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DamageOverTimeZoneModel : TowerBehaviorModel
{
	public DamageOverTimeModel behaviorModel; //Field offset: 0x30
	public float range; //Field offset: 0x38
	public bool isGlobal; //Field offset: 0x3C
	public bool filterInvisible; //Field offset: 0x3D
	public bool onlyAffectOnscreen; //Field offset: 0x3E
	public string mutatorId; //Field offset: 0x40

	public DamageOverTimeZoneModel(DamageOverTimeModel behaviorModel, string name, float range, bool isGlobal, bool filterInvisible, bool onlyAffectOnscreen, string mutatorId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

