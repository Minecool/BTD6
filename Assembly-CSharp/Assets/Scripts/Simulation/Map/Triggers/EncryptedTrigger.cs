namespace Assets.Scripts.Simulation.Map.Triggers;

public class EncryptedTrigger : MapTrigger
{
	private EncryptedTriggerModel encryptedTriggerModel; //Field offset: 0x80
	private Boolean[] areasWithValidTower; //Field offset: 0x88

	public EncryptedTrigger() { }

	private bool CheckStep1() { }

	public virtual void DeInit() { }

	public virtual void Init() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void OnTempleCreated(Tower tower) { }

	private void OnTowerCreated(Tower tower, TowerModel def, float upgradeCost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta) { }

	private void OnTowerSacrificed(Tower tower, Tower sacrificedTo) { }

}

