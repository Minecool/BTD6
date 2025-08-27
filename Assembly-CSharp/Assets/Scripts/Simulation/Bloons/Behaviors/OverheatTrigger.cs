namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class OverheatTrigger : BloonBehaviorTrigger
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static GetRangeDelegate <>9__18_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal float <InitialiseZone>b__18_0() { }

	}

	public OverheatTriggerModel overheatModel; //Field offset: 0x70
	public float heatLevel; //Field offset: 0x78
	public bool heatEffectActive; //Field offset: 0x7C
	public bool heatInCooldown; //Field offset: 0x7D
	public int lastAddedHeatAt; //Field offset: 0x80
	private Zoned<Tower> zone; //Field offset: 0x88

	public OverheatTrigger() { }

	public void AddHeat(float amount, bool forceAdd = false) { }

	private void DestroyZone() { }

	public virtual float GetModifiedDamage(BloonProperties projectileImmuneProperties, BloonProperties originalProjectileImmuneProperties, float modifiedDamage, Projectile projectile) { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void InitialiseZone() { }

	protected virtual void OnDestroy() { }

	public virtual void OnImmuneFromHit(bool destroyedTheProjectile) { }

	public virtual void OnSpawn() { }

	private void PerformHeatActions() { }

	private void PlaySound() { }

	private void Process(int elapsed) { }

	private void ReduceHeat(float amount) { }

	private void RevertHeatActions() { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	private void TowerEnter(Tower tower) { }

	private void TowerExit(Tower tower) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

