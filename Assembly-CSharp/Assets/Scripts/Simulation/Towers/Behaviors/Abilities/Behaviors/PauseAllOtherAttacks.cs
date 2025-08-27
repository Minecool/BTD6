namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class PauseAllOtherAttacks : AbilityBehavior
{
	public PauseAllOtherAttacksModel pauseAllOtherAttacksModel; //Field offset: 0x68
	public bool checkNewAttacks; //Field offset: 0x70
	private int createdAt; //Field offset: 0x74
	private bool activatedAttackProcessAdded; //Field offset: 0x78
	private List<RootBehavior> pausedAttacks; //Field offset: 0x80

	public PauseAllOtherAttacks() { }

	public virtual void Activate() { }

	private void AddProcess() { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsActive() { }

	public void OnDefeatScreen() { }

	protected virtual void OnDestroy() { }

	private void OnRoundEnd(int round) { }

	private void Process(int elapsed) { }

	private void RemoveProcess() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

