namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(FlipFollowPath), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FlipFollowPathModel : WeaponBehaviorModel
{
	public bool flipTowerDisplayX; //Field offset: 0x30
	public bool flipTowerDisplayY; //Field offset: 0x31
	public EffectModel effectOnFlip; //Field offset: 0x38

	public FlipFollowPathModel(string name, bool flipTowerDisplayX, bool flipTowerDisplayY, EffectModel effectOnFlip) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

