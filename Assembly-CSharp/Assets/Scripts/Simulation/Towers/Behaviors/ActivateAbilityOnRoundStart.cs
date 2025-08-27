namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class ActivateAbilityOnRoundStart : TowerBehavior
{
	public ActivateAbilityOnRoundStartModel activateAbilityOnRoundStartModel; //Field offset: 0x68
	public Ability ability; //Field offset: 0x70
	private bool activating; //Field offset: 0x78

	public ActivateAbilityOnRoundStart() { }

	private Ability GetAbility() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void OnRoundStart(int roundNo) { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

