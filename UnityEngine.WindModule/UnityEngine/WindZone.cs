namespace UnityEngine;

[NativeHeader("Modules/Wind/Public/Wind.h")]
public class WindZone : Component
{

	public WindZoneMode mode
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public float radius
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public float windMain
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public float windPulseFrequency
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public float windPulseMagnitude
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public float windTurbulence
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public WindZone() { }

	public WindZoneMode get_mode() { }

	private static WindZoneMode get_mode_Injected(IntPtr _unity_self) { }

	public float get_radius() { }

	private static float get_radius_Injected(IntPtr _unity_self) { }

	public float get_windMain() { }

	private static float get_windMain_Injected(IntPtr _unity_self) { }

	public float get_windPulseFrequency() { }

	private static float get_windPulseFrequency_Injected(IntPtr _unity_self) { }

	public float get_windPulseMagnitude() { }

	private static float get_windPulseMagnitude_Injected(IntPtr _unity_self) { }

	public float get_windTurbulence() { }

	private static float get_windTurbulence_Injected(IntPtr _unity_self) { }

	public void set_mode(WindZoneMode value) { }

	private static void set_mode_Injected(IntPtr _unity_self, WindZoneMode value) { }

	public void set_radius(float value) { }

	private static void set_radius_Injected(IntPtr _unity_self, float value) { }

	public void set_windMain(float value) { }

	private static void set_windMain_Injected(IntPtr _unity_self, float value) { }

	public void set_windPulseFrequency(float value) { }

	private static void set_windPulseFrequency_Injected(IntPtr _unity_self, float value) { }

	public void set_windPulseMagnitude(float value) { }

	private static void set_windPulseMagnitude_Injected(IntPtr _unity_self, float value) { }

	public void set_windTurbulence(float value) { }

	private static void set_windTurbulence_Injected(IntPtr _unity_self, float value) { }

}

