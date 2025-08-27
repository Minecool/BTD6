namespace UnityEngine.InputSystem;

internal static class InputAnalytics
{
	internal struct FirstUserInteractionEventData : IInputAnalyticData
	{

	}

	internal interface IInputAnalytic
	{

		public InputAnalyticInfo info
		{
			 get { } //Length: 0
		}

		public InputAnalyticInfo get_info() { }

		public bool TryGatherData(out IInputAnalyticData data, out Exception error) { }

	}

	internal interface IInputAnalyticData
	{

	}

	internal struct InputAnalyticInfo
	{
		public readonly string Name; //Field offset: 0x0
		public readonly int MaxEventsPerHour; //Field offset: 0x8
		public readonly int MaxNumberOfElements; //Field offset: 0xC

		public InputAnalyticInfo(string name, int maxEventsPerHour, int maxNumberOfElements) { }

	}

	internal struct ShutdownEventData : IInputAnalyticData
	{
		public int max_num_devices; //Field offset: 0x0
		public int max_state_size_in_bytes; //Field offset: 0x4
		public int total_event_bytes; //Field offset: 0x8
		public int total_event_count; //Field offset: 0xC
		public int total_frame_count; //Field offset: 0x10
		public float total_event_processing_time; //Field offset: 0x14

	}

	[IsReadOnly]
	internal struct ShutdownEventDataAnalytic : IInputAnalytic
	{
		public const string kEventName = "input_shutdown"; //Field offset: 0x0
		public const int kMaxEventsPerHour = 100; //Field offset: 0x0
		public const int kMaxNumberOfElements = 100; //Field offset: 0x0
		private readonly InputManager m_InputManager; //Field offset: 0x0

		public override InputAnalyticInfo info
		{
			 get { } //Length: 70
		}

		public ShutdownEventDataAnalytic(InputManager manager) { }

		public override InputAnalyticInfo get_info() { }

		public override bool TryGatherData(out IInputAnalyticData data, out Exception error) { }

	}

	internal struct StartupEventAnalytic : IInputAnalytic
	{
		public const string kEventName = "input_startup"; //Field offset: 0x0
		public const int kMaxEventsPerHour = 100; //Field offset: 0x0
		public const int kMaxNumberOfElements = 100; //Field offset: 0x0
		private InputManager m_InputManager; //Field offset: 0x0

		public override InputAnalyticInfo info
		{
			 get { } //Length: 70
		}

		public StartupEventAnalytic(InputManager manager) { }

		private static DeviceInfo[] CollectRecognizedDevices(InputManager manager) { }

		private static DeviceInfo[] CollectUnrecognizedDevices(InputManager manager) { }

		public override InputAnalyticInfo get_info() { }

		public override bool TryGatherData(out IInputAnalyticData data, out Exception error) { }

	}

	internal struct StartupEventData : IInputAnalyticData
	{
		internal struct DeviceInfo
		{
			public string layout; //Field offset: 0x0
			public string interface; //Field offset: 0x8
			public string product; //Field offset: 0x10
			public bool native; //Field offset: 0x18

			public static DeviceInfo FromDescription(InputDeviceDescription description, bool native = false, string layout = null) { }

		}

		public string version; //Field offset: 0x0
		public DeviceInfo[] devices; //Field offset: 0x8
		public DeviceInfo[] unrecognized_devices; //Field offset: 0x10

	}

	public const string kVendorKey = "unity.input"; //Field offset: 0x0

	public static void Initialize(InputManager manager) { }

	public static void OnShutdown(InputManager manager) { }

	public static void OnStartup(InputManager manager) { }

}

