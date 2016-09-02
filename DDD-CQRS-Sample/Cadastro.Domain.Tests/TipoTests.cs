using System;
using Xunit;
using Domain.Tipos;

namespace Cadastro.Domain.Tests
{
    public class TipoTests
    {
        [Fact]
        public void Tipo_Cadastrar_Valido()
        {
            var tipo = new Tipo("nome do tipo");
            
        }
    }
}
