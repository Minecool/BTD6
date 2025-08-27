namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class ActivateAttack : AbilityBehavior
{
	public ActivateAttackModel activateAttackModel; //Field offset: 0x68
	private List<RootBehavior> attacks; //Field offset: 0x70
	private List<RootBehavior> pausedAttacks; //Field offset: 0x78
	private int createdAt; //Field offset: 0x80
	private bool activatedAttackProcessAdded; //Field offset: 0x84
	private bool checkNewAttacks; //Field offset: 0x85

	public List<RootBehavior> Attacks
	{
		 get { } //Length: 5
	}

	public ActivateAttack() { }

	public virtual void Activate() { }

	private void AddProcess() { }

	public virtual void Attatched() { }

	public virtual bool CanUseAbility() { }

	public List<RootBehavior> get_Attacks() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsActive() { }

	public void OnDefeatScreen() { }

	protected virtual void OnDestroy() { }

	private void OnRoundEnd(int round) { }

	private void Process(int elapsed) { }

	public void RemoveProcess() { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

