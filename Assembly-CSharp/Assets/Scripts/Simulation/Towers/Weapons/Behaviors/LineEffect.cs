namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class LineEffect : WeaponBehavior
{
	public LineEffectModel lineEffectModel; //Field offset: 0x68
	private float currentMagnitude; //Field offset: 0x70
	private float targetMagnitude; //Field offset: 0x74
	private Entity lineEffect; //Field offset: 0x78
	private Entity effectAtEnd; //Field offset: 0x80
	private Entity effectAtStart; //Field offset: 0x88
	private RotateToPointer rotateToPointer; //Field offset: 0x90
	private Nullable<Vector2> lastValidTarget; //Field offset: 0x98
	private LineProjectileEmission lineProjectileEmission; //Field offset: 0xA8

	public LineEffect() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateEffect() { }

}

