namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class LimitByHauntSpell : WeaponBehavior
{
	private LimitByHauntSpellModel limitByHauntModel; //Field offset: 0x68

	public LimitByHauntSpell() { }

	public virtual bool CanFire() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

