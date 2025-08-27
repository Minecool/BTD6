namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class DamageModifierForBloonState : DamageModifier
{
	public DamageModifierForBloonStateModel damageModifierForBloonStateModel; //Field offset: 0x68
	private List<TimedMutator> mutatorsToGet; //Field offset: 0x70

	public DamageModifierForBloonState() { }

	public virtual float GetDamageAdditive(Bloon bloon) { }

	public virtual float GetDamageMultiplier(Bloon bloon) { }

	public virtual bool GetMaxDamageOverride() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private bool IsCheckPassed(Bloon bloon) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

