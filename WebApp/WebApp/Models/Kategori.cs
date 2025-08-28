using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Kategori
{
    [Key]
    public int KategoriId { get; set; }
    public string? KategoriAdi{ get; set; }
    public string? KategoriAciklama { get; set; }

    public List<Urun>? Urun { get; set; }
}
