using System.Collections.Generic;
using GuruCSharp.Data;

namespace GuruCSharp.Sections;

public class LoopSection : Section
{
    public LoopSection()
    {
        Tests = new List<Test>()
        {
            new()
            {
                Order = 2,
                Text = "It's a text",
                Variants = new List<TestVariant>()
                {
                    new()
                    {
                        Text = "First variant",
                        IsAnswer = true
                    },
                    new()
                    {
                        Text = "Second variant",
                        IsAnswer = false
                    }
                }
            },
            new()
            {
                Order = 3,
                Text = "It's a text 2"
            },
        };

        Theory = new List<Theory>()
        {
            new()
            {
                Order = 1,
                Text = "It's a theory text"
            }
        };

        CodeTests = new List<CodeTest>();

        InitializeSection();
    }
}