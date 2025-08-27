namespace Assets.Scripts.Unity.Gamepad;

public class SpringColor
{
	public Spring r; //Field offset: 0x10
	public Spring g; //Field offset: 0x18
	public Spring b; //Field offset: 0x20
	public Spring a; //Field offset: 0x28

	public SpringColor() { }

	public SpringColor Advance(float realDeltaTime) { }

	public Color GetCurrentValue() { }

	public Color GetEndValue() { }

	public bool IsAtRest() { }

	public SpringColor SetCurrentValue(Color value) { }

	public SpringColor SetEndValue(Color value) { }

	public SpringColor SetOvershootClampingEnabled(bool overshootClampingEnabled) { }

	public SpringColor SetSpringConfig(SpringConfig springConfig) { }

}

