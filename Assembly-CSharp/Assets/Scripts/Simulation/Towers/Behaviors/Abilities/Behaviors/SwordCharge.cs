namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class SwordCharge : AbilityBehavior
{
	public SwordChargeModel swordChargeModel; //Field offset: 0x68
	private List<Attack> pausedAttacks; //Field offset: 0x70
	private Emission emission; //Field offset: 0x78
	private List<Projectile> projectiles; //Field offset: 0x80
	private bool isActive; //Field offset: 0x88
	private int currentIteration; //Field offset: 0x8C
	private int initialDelayEndsAt; //Field offset: 0x90
	private int abilityEndsAt; //Field offset: 0x94
	private bool isPendingStart; //Field offset: 0x98
	public Entity effectDuringCharge; //Field offset: 0xA0
	public float destroyEffectDuringChargeAt; //Field offset: 0xA8
	private List<Projectile> emittedProjectiles; //Field offset: 0xB0
	private List<Path> pathsWithProjectiles; //Field offset: 0xB8

	public SwordCharge() { }

	public virtual void Activate() { }

	public virtual bool CanUseAbility() { }

	private void CreateBaseProjectiles() { }

	private void CreateProjectile(Path path, float distance) { }

	private void Finish() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	private void HideTower() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsActive() { }

	private void OnProjectilePathChanged(Projectile projectile, Path pathBefore, Path pathAfter) { }

	private void PlayLandingSound() { }

	private void PlaySpawnSound() { }

	private void Process(int elapsed) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	private void StartCharge() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

