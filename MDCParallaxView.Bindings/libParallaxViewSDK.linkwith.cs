using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libParallaxViewSDK.a", LinkTarget.Simulator | LinkTarget.ArmV7, ForceLoad = true)]
