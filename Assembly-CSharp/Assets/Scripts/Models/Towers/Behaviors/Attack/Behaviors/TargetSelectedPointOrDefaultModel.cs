namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(TargetSelectedPointOrDefault), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TargetSelectedPointOrDefaultModel : TargetSupplierModel
{
	public bool isSelectable; //Field offset: 0x38
	public PrefabReference display; //Field offset: 0x40
	public float scale; //Field offset: 0x48
	public string customName; //Field offset: 0x50
	public bool lockToInsideTowerRange; //Field offset: 0x58
	public bool startWithClosestTrackPoint; //Field offset: 0x59
	public PrefabReference displayInvalid; //Field offset: 0x60
	public bool alwaysShowTarget; //Field offset: 0x68
	public ProjectileModel projectileToExpireOnTargetChangeModel; //Field offset: 0x70
	public bool useTerrainHeight; //Field offset: 0x78

	public TargetSelectedPointOrDefaultModel(string name, bool isSelectable, bool isOnSubTower, PrefabReference display, float scale, string customName, bool lockToInsideTowerRange, bool startWithClosestTrackPoint, PrefabReference displayInvalid, bool alwaysShowTarget, ProjectileModel projectileToExpireOnTargetChangeModel, bool useTerrainHeight) { }

	public virtual bool ActionsOnCreate() { }

	public virtual Model Clone() { }

	public virtual bool GetIsActionable() { }

	public virtual string GetName() { }

	public virtual string GetTargetTypeCustomInputClass() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual bool IsSelectable() { }

}

