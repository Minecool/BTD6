namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(NecromancerTargetTrackWithinRange), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class NecromancerTargetTrackWithinRangeModel : TargetTrackModel
{
	public PrefabReference display; //Field offset: 0x48
	public PrefabReference displayInvalid; //Field offset: 0x50

	public NecromancerTargetTrackWithinRangeModel(string name, bool isSelectable, bool isOnSubTower, PrefabReference display, PrefabReference displayInvalid) { }

	public virtual Model Clone() { }

	public virtual bool GetIsActionable() { }

	public virtual string GetName() { }

	public virtual string GetTargetTypeCustomInputClass() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

