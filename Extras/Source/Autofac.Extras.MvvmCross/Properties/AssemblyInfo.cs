using System;
using System.Reflection;

// MvvmCross integration is not marked with APTCA because the MvvmCross
// framework is all SecurityCritical by default.
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("Autofac.Extras.MvvmCross")]

// MvvmCross is not marked CLS compliant.
[assembly: CLSCompliant(false)]

[assembly: ComVisible(false)]