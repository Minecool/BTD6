namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

internal class AddBehaviorToWeaponMutator : BehaviorMutator
{
	public AddbehaviorToWeaponModel addBehaviorToWeaponModel; //Field offset: 0x70

	public AddBehaviorToWeaponMutator(AddbehaviorToWeaponModel addBehaviorToWeaponModel) { }

	public virtual bool Mutate(Model baseModel, Model model) { }

}

