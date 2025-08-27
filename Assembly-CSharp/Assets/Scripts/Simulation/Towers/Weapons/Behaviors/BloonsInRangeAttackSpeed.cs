namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class BloonsInRangeAttackSpeed : WeaponBehavior
{
	public BloonsInRangeAttackSpeedModel bloonsInRangeAttackSpeedModel; //Field offset: 0x68
	private Zoned<Bloon> zone; //Field offset: 0x70
	private int bloonsInRange; //Field offset: 0x78

	public BloonsInRangeAttackSpeed() { }

	private void BloonEnter(Bloon behavior) { }

	private void BloonExit(Bloon behavior) { }

	private float GetRange() { }

	public virtual float GetRate(float rate) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

