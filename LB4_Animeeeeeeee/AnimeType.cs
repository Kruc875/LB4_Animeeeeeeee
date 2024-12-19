using System;
using System.Collections.Generic;

namespace LB4_Animeeeeeeee;

public partial class AnimeType
{
    public short Id { get; set; }

    public string AnimeOfType { get; set; } = null!;

    public virtual ICollection<AnimeTitle> AnimeTitles { get; set; } = new List<AnimeTitle>();
}
