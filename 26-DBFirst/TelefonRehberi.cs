using System;
using System.Collections.Generic;

namespace _26_DBFirst;

public partial class TelefonRehberi
{
    public int KisiId { get; set; }

    public string KisiAd { get; set; } = null!;

    public string KisiSoyadi { get; set; } = null!;

    public string KisiTelefon { get; set; } = null!;
}
