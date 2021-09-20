using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_PersonalAdministrador:BE_Personal
    {
        public BE_PersonalAdministrador() 
        {
            this.Tipo_Personal = "Administrador";
            CalcularSalario();
        }
        public override void CalcularSalario()
        {
          this.Salario = this.SueldBasico  += 5000;
        }
    }
}
