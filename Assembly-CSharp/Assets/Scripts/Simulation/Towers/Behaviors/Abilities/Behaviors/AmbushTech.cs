namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class AmbushTech : AbilityBehavior
{
	public AmbushTechModel ambushTechModel; //Field offset: 0x68
	public bool showActionButton; //Field offset: 0x70
	private Entity targetZone; //Field offset: 0x78
	private Entity display; //Field offset: 0x80
	private int bloonCount; //Field offset: 0x88
	private Vector2 selectedPosition2D; //Field offset: 0x8C

	public Entity TargetZone
	{
		 get { } //Length: 70
	}

	public AmbushTech() { }

	public virtual void Activate() { }

	public virtual void ApplyCustomInputData(CustomInputData data) { }

	public void CreateZone(Vector3 position) { }

	public void Deselect() { }

	public Entity get_TargetZone() { }

	public virtual string GetCustomInputClass(bool onAbilityActived = true) { }

	public virtual object GetCustomInputData() { }

	private float GetRadius() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public bool IsBloonInsideZone() { }

	public bool IsZoneActive() { }

	private void OnBloonEnter(Bloon bloon) { }

	private void OnBloonExit(Bloon bloon) { }

	protected virtual void OnDestroy() { }

	private void OnSelectionChanged(ISelectable selected) { }

	public virtual void PerformCustomUIAction() { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual bool ShowInAbilityMenu() { }

	private void StartDraw() { }

	private void StopDraw() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

