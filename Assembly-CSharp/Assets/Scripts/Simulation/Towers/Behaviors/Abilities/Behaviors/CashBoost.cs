namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class CashBoost : AbilityBehavior
{
	public CashBoostModel cashBoostModel; //Field offset: 0x68
	private CashBoostMutator mutator; //Field offset: 0x70
	private Zoned<Tower> zone; //Field offset: 0x78
	private int timeActivated; //Field offset: 0x80

	public CashBoost() { }

	public virtual void Activate() { }

	public virtual bool CanUseAbility() { }

	public float GetRange() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void Process(int elapsed) { }

	private void TowerEnter(Tower tower) { }

	private void TowerExit(Tower tower) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

