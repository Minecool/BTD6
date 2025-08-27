namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(TargetTrackOrDefault), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TargetTrackOrDefaultModel : TargetSupplierModel
{
	public float radius; //Field offset: 0x38
	public bool isSelectable; //Field offset: 0x3C
	public bool useTowerRange; //Field offset: 0x3D
	public bool forceTargetTrack; //Field offset: 0x3E
	public bool useClosestTrack; //Field offset: 0x3F
	public float maxTrackOffset; //Field offset: 0x40

	public TargetTrackOrDefaultModel(string name, float radius, bool isSelectable, bool useTowerRange, bool forceTargetTrack, bool isOnSubTower, bool useClosestTrack, float maxTrackOffset) { }

	public virtual Model Clone() { }

	public virtual bool GetIsActionable() { }

	public virtual string GetName() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual bool IsSelectable() { }

}

