namespace Assets.Scripts.Unity.Gamepad;

public class SpringConfig
{
	public const float DEFAULT_TENSION = 230.2; //Field offset: 0x0
	public const float DEFAULT_FRICTION = 22; //Field offset: 0x0
	public static SpringConfig defaultConfig; //Field offset: 0x0
	public static SpringConfig noOvershootConfig; //Field offset: 0x8
	public static SpringConfig buttonConfig; //Field offset: 0x10
	public static SpringConfig radialConfig; //Field offset: 0x18
	public float friction; //Field offset: 0x10
	public float tension; //Field offset: 0x14

	private static SpringConfig() { }

	public SpringConfig(float tension, float friction) { }

}

