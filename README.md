These are .NET 9 bindings for the newest Swift version of [Lottie iOS](https://github.com/airbnb/lottie-ios/) v4.5.2 (May 2025)

Install `QotoQot.Bindings.Lottie.iOS` from Nuget, add YourAnimation.json into `Resources/` in your iOS project, and then in your code:

```csharp
using QotoQot.Bindings.Lottie.iOS;

…

var yourAnimation = new CompatibleAnimation("YourAnimation", null, NSBundle.MainBundle);
var animationView = new CompatibleAnimationView(yourAnimation);
currentView.AddSubview(animationView);
animationView.Play();
```
