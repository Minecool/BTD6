namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class PierceFromLivesGained : WeaponBehavior
{
	public PierceFromLivesGainedModel pierceFromLivesGainedModel; //Field offset: 0x68
	public int calculateFrom; //Field offset: 0x70
	public float leftoverPierce; //Field offset: 0x74
	private bool checkForCalculateFrom; //Field offset: 0x78

	public PierceFromLivesGained() { }

	public virtual void Attatched() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

