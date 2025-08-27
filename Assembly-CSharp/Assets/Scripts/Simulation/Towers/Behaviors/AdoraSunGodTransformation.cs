namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class AdoraSunGodTransformation : TowerBehavior
{
	public AdoraSunGodTransformationModel adoraSunGodTransformationModel; //Field offset: 0x68
	private int lastTransformed; //Field offset: 0x70
	private bool isTransformed; //Field offset: 0x74
	private bool isDark; //Field offset: 0x75

	public bool IsDark
	{
		 get { } //Length: 5
	}

	public bool IsTransformed
	{
		 get { } //Length: 5
	}

	public AdoraSunGodTransformation() { }

	public void ApplyDark(bool fromSave) { }

	public bool CanFire() { }

	public void CheckDark(Tower darkTrueSunGod) { }

	private bool CheckTransformation(Tower towerToCheck) { }

	public bool get_IsDark() { }

	public bool get_IsTransformed() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnTowerCreated(Tower createdTower, TowerModel def, float upgradeCost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta) { }

	private void OnTowerUpgraded(Tower upgradedTower, TowerModel towerModel, float upgradeCost, int pathUpgraded, double cashBefore, double cashAfter, bool playUpgradeEffect, bool isParagon, bool leveledFromEndOfRoundXp, double nonUpgradeCashInvestment) { }

	private void PlaySound() { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public void Transform(bool fromSave) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

