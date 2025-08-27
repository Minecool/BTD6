namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class MorphTower : AbilityBehavior
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public Tower destroyedTower; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal bool <OnTowerDestroyed>b__0(Tower morphedTower) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public Tower towerToCheck; //Field offset: 0x10

		public <>c__DisplayClass8_0() { }

		internal bool <Activate>b__0(string mutatorToIgnore) { }

	}

	public MorphTowerModel morphTowerModel; //Field offset: 0x68
	public int createEffectEndAt; //Field offset: 0x70
	public List<Tower> morphedTowers; //Field offset: 0x78
	public AirUnit airUnit; //Field offset: 0x80

	public MorphTower() { }

	public virtual void Activate() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void OnDefeatScreen() { }

	protected virtual void OnDestroy() { }

	private void OnTowerDestroyed(Tower destroyedTower) { }

	private void Process(int elapsed) { }

	private void SpawnEffectOnTower(EffectModel effectModel, Vector3 position) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

