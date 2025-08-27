namespace Assets.Scripts.Simulation.Bloons;

public class BloonDegradeStep
{
	public Simulation sim; //Field offset: 0x10
	public BloonModel bloonModel; //Field offset: 0x18
	public int maxHealth; //Field offset: 0x20
	public int totalHealth; //Field offset: 0x24
	public int totalLayers; //Field offset: 0x28
	public int totalDegrades; //Field offset: 0x2C
	public int effectiveHealth; //Field offset: 0x30
	private Dictionary<Int32, List`1<BloonDegradeStep>> connections; //Field offset: 0x38
	private Dictionary<Int32, List`1<BloonDegradeStep>> stepsForLayerIndex; //Field offset: 0x40
	private Dictionary<Int32, Int32> degradesForTotalHealth; //Field offset: 0x48
	private readonly BloonDegradeStepper bloonDegradeStepper; //Field offset: 0x50
	private List<BloonDegradeStep> nextChildSteps; //Field offset: 0x58
	private List<BloonDegradeStep> childSteps; //Field offset: 0x60

	public BloonDegradeStep(Simulation sim, BloonDegradeStepper bloonDegradeStepper, BloonModel bloonModel, int maxHealth, int totalHealth, int totalLayers, int totalDegrades) { }

	public void ClearConnections() { }

	private List<BloonDegradeStep> ConnectSteps(int currentTotalHealth, int damage, int currentLayerHealth) { }

	public int GetEffectiveHealth() { }

	public List<BloonDegradeStep> GetImmediateChildSteps() { }

	public int GetNumOfDegrades(int totalHealthOfNextStep) { }

	public List<BloonDegradeStep> GetSteps(int currentTotalHealth, int totalHealthAfterDamage, int damage, int currentLayerHealth) { }

	public List<BloonDegradeStep> GetStepsForLayerIndex(int layerIndex) { }

}

