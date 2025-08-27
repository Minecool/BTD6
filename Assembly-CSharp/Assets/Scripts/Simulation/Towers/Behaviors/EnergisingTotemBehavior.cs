namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class EnergisingTotemBehavior : TowerBehavior
{
	public EnergisingTotemBehaviorModel energisingTotemBehaviorModel; //Field offset: 0x68
	private int roundsRemaining; //Field offset: 0x70
	public int currentEffectIndex; //Field offset: 0x74
	public Entity currentEffect; //Field offset: 0x78
	private TSMInfoModel tsmInfoModel; //Field offset: 0x80

	public int RoundsRemaining
	{
		 get { } //Length: 4
		 set { } //Length: 45
	}

	public EnergisingTotemBehavior() { }

	public bool CanRecharge() { }

	public int get_RoundsRemaining() { }

	private float GetRange() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void GetTsmThemeInfo(out TSMInfoModel info, out string infoId) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnPlace(bool playPlacementEffects) { }

	public virtual void OnRoundComplete(int roundArrayIndex) { }

	public virtual void PerformCustomUIAction() { }

	public void set_RoundsRemaining(int value) { }

	private void SetAnimationState() { }

	private void SetEffectState() { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

