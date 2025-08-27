namespace Assets.Scripts.Unity.VisionOS;

public static class VisionOSUtils
{
	private interface IVisionOSImpl
	{

		public float AspectRatio
		{
			 get { } //Length: 0
		}

		public float CanvasScale
		{
			 get { } //Length: 0
		}

		public float PanelOffset
		{
			 get { } //Length: 0
		}

		public Bounds VolumeBounds
		{
			 get { } //Length: 0
		}

		public void DealWithInput() { }

		public float get_AspectRatio() { }

		public float get_CanvasScale() { }

		public float get_PanelOffset() { }

		public Bounds get_VolumeBounds() { }

		public void MoveCanvasIntoScreenSpace(Canvas canvas) { }

		public void MoveCanvasIntoWorldSpace(Canvas canvas) { }

		public bool PollForTouch() { }

		public void Setup() { }

	}

	private class VisionOSNotActive : IVisionOSImpl
	{

		private override float Assets.Scripts.Unity.VisionOS.VisionOSUtils.IVisionOSImpl.AspectRatio
		{
			private get { } //Length: 54
		}

		private override float Assets.Scripts.Unity.VisionOS.VisionOSUtils.IVisionOSImpl.CanvasScale
		{
			private get { } //Length: 4
		}

		private override float Assets.Scripts.Unity.VisionOS.VisionOSUtils.IVisionOSImpl.PanelOffset
		{
			private get { } //Length: 4
		}

		private override Bounds Assets.Scripts.Unity.VisionOS.VisionOSUtils.IVisionOSImpl.VolumeBounds
		{
			private get { } //Length: 16
		}

		public VisionOSNotActive() { }

		private override void Assets.Scripts.Unity.VisionOS.VisionOSUtils.IVisionOSImpl.DealWithInput() { }

		private override float Assets.Scripts.Unity.VisionOS.VisionOSUtils.IVisionOSImpl.get_AspectRatio() { }

		private override float Assets.Scripts.Unity.VisionOS.VisionOSUtils.IVisionOSImpl.get_CanvasScale() { }

		private override float Assets.Scripts.Unity.VisionOS.VisionOSUtils.IVisionOSImpl.get_PanelOffset() { }

		private override Bounds Assets.Scripts.Unity.VisionOS.VisionOSUtils.IVisionOSImpl.get_VolumeBounds() { }

		private override void Assets.Scripts.Unity.VisionOS.VisionOSUtils.IVisionOSImpl.MoveCanvasIntoScreenSpace(Canvas canvas) { }

		private override void Assets.Scripts.Unity.VisionOS.VisionOSUtils.IVisionOSImpl.MoveCanvasIntoWorldSpace(Canvas canvas) { }

		private override bool Assets.Scripts.Unity.VisionOS.VisionOSUtils.IVisionOSImpl.PollForTouch() { }

		private override void Assets.Scripts.Unity.VisionOS.VisionOSUtils.IVisionOSImpl.Setup() { }

	}

	private static readonly IVisionOSImpl impl; //Field offset: 0x0

	public static float AspectRatio
	{
		 get { } //Length: 116
	}

	public static float CanvasScale
	{
		 get { } //Length: 116
	}

	public static float PanelOffset
	{
		 get { } //Length: 116
	}

	public static Bounds VolumeBounds
	{
		 get { } //Length: 265
	}

	private static VisionOSUtils() { }

	public static void DealWithInput() { }

	public static float get_AspectRatio() { }

	public static float get_CanvasScale() { }

	public static float get_PanelOffset() { }

	public static Bounds get_VolumeBounds() { }

	public static void MoveCanvasIntoScreenSpace(Canvas canvas) { }

	public static void MoveCanvasIntoWorldSpace(Canvas canvas) { }

	public static bool PollForTouch() { }

	public static void Setup() { }

}

