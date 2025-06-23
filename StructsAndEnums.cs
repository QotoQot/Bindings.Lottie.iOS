using ObjCRuntime;

namespace QotoQot.Bindings.Lottie.iOS;

[Native]
public enum CompatibleBackgroundBehavior : long
{
	Stop = 0,
	Pause = 1,
	PauseAndRestore = 2,
	ForceFinish = 3,
	ContinuePlaying = 4
}

[Native]
public enum CompatibleRenderingEngineOption : long
{
	Shared = 0,
	DefaultEngine = 1,
	Automatic = 2,
	MainThread = 3,
	CoreAnimation = 4
}
