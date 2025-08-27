namespace UnityEngine.Rendering;

public interface IGPUResidentRenderPipeline
{

	public GPUResidentDrawerSettings gpuResidentDrawerSettings
	{
		 get { } //Length: 0
	}

	public GPUResidentDrawerSettings get_gpuResidentDrawerSettings() { }

	public bool IsGPUResidentDrawerSupportedBySRP(out string message, out LogType severity) { }

	public static void ReinitializeGPUResidentDrawer() { }

}

