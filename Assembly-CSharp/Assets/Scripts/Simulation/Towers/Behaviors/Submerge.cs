namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class Submerge : TowerBehavior
{
	public SubmergeModel submergeModel; //Field offset: 0x68
	public bool isSubmerged; //Field offset: 0x70
	public float elapsedLast; //Field offset: 0x74
	private AbilityCooldownScaleSupport abilityCooldownSupport; //Field offset: 0x78
	private AbilityCooldownScaleSupport abilityCooldownSupportGlobal; //Field offset: 0x80
	private AbilityCooldownScaleSupport abilityCooldownSupportParagon; //Field offset: 0x88
	private HeroXpScaleSupport heroXpScaleSupport; //Field offset: 0x90
	private MonkeySubParagonSupport paragonSupport; //Field offset: 0x98
	private int animationStateToSet; //Field offset: 0xA0
	private bool dontMakeEffects; //Field offset: 0xA4
	private List<ObjectId> pausedAttacks; //Field offset: 0xA8
	private float currZ; //Field offset: 0xB0

	public Submerge() { }

	public virtual void Attatched() { }

	private void CreateSubmergeEffect() { }

	private void CreateUnsubmergeEffect() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnChangeTargetPriority(TargetType targetType) { }

	protected virtual void OnDestroy() { }

	public virtual void OnUpgraded(int pathUpgraded) { }

	private void PlayEmergeSound() { }

	private void PlaySubmergeSound() { }

	private void Process(int elapsed) { }

	private void SwitchToSubmergeAttacks() { }

	private void SwitchToSurfaceAttacks() { }

	private void UpdateAttackStates() { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateSupports() { }

}

