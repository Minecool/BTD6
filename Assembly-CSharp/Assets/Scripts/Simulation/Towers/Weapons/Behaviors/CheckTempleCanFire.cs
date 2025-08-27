namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class CheckTempleCanFire : WeaponBehavior
{
	public CheckTempleCanFireModel checkTempleCanFireModel; //Field offset: 0x68
	private MonkeyTemple monkeyTemple; //Field offset: 0x70
	private Tower parentTower; //Field offset: 0x78

	private Entity ParentEntity
	{
		private get { } //Length: 63
	}

	public CheckTempleCanFire() { }

	public virtual bool CanFire() { }

	private Entity get_ParentEntity() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

