namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class WeaponReloadPercentageOnTargetPrio : TowerBehavior
{
	public WeaponReloadPercentageOnTargetPrioModel weaponReloadPercentageModel; //Field offset: 0x68

	public WeaponReloadPercentageOnTargetPrio() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnChangeTargetPriority(TargetType targetType) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

