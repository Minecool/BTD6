namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class NecromancerZone : TowerBehavior
{
	private static List<NecroData> necroEmissionsInRange; //Field offset: 0x0
	public NecromancerZoneModel necromancerZoneModel; //Field offset: 0x68
	private Zoned<Bloon> zone; //Field offset: 0x70
	private SimNecromancerGraveyardManager graveyardManager; //Field offset: 0x78
	private TSMInfoModel tsmInfoModel; //Field offset: 0x80

	public NecromancerZone() { }

	private int AssignRbeToTower(NecroData towerData, int numDegrades) { }

	private void BloonEnter(Bloon bloon) { }

	private void BloonExit(Bloon bloon) { }

	public float GetRange() { }

	public virtual void GetTsmThemeInfo(out TSMInfoModel info, out string infoId) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void OnBloonDegrade(Bloon bloon, DamageResult damageResult) { }

	protected virtual void OnDestroy() { }

	public virtual void OnRoundComplete(int roundArrayIndex) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

