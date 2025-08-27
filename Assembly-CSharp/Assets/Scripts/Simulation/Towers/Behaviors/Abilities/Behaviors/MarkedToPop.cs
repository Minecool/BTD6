namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class MarkedToPop : AbilityBehavior
{
	private enum Phase
	{
		INACTIVE = 0,
		MARKING = 1,
		EXECUTING = 2,
	}

	public MarkedToPopModel markedToPopModel; //Field offset: 0x68
	private Attack markingAttack; //Field offset: 0x70
	private Attack executionAttack; //Field offset: 0x78
	private FilterMarkedToPop markingAttackFilter; //Field offset: 0x80
	private FilterMarkedToPop executionAttackFilter; //Field offset: 0x88
	private Weapon markingWeapon; //Field offset: 0x90
	private Weapon executionWeapon; //Field offset: 0x98
	private int executionStartedAt; //Field offset: 0xA0
	private Phase phase; //Field offset: 0xA4

	public MarkedToPop() { }

	public virtual void Activate() { }

	public virtual bool CanUseAbility() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsActive() { }

	public virtual void LateSetSaveMetaData(Dictionary<String, String> metaData) { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	private void SetPauseOnOtherAttacks(bool pause) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

