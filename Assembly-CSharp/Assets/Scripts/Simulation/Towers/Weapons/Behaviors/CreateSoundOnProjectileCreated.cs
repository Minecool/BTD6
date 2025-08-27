namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class CreateSoundOnProjectileCreated : WeaponBehavior
{
	private const string SourceIce = "Ice"; //Field offset: 0x0
	private const string SourceSword = "Sword"; //Field offset: 0x0
	private const string SourcePsychicBlast = "PsychicBlast"; //Field offset: 0x0
	private const string SourceTrance = "Trance"; //Field offset: 0x0
	private const string SourceFireBurst = "FireBurst"; //Field offset: 0x0
	private const string SourceSniper = "Sniper"; //Field offset: 0x0
	public CreateSoundOnProjectileCreatedModel createSoundOnProjectileCreatedModel; //Field offset: 0x68

	public CreateSoundOnProjectileCreated() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void PlayProjectileSound() { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

