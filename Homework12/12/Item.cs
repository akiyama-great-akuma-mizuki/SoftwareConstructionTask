using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
// [assembly: AssemblyTitle("todoapi")]
// [assembly: AssemblyDescription("")]
// [assembly: AssemblyConfiguration("")]
// [assembly: AssemblyCompany("")]
// [assembly: AssemblyProduct("todoapi")]
// [assembly: AssemblyCopyright("Copyright ©  2021")]
// [assembly: AssemblyTrademark("")]
// [assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
// [assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
// [assembly: Guid("c2e5f997-2529-440d-8009-056d39a78f40")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// [assembly: AssemblyVersion("1.0.0.0")]
// [assembly: AssemblyFileVersion("1.0.0.0")]
public class TodoItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsComplete { get; set; }
}
