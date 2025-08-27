namespace Assets.Scripts.Models.Towers.Behaviors.Attack;

[Implementation(typeof(AttackAirUnit), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AttackAirUnitModel : AttackModel
{
	public DisplayModel displayAirUnitModel; //Field offset: 0x70

	public AttackAirUnitModel(string name, WeaponModel[] weapons, float range, Model[] behaviors, TargetSupplierModel targetProvider, float offsetX, float offsetY, float offsetZ, bool attackThroughWalls, bool fireWithoutTarget, int framesBeforeRetarget, bool addsToSharedGrid, float sharedGridRange, DisplayModel displayAirUnitModel) { }

	public virtual Model Clone() { }

}

