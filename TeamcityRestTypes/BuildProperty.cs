// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TcBuild.cs" company="">
//   
// </copyright>
// <summary>
//   The tc build.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace TeamcityTypes
{
    public class BuildProperty
    {
        public string Name { get; set; }

        public string Value { get; set; }

        public bool Inherited { get; set; }
    }
}