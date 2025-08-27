namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class LinkDisplayScaleToTowerRange : TowerBehavior
{
	public LinkDisplayScaleToTowerRangeModel modl; //Field offset: 0x68
	private bool wasPaused; //Field offset: 0x70
	private bool getAttack; //Field offset: 0x71
	private Attack attack; //Field offset: 0x78

	public LinkDisplayScaleToTowerRange() { }

	[CompilerGenerated]
	private bool <GetAttack>b__11_0(Attack attackToCheck) { }

	private void GetAttack() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnPlace(bool playPlacementEffects) { }

	public virtual void OnRangeChanged() { }

	public virtual void OnUpgraded(int pathUpgraded) { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateScale() { }

}

