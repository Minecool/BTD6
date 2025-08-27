namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class TargetDesperado : TargetCamo
{
	public TargetDesperadoModel targetDesperadoModel; //Field offset: 0x78
	public bool prioritiseMarked; //Field offset: 0x80
	private bool canTargetMarked; //Field offset: 0x81
	protected TSMInfoModel newInfoDesperado; //Field offset: 0x88

	public TargetDesperado() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void GetTsmThemeInfo(out TSMInfoModel info, out string infoId) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void LateSetSaveMetaData(Dictionary<String, String> metaData) { }

	protected virtual void OnDestroy() { }

	private void OnTowerCreated(Tower tower, TowerModel def, float upgradeCost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta) { }

	private void OnTowerDestroyed(Tower tower) { }

	private void OnTowerUpgraded(Tower tower, TowerModel def, float upgradeCost, int pathUpgraded, double cashBefore, double cashAfter, bool playUpgradeEffect, bool isParagon, bool leveledFromEndOfRoundXp, double nonUpgradeCashInvestment) { }

	public virtual void OnTsmThemeAction(string themeId, string buttonId, object info) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	protected override float SortTarget(Target target) { }

	private void UpdateCanTargetMarked(Tower ignoreTower = null) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

