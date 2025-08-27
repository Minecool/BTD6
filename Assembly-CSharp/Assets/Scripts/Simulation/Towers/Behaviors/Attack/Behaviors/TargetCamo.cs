namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class TargetCamo : TargetSupplier
{
	public bool prioritiseCamo; //Field offset: 0x68
	protected TSMInfoModel newInfo; //Field offset: 0x70

	public TargetCamo() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void GetTsmThemeInfo(out TSMInfoModel info, out string infoId) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void OnTsmThemeAction(string themeId, string buttonId, object info) { }

	protected static int OrderByCamo(Target target) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

}

