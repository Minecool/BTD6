namespace Assets.Scripts.Unity.Display;

internal static class RotationCache
{
	public static float rotationMax; //Field offset: 0x0
	private static bool rotationCacheInitialised; //Field offset: 0x4
	private static readonly int RotationCacheCount; //Field offset: 0x8
	private static Quaternion[] rotationCache; //Field offset: 0x10
	private static Quaternion[] rotationCacheSprite; //Field offset: 0x18

	private static RotationCache() { }

	public static Quaternion GetRotation(float angle, bool isSprite = false) { }

}

