namespace UnityEngine.CrashReportHandler;

[NativeHeader("Modules/CrashReporting/Public/CrashReporter.h")]
[StaticAccessor("CrashReporting::CrashReporter::Get()", StaticAccessorType::Dot (0))]
public class CrashReportHandler
{

	[NativeProperty("Enabled")]
	public static bool enableCaptureExceptions
	{
		 set { } //Length: 51
	}

	public static void set_enableCaptureExceptions(bool value) { }

	[NativeThrows]
	public static void SetUserMetadata(string key, string value) { }

}

