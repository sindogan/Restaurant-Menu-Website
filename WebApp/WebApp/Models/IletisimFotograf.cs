﻿using System;
using System.Collections.Generic;

namespace WebApp.Models;

public partial class IletisimFotograf
{
    public int Id { get; set; }

    public string? FotografBuyuk { get; set; }

    public string? FotografKucuk { get; set; }

    public bool? Durumu { get; set; }

    public DateTime? EklenmeTarihi { get; set; }

    public DateTime? GuncellenmeTarihi { get; set; }
}
