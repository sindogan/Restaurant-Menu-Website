using System.ComponentModel.DataAnnotations;

public class Urun
{
    [Key]
    public int UrunId { get; set; }
    public string? UrunAdi { get; set; }
    public string? Aciklama { get; set; }
    public decimal Fiyat { get; set; }
    public string? Resim { get; set; }

    public int KategoriId { get; set; }
    public Kategori? Kategori { get; set; }
}
