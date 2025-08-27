namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(TargetTrack), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TargetTrackModel : TargetSupplierModel
{
	public bool isSelectable; //Field offset: 0x38
	public float maxOffset; //Field offset: 0x3C
	public bool onlyTargetPathsWithBloons; //Field offset: 0x40

	public TargetTrackModel(string name, bool isSelectable, bool isOnSubTower, float maxOffset, bool onlyTargetPathsWithBloons) { }

	public virtual Model Clone() { }

	public virtual bool GetIsActionable() { }

	public virtual string GetName() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual bool IsSelectable() { }

}

