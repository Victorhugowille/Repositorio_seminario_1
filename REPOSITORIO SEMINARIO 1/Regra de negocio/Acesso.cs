using System;
// verifica se a hora q a pessoa digitou é válida, se esta entre as 8 e 18
namespace RegrasDeNegocio
{
    public class Acesso
    {
        public bool HorarioPermitido(DateTime horario)
        {
            return horario.Hour >= 8 && horario.Hour < 18;
        }
    }
}
