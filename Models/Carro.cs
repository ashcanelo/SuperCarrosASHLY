using System;
using System.Collections.Generic;

namespace SuperCarrosASH.Models
{
    public partial class Carro
    {
        public int Id { get; set; }
        public string Marca { get; set; } = null!;
        public string Modelo { get; set; } = null!;
        public string Año { get; set; } = null!;
        public int Precio { get; set; }
        public string Estado { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string? Image { get; set; }
    }
}
