namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class PursuitSetting : PathSupplierHeli
{
	public static TargetType pursuitTargetType; //Field offset: 0x0
	public PursuitSettingModel pursuitSettingModel; //Field offset: 0xA8
	protected Vector2 lastDestination; //Field offset: 0xB0
	protected HeliGroupOffset heliGroupOffset; //Field offset: 0xB8
	protected HeliMovement heliMovement; //Field offset: 0xC0
	private Bloon currentTarget; //Field offset: 0xC8

	private static PursuitSetting() { }

	public PursuitSetting() { }

	public virtual void Attatched() { }

	protected override Vector2 FinalTweakToPursuitDestination(Vector2 pursuitDestination, Bloon target) { }

	public virtual string GetName() { }

	public virtual Vector2[] GetPath() { }

	public Vector2 GetPursuitDestination(Target pursuitTarget) { }

	protected override Target GetPursuitTarget() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnSwitchedTo() { }

	public void SetLastDestination(Vector2 destination) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

