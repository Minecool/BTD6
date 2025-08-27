namespace UnityEngine.InputSystem.LowLevel;

[Flags]
internal enum TouchFlags
{
	IndirectTouch = 1,
	PrimaryTouch = 8,
	TapPress = 16,
	TapRelease = 32,
	OrphanedPrimaryTouch = 64,
	BeganInSameFrame = 128,
}

