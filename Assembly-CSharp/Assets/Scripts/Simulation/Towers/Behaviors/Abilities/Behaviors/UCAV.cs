namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class UCAV : AbilityBehavior
{
	public UCAVModel ucavModel; //Field offset: 0x68
	private int activatedAt; //Field offset: 0x70
	private bool isActive; //Field offset: 0x74
	private Tower ucavTower; //Field offset: 0x78

	public UCAV() { }

	public virtual void Activate() { }

	public virtual void Attatched() { }

	public virtual bool CanUseAbility() { }

	private void Deactivate() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsActive() { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

