namespace Assets.Scripts.Unity.Gamepad;

public class SpringVec2
{
	public Spring x; //Field offset: 0x10
	public Spring y; //Field offset: 0x18

	public SpringVec2() { }

	public SpringVec2 Advance(float realDeltaTime) { }

	public Vector2 GetCurrentValue() { }

	public Vector2 GetEndValue() { }

	public bool IsAtRest() { }

	public SpringVec2 SetCurrentValue(Vector2 value) { }

	public SpringVec2 SetEndValue(Vector2 value) { }

	public SpringVec2 SetOvershootClampingEnabled(bool overshootClampingEnabled) { }

}

