namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class LifeBasedAttackSpeed : WeaponBehavior
{
	public LifeBasedAttackSpeedModel lifeBasedAttackSpeedModel; //Field offset: 0x68
	public int calculateFrom; //Field offset: 0x70

	public LifeBasedAttackSpeed() { }

	public virtual void Attatched() { }

	public virtual float GetRate(float rate) { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

