namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class SubmergedTarget : TargetSupplier
{
	public SubmergedTargetModel submergedTargetModel; //Field offset: 0x68
	private TSMInfoModel tsmInfoModel; //Field offset: 0x70
	private string previousTargetPrio; //Field offset: 0x78

	public SubmergedTarget() { }

	public virtual string GetName() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void GetTsmThemeInfo(out TSMInfoModel info, out string infoId) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnTsmThemeAction(string themeId, string buttonId, object info) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

