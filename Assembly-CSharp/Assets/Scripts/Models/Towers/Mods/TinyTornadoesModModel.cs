namespace Assets.Scripts.Models.Towers.Mods;

public class TinyTornadoesModModel : MutatorModModel
{
	[ExtendedDrawer]
	public ProjectileModel projectileModel; //Field offset: 0x30
	[SerializeReference]
	public EmissionModel emissionModel; //Field offset: 0x38
	public EmissionRotationOffProjectileDirectionModel emissionBehaviorModel; //Field offset: 0x40
	private ProjectileModel _projectileModelHeartOfOak; //Field offset: 0x48

	private ProjectileModel projectileModelHeartOfOak
	{
		private get { } //Length: 477
	}

	public TinyTornadoesModModel(string name, ProjectileModel projectileModel, EmissionModel emissionModel, EmissionRotationOffProjectileDirectionModel emissionBehaviorModel) { }

	public virtual Model Clone() { }

	private ProjectileModel get_projectileModelHeartOfOak() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

