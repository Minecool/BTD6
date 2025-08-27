namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class FollowTouchSetting : PathSupplierHeli
{
	public FollowTouchSettingModel followTouchSettingModel; //Field offset: 0xA8
	private Vector2 currentPosition; //Field offset: 0xB0
	private HeliGroupOffset heliGroupOffset; //Field offset: 0xB8

	public FollowTouchSetting() { }

	public virtual void Attatched() { }

	public virtual string GetName() { }

	public virtual Vector2[] GetPath() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void OnSwitchedTo() { }

	private void Process(int frame) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

