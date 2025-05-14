using System;
using System.Collections.Generic;

namespace DbContextScaffold;

public partial class Test
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public int Tel { get; set; }
}
