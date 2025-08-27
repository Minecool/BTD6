namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public abstract class ActivateTowerSupportZone : AbilityBehavior
{
	private Zoned<Tower> zone; //Field offset: 0x68
	protected int lastActive; //Field offset: 0x70
	private int towersModifiedCount; //Field offset: 0x74
	private BehaviorMutator mutator; //Field offset: 0x78
	private bool activated; //Field offset: 0x80

	public BehaviorMutator Mutator
	{
		 get { } //Length: 70
		 set { } //Length: 241
	}

	public Zoned<Tower> Zone
	{
		 get { } //Length: 5
	}

	protected ActivateTowerSupportZone() { }

	public virtual void Activate() { }

	private void AddMutator(Tower behavior) { }

	protected abstract bool CanEffectThisTower() { }

	public bool CheckBehavior(Tower tower) { }

	private void Deactivate() { }

	public BehaviorMutator get_Mutator() { }

	public Zoned<Tower> get_Zone() { }

	protected abstract float GetLifespan() { }

	protected abstract float GetRange() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsActive() { }

	protected abstract bool IsUnique() { }

	protected abstract float MaxNumTowersModified() { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	private void RemoveMutator(Tower behavior) { }

	protected void set_Mutator(BehaviorMutator value) { }

}

