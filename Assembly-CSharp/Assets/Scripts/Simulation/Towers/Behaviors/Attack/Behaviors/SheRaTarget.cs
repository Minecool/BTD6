namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class SheRaTarget : TargetSupplier
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public Target first; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

		internal int <GetTargetsSecond>b__0(Target t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public Target first; //Field offset: 0x10
		public Target second; //Field offset: 0x58

		public <>c__DisplayClass14_0() { }

		internal int <GetTargetsThird>b__0(Target t) { }

	}

	public SheRaTargetModel sheRaTargetModel; //Field offset: 0x68
	private int globalSheRaAttackIndex; //Field offset: 0x70

	public SheRaTarget() { }

	public virtual string GetName() { }

	public virtual Target GetTarget() { }

	private IEnumerable<Target> GetTargetsClose() { }

	public IEnumerable<Target> GetTargetsFirst() { }

	private IEnumerable<Target> GetTargetsLast() { }

	private IEnumerable<Target> GetTargetsSecond() { }

	private IEnumerable<Target> GetTargetsStrong() { }

	private IEnumerable<Target> GetTargetsThird() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnTowerCreated(Tower tower, TowerModel def, float upgradeCost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta) { }

	private void OnTowerDestroyed(Tower tower) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateSheRaAttackIndex() { }

}

