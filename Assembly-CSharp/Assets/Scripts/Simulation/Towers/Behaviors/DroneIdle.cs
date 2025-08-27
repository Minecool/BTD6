namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class DroneIdle : TowerBehavior
{
	public DroneIdleModel droneIdleModel; //Field offset: 0x68
	public bool canEndCustomMovement; //Field offset: 0x70
	private int inactiveFrames; //Field offset: 0x74
	private int ignoreTargetingFrames; //Field offset: 0x78
	private int framesOutsideOfRange; //Field offset: 0x7C
	private int framesSinceValidTarget; //Field offset: 0x80
	private int framesSinceIdleReposition; //Field offset: 0x84
	private bool forceMoveWhenNotBeingRedeployed; //Field offset: 0x88
	private Attack mainAttack; //Field offset: 0x90
	private Tower parentTower; //Field offset: 0x98
	private HeliMovement heliMovement; //Field offset: 0xA0
	private AirUnit airUnit; //Field offset: 0xA8
	private int currentIdleRepositionFrames; //Field offset: 0xB0
	private DisplayBehavior currentLight; //Field offset: 0xB8
	private PursuitSettingCustom pursuitSettingCustom; //Field offset: 0xC0

	public AirUnit AirUnit
	{
		 get { } //Length: 102
	}

	public HeliMovement HeliMovement
	{
		 get { } //Length: 102
	}

	public int IgnoreTargetingFrames
	{
		 get { } //Length: 4
		 set { } //Length: 144
	}

	public int InactiveFrames
	{
		 get { } //Length: 4
		 set { } //Length: 253
	}

	public Attack MainAttack
	{
		 get { } //Length: 102
	}

	public Tower ParentTower
	{
		 get { } //Length: 113
	}

	public PursuitSettingCustom PursuitSettingCustom
	{
		 get { } //Length: 102
	}

	public DroneIdle() { }

	public AirUnit get_AirUnit() { }

	public HeliMovement get_HeliMovement() { }

	public int get_IgnoreTargetingFrames() { }

	public int get_InactiveFrames() { }

	public Attack get_MainAttack() { }

	public Tower get_ParentTower() { }

	public PursuitSettingCustom get_PursuitSettingCustom() { }

	private void IdleMove() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	public void set_IgnoreTargetingFrames(int value) { }

	public void set_InactiveFrames(int value) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	public void UpdateLight() { }

}

