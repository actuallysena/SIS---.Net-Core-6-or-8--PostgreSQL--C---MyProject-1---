﻿using System;
using System.Collections.Generic;

namespace OBS_DataAccessLayer.Models;

public partial class Yonetici
{
    public int YoneticiId { get; set; }

    public string Adi { get; set; } = null!;

    public string Soyadi { get; set; } = null!;

    public string Sifre { get; set; } = null!;
}
