using System;
using System.Linq;

namespace WishListTests
{
    public static class TestHelpers
    {
        private static readonly string _projectName = "WishList";

        public static Type GetUserType(string fullName)
        {
            return (from assembly in AppDomain.CurrentDomain.GetAssemblies()
                    where assembly.FullName.StartsWith(_projectName)
                    from type in assembly.GetTypes()
                    where type.FullName == fullName
                    select type).FirstOrDefault();
        }
        
        // public static Type GetUserType2(string fullName)
        // {
        //     var loadedAssemblies = AppDomain.CurrentDomain.GetAssemblies();
        //     var assemblies = loadedAssemblies.Where(x => x.FullName.StartsWith(_projectName)).ToList();
        //     var types = assemblies.SelectMany(x => x.GetTypes()).ToList();
        //     var fullnameType = types.Where(x => x.FullName == fullName).ToList();
        //     var type = fullnameType.Select(x => x).FirstOrDefault();
        //
        //     return type;
        // }
    }
}
