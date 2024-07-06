using MagicVilla_API.Models.Dto;

namespace MagicVilla_API.Data
{
    public static class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto> 
        {
            new VillaDto{Id = 1, Nombre = "Vista a la piscina", MetrosCuadrados = 100, Ocupantes = 1},
            new VillaDto{Id = 2, Nombre = "Vista a la playa", MetrosCuadrados = 200, Ocupantes = 2},

        };
    }
}
