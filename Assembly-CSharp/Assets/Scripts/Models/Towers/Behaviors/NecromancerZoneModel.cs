namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(NecromancerZone), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class NecromancerZoneModel : TowerBehaviorModel
{
	public AttackModel attackUsedForRangeModel; //Field offset: 0x30

	public NecromancerZoneModel(string name, AttackModel attackUsedForRangeModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

