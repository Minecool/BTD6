namespace Assets.Scripts.Unity.Gamepad;

public class Spring
{
	private class PhysicsState
	{
		public float position; //Field offset: 0x10
		public float velocity; //Field offset: 0x14

		public PhysicsState() { }

	}

	private static int ID; //Field offset: 0x0
	private const float MAX_DELTA_TIME_SEC = 0.064; //Field offset: 0x0
	private const float SOLVER_TIMESTEP_SEC = 0.001; //Field offset: 0x0
	private SpringConfig mSpringConfig; //Field offset: 0x10
	private bool mOvershootClampingEnabled; //Field offset: 0x18
	private string mId; //Field offset: 0x20
	private PhysicsState mCurrentState; //Field offset: 0x28
	private PhysicsState mPreviousState; //Field offset: 0x30
	private PhysicsState mTempState; //Field offset: 0x38
	private float mStartValue; //Field offset: 0x40
	private float mEndValue; //Field offset: 0x44
	private bool mWasAtRest; //Field offset: 0x48
	private float mRestSpeedThreshold; //Field offset: 0x4C
	private float mDisplacementFromRestThreshold; //Field offset: 0x50
	private float mTimeAccumulator; //Field offset: 0x54
	[CompilerGenerated]
	private Action<Spring> onSpringEndStateChange; //Field offset: 0x58
	[CompilerGenerated]
	private Action<Spring> onSpringUpdate; //Field offset: 0x60
	[CompilerGenerated]
	private Action<Spring> onSpringActivate; //Field offset: 0x68
	[CompilerGenerated]
	private Action<Spring> onSpringAtRest; //Field offset: 0x70

	public event Action<Spring> onSpringActivate
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action<Spring> onSpringAtRest
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action<Spring> onSpringEndStateChange
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action<Spring> onSpringUpdate
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public Spring() { }

	[CompilerGenerated]
	public void add_onSpringActivate(Action<Spring> value) { }

	[CompilerGenerated]
	public void add_onSpringAtRest(Action<Spring> value) { }

	[CompilerGenerated]
	public void add_onSpringEndStateChange(Action<Spring> value) { }

	[CompilerGenerated]
	public void add_onSpringUpdate(Action<Spring> value) { }

	public void Advance(float realDeltaTime) { }

	public bool CurrentValueIsApproximately(float value) { }

	public float GetCurrentDisplacementDistance() { }

	public float GetCurrentValue() { }

	private float GetDisplacementDistanceForState(PhysicsState state) { }

	public float GetEndValue() { }

	public string GetId() { }

	public float GetRestDisplacementThreshold() { }

	public float GetRestSpeedThreshold() { }

	public SpringConfig GetSpringConfig() { }

	public float GetStartValue() { }

	public float GetVelocity() { }

	private void Interpolate(float alpha) { }

	public bool IsAtRest() { }

	public bool IsOvershootClampingEnabled() { }

	public bool IsOvershooting() { }

	[CompilerGenerated]
	public void remove_onSpringActivate(Action<Spring> value) { }

	[CompilerGenerated]
	public void remove_onSpringAtRest(Action<Spring> value) { }

	[CompilerGenerated]
	public void remove_onSpringEndStateChange(Action<Spring> value) { }

	[CompilerGenerated]
	public void remove_onSpringUpdate(Action<Spring> value) { }

	public Spring SetAtRest() { }

	public Spring SetCurrentValue(float currentValue, bool setAtRest) { }

	public Spring SetCurrentValue(float currentValue) { }

	public Spring SetEndValue(float endValue) { }

	public Spring SetOvershootClampingEnabled(bool overshootClampingEnabled) { }

	public Spring SetRestDisplacementThreshold(float displacementFromRestThreshold) { }

	public Spring SetRestSpeedThreshold(float restSpeedThreshold) { }

	public Spring SetSpringConfig(SpringConfig springConfig) { }

	public Spring SetVelocity(float velocity) { }

	public bool SystemShouldAdvance() { }

	public bool WasAtRest() { }

}

