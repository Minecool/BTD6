namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class AlternatingEjectEffect : EjectEffect
{
	public AlternatingEjectEffectModel alternatingEjectEffectModel; //Field offset: 0x80
	private int index; //Field offset: 0x88

	public AlternatingEjectEffect() { }

	protected virtual PrefabReference GetAssetId() { }

	protected virtual float GetAssetLifespan() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

