using System.Runtime.InteropServices;

namespace Builder.Services.FunctionalBuilder;

public static class PersonBuilderExtensions
{
    public static PersonBuilder WorksAs
        (this PersonBuilder builder, string role)
    {
        builder.Actions.Add(p =>
        {
            p.Position = role;
        });

        return builder;
    }
}