namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class TheBlazingSun : WeaponBehavior
{
	public TheBlazingSunModel theBlazingSunModel; //Field offset: 0x68
	private int currentStacks; //Field offset: 0x70
	private int lastEmissionAt; //Field offset: 0x74
	private Emission emission; //Field offset: 0x78

	public TheBlazingSun() { }

	private bool CanSetBloonsOnFire() { }

	public virtual void EmissionStarted() { }

	public virtual float GetRate(float rate) { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void OnBloonDestroy(Projectile projectile, Bloon bloon, Tower poppedBy, DamageResult damageResult) { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	private void SpawnEffect(Projectile projectile) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

