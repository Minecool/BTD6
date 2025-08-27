namespace Assets.Scripts.Simulation.Powers;

public class DartTime : Power
{
	private DartTimeModel dartTimeModel; //Field offset: 0x18
	private int endFrame; //Field offset: 0x20

	public DartTime() { }

	public virtual void Activate(Vector2 location, PowerBehaviorModel model, int inputId) { }

	public void BloonSpawned(Bloon bloon) { }

	public virtual bool CheckLocation(Vector2 location, PowerBehaviorModel model) { }

	private void Deactivate() { }

	private void Process(int elapsed) { }

	public void TowerCreated(Tower tower, TowerModel def, float upgradeCost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta) { }

}

