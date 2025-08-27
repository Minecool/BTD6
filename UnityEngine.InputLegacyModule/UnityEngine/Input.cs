namespace UnityEngine;

[NativeHeader("Runtime/Input/InputBindings.h")]
public class Input
{

	public static Vector3 acceleration
	{
		[FreeFunction("GetAcceleration")]
		 get { } //Length: 62
	}

	[NativeThrows]
	public static bool anyKey
	{
		 get { } //Length: 42
	}

	[NativeThrows]
	public static bool anyKeyDown
	{
		 get { } //Length: 42
	}

	public static Vector2 compositionCursorPos
	{
		 get { } //Length: 59
		 set { } //Length: 52
	}

	public static string compositionString
	{
		 get { } //Length: 42
	}

	public static DeviceOrientation deviceOrientation
	{
		[FreeFunction("GetDeviceOrientation")]
		 get { } //Length: 42
	}

	public static IMECompositionMode imeCompositionMode
	{
		 get { } //Length: 42
		 set { } //Length: 49
	}

	[NativeThrows]
	public static Vector3 mousePosition
	{
		 get { } //Length: 62
	}

	public static bool mousePresent
	{
		[FreeFunction("GetMousePresent")]
		 get { } //Length: 42
	}

	[NativeThrows]
	public static Vector2 mouseScrollDelta
	{
		 get { } //Length: 59
	}

	public static bool multiTouchEnabled
	{
		[FreeFunction("SetMultiTouchEnabled")]
		 set { } //Length: 51
	}

	public static int touchCount
	{
		[FreeFunction("GetTouchCount")]
		 get { } //Length: 42
	}

	public static Touch[] touches
	{
		 get { } //Length: 288
	}

	public static bool touchSupported
	{
		[FreeFunction("IsTouchSupported")]
		 get { } //Length: 42
	}

	internal static bool CheckDisabled() { }

	[NativeThrows]
	public static void ClearLastPenContactEvent() { }

	[FreeFunction("GetAcceleration")]
	public static Vector3 get_acceleration() { }

	private static void get_acceleration_Injected(out Vector3 ret) { }

	public static bool get_anyKey() { }

	public static bool get_anyKeyDown() { }

	public static Vector2 get_compositionCursorPos() { }

	private static void get_compositionCursorPos_Injected(out Vector2 ret) { }

	public static string get_compositionString() { }

	[FreeFunction("GetDeviceOrientation")]
	public static DeviceOrientation get_deviceOrientation() { }

	public static IMECompositionMode get_imeCompositionMode() { }

	public static Vector3 get_mousePosition() { }

	private static void get_mousePosition_Injected(out Vector3 ret) { }

	[FreeFunction("GetMousePresent")]
	public static bool get_mousePresent() { }

	public static Vector2 get_mouseScrollDelta() { }

	private static void get_mouseScrollDelta_Injected(out Vector2 ret) { }

	[FreeFunction("GetTouchCount")]
	public static int get_touchCount() { }

	public static Touch[] get_touches() { }

	[FreeFunction("IsTouchSupported")]
	public static bool get_touchSupported() { }

	public static float GetAxis(string axisName) { }

	public static float GetAxisRaw(string axisName) { }

	public static bool GetButtonDown(string buttonName) { }

	public static bool GetKey(KeyCode key) { }

	public static bool GetKeyDown(KeyCode key) { }

	[NativeThrows]
	private static bool GetKeyDownInt(KeyCode key) { }

	[NativeThrows]
	private static bool GetKeyInt(KeyCode key) { }

	public static bool GetKeyUp(KeyCode key) { }

	[NativeThrows]
	private static bool GetKeyUpInt(KeyCode key) { }

	[NativeThrows]
	public static PenData GetLastPenContactEvent() { }

	private static void GetLastPenContactEvent_Injected(out PenData ret) { }

	[NativeThrows]
	public static bool GetMouseButton(int button) { }

	[NativeThrows]
	public static bool GetMouseButtonDown(int button) { }

	[NativeThrows]
	public static bool GetMouseButtonUp(int button) { }

	[NativeThrows]
	public static Touch GetTouch(int index) { }

	private static void GetTouch_Injected(int index, out Touch ret) { }

	public static void set_compositionCursorPos(Vector2 value) { }

	private static void set_compositionCursorPos_Injected(ref Vector2 value) { }

	public static void set_imeCompositionMode(IMECompositionMode value) { }

	[FreeFunction("SetMultiTouchEnabled")]
	public static void set_multiTouchEnabled(bool value) { }

}

